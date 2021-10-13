# Release procedure:
# - Delete src\SqlNotebook\bin\
# - Delete src\SqlNotebook\obj\
# - Delete web\site\
# - Bump AssemblyFileVersion in src\SqlNotebook\Properties\AssemblyInfo.cs
# - Bump ProductVersion in SqlNotebook.wxs
# - Update web\appversion.txt with new version and MSI URL
# - Run ps1\Update-Docs.ps1
# - In Dev Command Prompt, in src\SqlNotebook:
#       - msbuild /t:restore /p:Configuration=Release /p:Platform=x64 /p:RuntimeIdentifier=win-x64 SqlNotebook.csproj
#       - msbuild /t:publish /p:Configuration=Release /p:Platform=x64 /p:PublishProfile=FolderProfile SqlNotebook.csproj
# - Run ps1\New-Release.ps1
# - Verify version in SqlNotebook.exe and .msi
# - Run ps1\Update-Website.ps1
# - Create release on GitHub, upload zip and msi.
# - Upload web\site to sqlnotebook.com/. Make public.
# - Update src\chocolatey\sqlnotebook.nuspec with version
# - Update src\chocolatey\tools\chocolateyInstall.ps1 with MSI URL
# - Run choco pack
# - Run choco apikey -k <chocolatey api key> -source https://chocolatey.org/
# - Run choco push .\sqlnotebook.X.X.X.nupkg -s https://chocolatey.org/
# - Commit changes using commit message "Version X.X.X"
# - Push origin master
# - Make release on GitHub

$ErrorActionPreference = "Stop"
Set-StrictMode -Version 3
Add-Type -AssemblyName System.IO.Compression
Add-Type -AssemblyName System.IO.Compression.FileSystem

$wixDir = "C:\Program Files (x86)\WiX Toolset v3.11\bin"
if (-not (Test-Path $wixDir)) {
    throw "WiX not found!"
}

$ps1Dir = $PSScriptRoot
$rootDir = (Resolve-Path (Join-Path $ps1Dir "..\")).Path
$srcDir = Join-Path $rootDir "src"
$binDir = Join-Path $srcDir "SqlNotebook\bin"
$relDir = Join-Path $srcDir "SqlNotebook\bin\publish"
$tempWxsFilePath = "$srcDir\SqlNotebook\bin\temp.wxs"

Remove-Item "$relDir\portable" -Recurse -ErrorAction SilentlyContinue
Remove-Item "$relDir\*.pdb" -ErrorAction SilentlyContinue
Remove-Item "$relDir\*.wixpdb" -ErrorAction SilentlyContinue
Remove-Item "$relDir\*.wixobj" -ErrorAction SilentlyContinue
Remove-Item "$relDir\*.wxs" -ErrorAction SilentlyContinue

Push-Location $relDir

$msiFilename = "SQLNotebook.msi"
$msiFilePath = "$binDir\$msiFilename"
$zipFilePath = "$binDir\SQLNotebook.zip"

rm "$relDir\$msiFilename" -ErrorAction SilentlyContinue
rm $zipFilePath -ErrorAction SilentlyContinue
rm "$relDir\SqlNotebook.wixobj" -ErrorAction SilentlyContinue
rm "$relDir\SqlNotebook.wxs" -ErrorAction SilentlyContinue

#
# Generate portable ZIP
#

[System.IO.Compression.ZipFile]::CreateFromDirectory($relDir, $zipFilePath)

#
# Generate MSI
#

# Replace <!--FILES--> in the wxs file with <File> entries
$filesXml = ""
$refsXml = ""

Write-Host "`"$wixDir\heat.exe`" dir -o `"$tempWxsFilePath`" -cg SqlNotebookComponentGroup -sfrag -gg -g1 -sreg -svb6 -scom"
& "$wixDir\heat.exe" dir . -o "$tempWxsFilePath" -cg SqlNotebookComponentGroup -sfrag -gg -g1 -sreg -svb6 -scom -suid
$heatLines = [System.IO.File]::ReadAllLines($tempWxsFilePath)
Remove-Item $tempWxsFilePath
$doneWithFilesXml = $false
for ($i = 5; $i -lt $heatLines.Length; $i++) {
    if ($heatLines[$i].Contains("</DirectoryRef>")) {
        $doneWithFilesXml = $true
    }
    if (-not $doneWithFilesXml) {
        $filesXml += $heatLines[$i] + "`r`n"
    }
    if ($heatLines[$i].Contains("<ComponentRef")) {
        $refsXml += $heatLines[$i] + "`r`n"
    }
}
$filesXml = $filesXml.Substring(0, $filesXml.LastIndexOf('</Directory>')).Replace("<Component ", '<Component Win64="yes" ')

$wxs = (Get-Content "$srcdir\SqlNotebook.wxs").Replace("<!--FILES-->", $filesXml).Replace("<!--REFS-->", $refsXml)
Set-Content "$relDir\SqlNotebook.wxs" $wxs

copy -force "$srcdir\SqlNotebook\SqlNotebookIcon.ico" "$relDir\SqlNotebookIcon.ico"

#& "C:\Program Files (x86)\Windows Kits\10\bin\x64\signtool.exe" sign /n "Brian Luft" /tr http://tsa.startssl.com/rfc3161 "$relDir\SqlNotebook.exe" | Write-Output
#& "C:\Program Files (x86)\Windows Kits\10\bin\x64\signtool.exe" sign /n "Brian Luft" /tr http://tsa.startssl.com/rfc3161 "$relDir\SqlNotebookUpdater.exe" | Write-Output

& "$wixDir\candle.exe" -nologo -pedantic "$relDir\SqlNotebook.wxs" | Write-Output
if (-not (Test-Path "$relDir\SqlNotebook.wixobj")) {
    throw "candle failed to produce SqlNotebook.wixobj"
}

& "$wixDir\light.exe" -nologo -pedantic -ext WixUIExtension -cultures:en-us "$relDir\SqlNotebook.wixobj" | Write-Output
if (-not (Test-Path "$relDir\SqlNotebook.msi")) {
    throw "light failed to produce SqlNotebook.msi"
}

Move-Item -Force "$relDir\SqlNotebook.msi" $msiFilePath

#& "C:\Program Files (x86)\Windows Kits\10\bin\x64\signtool.exe" sign /n "Brian Luft" /tr http://tsa.startssl.com/rfc3161 /d $msiFilename $msiFilePath | Write-Output

Pop-Location
