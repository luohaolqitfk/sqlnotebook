﻿using System;

namespace SqlNotebookScript.Interpreter;

public sealed class UncaughtErrorScriptException : ScriptException {
    public string ErrorMessage { get; }
    public UncaughtErrorScriptException(string errorMessage, Exception innerException = null)
        : base(errorMessage.ToString(), innerException) {
        ErrorMessage = errorMessage;
    }
}
