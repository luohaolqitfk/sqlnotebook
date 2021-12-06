using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tests;

// Update this with ps1/Update-Tests.ps1. Do not edit manually.
public sealed partial class ScriptTest {
    [TestMethod] public void Test_Aggregate_function_filter_clause_sql() => TestScript(@"Aggregate function filter clause.sql");
    [TestMethod] public void Test_ALTER_TABLE_DROP_COLUMN_1_sql() => TestScript(@"ALTER TABLE DROP COLUMN 1.sql");
    [TestMethod] public void Test_ALTER_TABLE_DROP_COLUMN_2_sql() => TestScript(@"ALTER TABLE DROP COLUMN 2.sql");
    [TestMethod] public void Test_ALTER_TABLE_RENAME_COLUMN_1_sql() => TestScript(@"ALTER TABLE RENAME COLUMN 1.sql");
    [TestMethod] public void Test_ALTER_TABLE_RENAME_COLUMN_2_sql() => TestScript(@"ALTER TABLE RENAME COLUMN 2.sql");
    [TestMethod] public void Test_CREATE_TABLE_duplicate_options_sql() => TestScript(@"CREATE TABLE duplicate options.sql");
    [TestMethod] public void Test_CREATE_TABLE_STRICT_sql() => TestScript(@"CREATE TABLE STRICT.sql");
    [TestMethod] public void Test_CREATE_TABLE_WITHOUT_ROWID_sql() => TestScript(@"CREATE TABLE WITHOUT ROWID.sql");
    [TestMethod] public void Test_DELETE_RETURNING_sql() => TestScript(@"DELETE RETURNING.sql");
    [TestMethod] public void Test_EXECUTE_implicitly_using_default_value_sql() => TestScript(@"EXECUTE implicitly using default value.sql");
    [TestMethod] public void Test_EXECUTE_one_explicit__one_default_argument_sql() => TestScript(@"EXECUTE one explicit, one default argument.sql");
    [TestMethod] public void Test_EXECUTE_simple_sql() => TestScript(@"EXECUTE simple.sql");
    [TestMethod] public void Test_EXECUTE_using_EXEC_shorthand_sql() => TestScript(@"EXECUTE using EXEC shorthand.sql");
    [TestMethod] public void Test_EXECUTE_with_DEFAULT_keyword_sql() => TestScript(@"EXECUTE with DEFAULT keyword.sql");
    [TestMethod] public void Test_EXECUTE_with_one_argument_sql() => TestScript(@"EXECUTE with one argument.sql");
    [TestMethod] public void Test_EXECUTE_with_quoted_script_name_sql() => TestScript(@"EXECUTE with quoted script name.sql");
    [TestMethod] public void Test_EXECUTE_with_return_value_sql() => TestScript(@"EXECUTE with return value.sql");
    [TestMethod] public void Test_EXPORT_CSV_HEADER_ROW_0_sql() => TestScript(@"EXPORT CSV HEADER_ROW 0.sql");
    [TestMethod] public void Test_EXPORT_CSV_HEADER_ROW_1_sql() => TestScript(@"EXPORT CSV HEADER_ROW 1.sql");
    [TestMethod] public void Test_EXPORT_CSV_SCRIPT_sql() => TestScript(@"EXPORT CSV SCRIPT.sql");
    [TestMethod] public void Test_EXPORT_CSV_SELECT_sql() => TestScript(@"EXPORT CSV SELECT.sql");
    [TestMethod] public void Test_EXPORT_CSV_SEPARATOR_semicolon_sql() => TestScript(@"EXPORT CSV SEPARATOR semicolon.sql");
    [TestMethod] public void Test_EXPORT_CSV_SEPARATOR_tab_sql() => TestScript(@"EXPORT CSV SEPARATOR tab.sql");
    [TestMethod] public void Test_EXPORT_CSV_TABLE_FILE_ENCODING_sql() => TestScript(@"EXPORT CSV TABLE FILE_ENCODING.sql");
    [TestMethod] public void Test_EXPORT_CSV_TABLE_TRUNCATE_EXISTING_FILE_0_sql() => TestScript(@"EXPORT CSV TABLE TRUNCATE_EXISTING_FILE 0.sql");
    [TestMethod] public void Test_EXPORT_CSV_TABLE_TRUNCATE_EXISTING_FILE_1_sql() => TestScript(@"EXPORT CSV TABLE TRUNCATE_EXISTING_FILE 1.sql");
    [TestMethod] public void Test_EXPORT_CSV_TABLE_TRUNCATE_EXISTING_FILE_default_sql() => TestScript(@"EXPORT CSV TABLE TRUNCATE_EXISTING_FILE default.sql");
    [TestMethod] public void Test_EXPORT_CSV_TABLE_sql() => TestScript(@"EXPORT CSV TABLE.sql");
    [TestMethod] public void Test_EXPORT_TXT_append_sql() => TestScript(@"EXPORT TXT append.sql");
    [TestMethod] public void Test_EXPORT_TXT_Shift_JIS_sql() => TestScript(@"EXPORT TXT Shift-JIS.sql");
    [TestMethod] public void Test_EXPORT_TXT_truncate_sql() => TestScript(@"EXPORT TXT truncate.sql");
    [TestMethod] public void Test_EXPORT_TXT_sql() => TestScript(@"EXPORT TXT.sql");
    [TestMethod] public void Test_GETDATE_sql() => TestScript(@"GETDATE.sql");
    [TestMethod] public void Test_GETUTCDATE_sql() => TestScript(@"GETUTCDATE.sql");
    [TestMethod] public void Test_HOST_NAME_sql() => TestScript(@"HOST_NAME.sql");
    [TestMethod] public void Test_IMPORT_CSV_FILE_ENCODING_sql() => TestScript(@"IMPORT CSV FILE_ENCODING.sql");
    [TestMethod] public void Test_IMPORT_CSV_HEADER_ROW_sql() => TestScript(@"IMPORT CSV HEADER_ROW.sql");
    [TestMethod] public void Test_IMPORT_CSV_IF_CONVERSION_FAILS_sql() => TestScript(@"IMPORT CSV IF_CONVERSION_FAILS.sql");
    [TestMethod] public void Test_IMPORT_CSV_missing_header_1_sql() => TestScript(@"IMPORT CSV missing header 1.sql");
    [TestMethod] public void Test_IMPORT_CSV_missing_header_2_sql() => TestScript(@"IMPORT CSV missing header 2.sql");
    [TestMethod] public void Test_IMPORT_CSV_SKIP_LINES_sql() => TestScript(@"IMPORT CSV SKIP_LINES.sql");
    [TestMethod] public void Test_IMPORT_CSV_TAKE_LINES_sql() => TestScript(@"IMPORT CSV TAKE_LINES.sql");
    [TestMethod] public void Test_IMPORT_CSV_TEMPORARY_TABLE_sql() => TestScript(@"IMPORT CSV TEMPORARY_TABLE.sql");
    [TestMethod] public void Test_IMPORT_CSV_TRUNCATE_EXISTING_TABLE_sql() => TestScript(@"IMPORT CSV TRUNCATE_EXISTING_TABLE.sql");
    [TestMethod] public void Test_IMPORT_TEXT_sql() => TestScript(@"IMPORT TEXT.sql");
    [TestMethod] public void Test_IMPORT_TXT_FILE_ENCODING_sql() => TestScript(@"IMPORT TXT FILE_ENCODING.sql");
    [TestMethod] public void Test_IMPORT_TXT_SKIP_LINES_sql() => TestScript(@"IMPORT TXT SKIP_LINES.sql");
    [TestMethod] public void Test_IMPORT_TXT_TAKE_LINES_sql() => TestScript(@"IMPORT TXT TAKE_LINES.sql");
    [TestMethod] public void Test_IMPORT_TXT_TEMPORARY_TABLE_sql() => TestScript(@"IMPORT TXT TEMPORARY_TABLE.sql");
    [TestMethod] public void Test_IMPORT_TXT_TRUNCATE_EXISTING_TABLE_sql() => TestScript(@"IMPORT TXT TRUNCATE_EXISTING_TABLE.sql");
    [TestMethod] public void Test_IMPORT_XLS_FIRST_COLUMN_first_and_last__letter_sql() => TestScript(@"IMPORT XLS FIRST_COLUMN first and last, letter.sql");
    [TestMethod] public void Test_IMPORT_XLS_FIRST_COLUMN_first_and_last__number_sql() => TestScript(@"IMPORT XLS FIRST_COLUMN first and last, number.sql");
    [TestMethod] public void Test_IMPORT_XLS_FIRST_COLUMN_first_beyond_end_of_data_sql() => TestScript(@"IMPORT XLS FIRST_COLUMN first beyond end of data.sql");
    [TestMethod] public void Test_IMPORT_XLS_FIRST_COLUMN_first_column_only__letter_sql() => TestScript(@"IMPORT XLS FIRST_COLUMN first column only, letter.sql");
    [TestMethod] public void Test_IMPORT_XLS_FIRST_COLUMN_first_column_only__number_sql() => TestScript(@"IMPORT XLS FIRST_COLUMN first column only, number.sql");
    [TestMethod] public void Test_IMPORT_XLS_FIRST_COLUMN_no_column_range_sql() => TestScript(@"IMPORT XLS FIRST_COLUMN no column range.sql");
    [TestMethod] public void Test_IMPORT_XLS_FIRST_ROW_sql() => TestScript(@"IMPORT XLS FIRST_ROW.sql");
    [TestMethod] public void Test_IMPORT_XLS_HEADER_ROW_sql() => TestScript(@"IMPORT XLS HEADER_ROW.sql");
    [TestMethod] public void Test_IMPORT_XLS_IF_CONVERSION_FAILS_sql() => TestScript(@"IMPORT XLS IF_CONVERSION_FAILS.sql");
    [TestMethod] public void Test_IMPORT_XLS_LAST_COLUMN_0__all_columns_sql() => TestScript(@"IMPORT XLS LAST_COLUMN 0, all columns.sql");
    [TestMethod] public void Test_IMPORT_XLS_LAST_COLUMN_last_beyond_end_of_data_sql() => TestScript(@"IMPORT XLS LAST_COLUMN last beyond end of data.sql");
    [TestMethod] public void Test_IMPORT_XLS_LAST_COLUMN_last_column_only_sql() => TestScript(@"IMPORT XLS LAST_COLUMN last column only.sql");
    [TestMethod] public void Test_IMPORT_XLS_LAST_ROW_sql() => TestScript(@"IMPORT XLS LAST_ROW.sql");
    [TestMethod] public void Test_IMPORT_XLS_missing_header_1_sql() => TestScript(@"IMPORT XLS missing header 1.sql");
    [TestMethod] public void Test_IMPORT_XLS_missing_header_2_sql() => TestScript(@"IMPORT XLS missing header 2.sql");
    [TestMethod] public void Test_IMPORT_XLS_STOP_AT_FIRST_BLANK_ROW_0_sql() => TestScript(@"IMPORT XLS STOP_AT_FIRST_BLANK_ROW 0.sql");
    [TestMethod] public void Test_IMPORT_XLS_STOP_AT_FIRST_BLANK_ROW_1_sql() => TestScript(@"IMPORT XLS STOP_AT_FIRST_BLANK_ROW 1.sql");
    [TestMethod] public void Test_IMPORT_XLS_STOP_AT_FIRST_BLANK_ROW_default_sql() => TestScript(@"IMPORT XLS STOP_AT_FIRST_BLANK_ROW default.sql");
    [TestMethod] public void Test_IMPORT_XLS_TEMPORARY_TABLE_sql() => TestScript(@"IMPORT XLS TEMPORARY_TABLE.sql");
    [TestMethod] public void Test_IMPORT_XLS_TRUNCATE_EXISTING_TABLE_sql() => TestScript(@"IMPORT XLS TRUNCATE_EXISTING_TABLE.sql");
    [TestMethod] public void Test_IMPORT_XLS_sql() => TestScript(@"IMPORT XLS.sql");
    [TestMethod] public void Test_IN_table_valued_function_sql() => TestScript(@"IN table-valued function.sql");
    [TestMethod] public void Test_INSERT_RETURNING_sql() => TestScript(@"INSERT RETURNING.sql");
    [TestMethod] public void Test_LIST_FILES_sql() => TestScript(@"LIST_FILES.sql");
    [TestMethod] public void Test_NEWID_sql() => TestScript(@"NEWID.sql");
    [TestMethod] public void Test_NOW_sql() => TestScript(@"NOW.sql");
    [TestMethod] public void Test_ORDER_BY_NULLS_FIRST_sql() => TestScript(@"ORDER BY NULLS FIRST.sql");
    [TestMethod] public void Test_ORDER_BY_NULLS_LAST_sql() => TestScript(@"ORDER BY NULLS LAST.sql");
    [TestMethod] public void Test_READ_CSV_sql() => TestScript(@"READ_CSV.sql");
    [TestMethod] public void Test_READ_FILE_sql() => TestScript(@"READ_FILE.sql");
    [TestMethod] public void Test_READ_FILE_TEXT_sql() => TestScript(@"READ_FILE_TEXT.sql");
    [TestMethod] public void Test_RETURN_from_EXECUTE_sql() => TestScript(@"RETURN from EXECUTE.sql");
    [TestMethod] public void Test_RETURN_with_value_sql() => TestScript(@"RETURN with value.sql");
    [TestMethod] public void Test_RETURN_sql() => TestScript(@"RETURN.sql");
    [TestMethod] public void Test_THROW_from_sub_script_sql() => TestScript(@"THROW from sub-script.sql");
    [TestMethod] public void Test_THROW_rethrow_sql() => TestScript(@"THROW rethrow.sql");
    [TestMethod] public void Test_THROW_sql() => TestScript(@"THROW.sql");
    [TestMethod] public void Test_UPDATE_RETURNING_sql() => TestScript(@"UPDATE RETURNING.sql");
    [TestMethod] public void Test_USER_NAME_sql() => TestScript(@"USER_NAME.sql");
    [TestMethod] public void Test_UUID_sql() => TestScript(@"UUID.sql");
    [TestMethod] public void Test_WITH_MATERIALIZED_sql() => TestScript(@"WITH MATERIALIZED.sql");
    [TestMethod] public void Test_WITH_NOT_MATERIALIZED_sql() => TestScript(@"WITH NOT MATERIALIZED.sql");
    [TestMethod] public void Test_doc_array_append_func_sql() => TestScript(@"doc\array-append-func.sql");
    [TestMethod] public void Test_doc_array_concat_func_sql() => TestScript(@"doc\array-concat-func.sql");
    [TestMethod] public void Test_doc_array_count_func_sql() => TestScript(@"doc\array-count-func.sql");
    [TestMethod] public void Test_doc_array_func_sql() => TestScript(@"doc\array-func.sql");
    [TestMethod] public void Test_doc_array_get_func_sql() => TestScript(@"doc\array-get-func.sql");
    [TestMethod] public void Test_doc_array_insert_func_sql() => TestScript(@"doc\array-insert-func.sql");
    [TestMethod] public void Test_doc_array_merge_func_sql() => TestScript(@"doc\array-merge-func.sql");
    [TestMethod] public void Test_doc_array_set_func_sql() => TestScript(@"doc\array-set-func.sql");
    [TestMethod] public void Test_doc_break_stmt_sql() => TestScript(@"doc\break-stmt.sql");
    [TestMethod] public void Test_doc_choose_func_sql() => TestScript(@"doc\choose-func.sql");
    [TestMethod] public void Test_doc_continue_stmt_sql() => TestScript(@"doc\continue-stmt.sql");
    [TestMethod] public void Test_doc_date_add_func_sql() => TestScript(@"doc\date-add-func.sql");
    [TestMethod] public void Test_doc_date_diff_func_sql() => TestScript(@"doc\date-diff-func.sql");
    [TestMethod] public void Test_doc_date_from_parts_func_sql() => TestScript(@"doc\date-from-parts-func.sql");
    [TestMethod] public void Test_doc_date_name_func_sql() => TestScript(@"doc\date-name-func.sql");
    [TestMethod] public void Test_doc_date_part_func_sql() => TestScript(@"doc\date-part-func.sql");
    [TestMethod] public void Test_doc_date_time_from_parts_func_sql() => TestScript(@"doc\date-time-from-parts-func.sql");
    [TestMethod] public void Test_doc_date_trunc_func_sql() => TestScript(@"doc\date-trunc-func.sql");
    [TestMethod] public void Test_doc_day_func_sql() => TestScript(@"doc\day-func.sql");
    [TestMethod] public void Test_doc_declare_stmt_sql() => TestScript(@"doc\declare-stmt.sql");
    [TestMethod] public void Test_doc_download_func_sql() => TestScript(@"doc\download-func.sql");
    [TestMethod] public void Test_doc_eomonth_func_sql() => TestScript(@"doc\eomonth-func.sql");
    [TestMethod] public void Test_doc_error_message_func_sql() => TestScript(@"doc\error-message-func.sql");
    [TestMethod] public void Test_doc_for_stmt_sql() => TestScript(@"doc\for-stmt.sql");
    [TestMethod] public void Test_doc_gencol_1_sql() => TestScript(@"doc\gencol 1.sql");
    [TestMethod] public void Test_doc_gencol_2_sql() => TestScript(@"doc\gencol 2.sql");
    [TestMethod] public void Test_doc_if_stmt_sql() => TestScript(@"doc\if-stmt.sql");
    [TestMethod] public void Test_doc_import_csv_stmt_sql() => TestScript(@"doc\import-csv-stmt.sql");
    [TestMethod] public void Test_doc_import_txt_stmt_sql() => TestScript(@"doc\import-txt-stmt.sql");
    [TestMethod] public void Test_doc_is_date_func_sql() => TestScript(@"doc\is-date-func.sql");
    [TestMethod] public void Test_doc_is_numeric_func_sql() => TestScript(@"doc\is-numeric-func.sql");
    [TestMethod] public void Test_doc_lang_returning___Typical_Use_sql() => TestScript(@"doc\lang_returning - Typical Use.sql");
    [TestMethod] public void Test_doc_lang_update___UPDATE_FROM_sql() => TestScript(@"doc\lang_update - UPDATE FROM.sql");
    [TestMethod] public void Test_doc_lang_upsert___Examples_1_sql() => TestScript(@"doc\lang_upsert - Examples 1.sql");
    [TestMethod] public void Test_doc_lang_upsert___Examples_2_sql() => TestScript(@"doc\lang_upsert - Examples 2.sql");
    [TestMethod] public void Test_doc_lang_upsert___Examples_3_sql() => TestScript(@"doc\lang_upsert - Examples 3.sql");
    [TestMethod] public void Test_doc_lang_upsert___Parsing_Ambiguity_sql() => TestScript(@"doc\lang_upsert - Parsing Ambiguity.sql");
    [TestMethod] public void Test_doc_list_xls_worksheets_func_sql() => TestScript(@"doc\list-xls-worksheets-func.sql");
    [TestMethod] public void Test_doc_math_funcs_sql() => TestScript(@"doc\math-funcs.sql");
    [TestMethod] public void Test_doc_month_func_sql() => TestScript(@"doc\month-func.sql");
    [TestMethod] public void Test_doc_print_stmt_sql() => TestScript(@"doc\print-stmt.sql");
    [TestMethod] public void Test_doc_rowvalue___Clarity_of_presentation_1_sql() => TestScript(@"doc\rowvalue - Clarity of presentation 1.sql");
    [TestMethod] public void Test_doc_rowvalue___Clarity_of_presentation_2_sql() => TestScript(@"doc\rowvalue - Clarity of presentation 2.sql");
    [TestMethod] public void Test_doc_rowvalue___Comparison_of_dates_stored_as_separate_fields_sql() => TestScript(@"doc\rowvalue - Comparison of dates stored as separate fields.sql");
    [TestMethod] public void Test_doc_rowvalue___Row_Value_Comparisons_1_sql() => TestScript(@"doc\rowvalue - Row Value Comparisons 1.sql");
    [TestMethod] public void Test_doc_rowvalue___Row_Value_Comparisons_2_sql() => TestScript(@"doc\rowvalue - Row Value Comparisons 2.sql");
    [TestMethod] public void Test_doc_rowvalue___Row_Value_Comparisons_3_sql() => TestScript(@"doc\rowvalue - Row Value Comparisons 3.sql");
    [TestMethod] public void Test_doc_rowvalue___Row_Values_In_UPDATE_Statements_sql() => TestScript(@"doc\rowvalue - Row Values In UPDATE Statements.sql");
    [TestMethod] public void Test_doc_rowvalue___Scrolling_Window_Queries_sql() => TestScript(@"doc\rowvalue - Scrolling Window Queries.sql");
    [TestMethod] public void Test_doc_rowvalue___Search_against_multi_column_keys_1_sql() => TestScript(@"doc\rowvalue - Search against multi-column keys 1.sql");
    [TestMethod] public void Test_doc_rowvalue___Search_against_multi_column_keys_2_sql() => TestScript(@"doc\rowvalue - Search against multi-column keys 2.sql");
    [TestMethod] public void Test_doc_rowvalue___Search_against_multi_column_keys_3_sql() => TestScript(@"doc\rowvalue - Search against multi-column keys 3.sql");
    [TestMethod] public void Test_doc_rowvalue___Update_multiple_columns_of_a_table_based_on_a_query_sql_sql() => TestScript(@"doc\rowvalue - Update multiple columns of a table based on a query.sql.sql");
    [TestMethod] public void Test_doc_set_stmt_sql() => TestScript(@"doc\set-stmt.sql");
    [TestMethod] public void Test_doc_split_func_sql() => TestScript(@"doc\split-func.sql");
    [TestMethod] public void Test_doc_stricttables___The_ANY_datatype_1_sql() => TestScript(@"doc\stricttables - The ANY datatype 1.sql");
    [TestMethod] public void Test_doc_stricttables___The_ANY_datatype_2_sql() => TestScript(@"doc\stricttables - The ANY datatype 2.sql");
    [TestMethod] public void Test_doc_to_date_func_sql() => TestScript(@"doc\to-date-func.sql");
    [TestMethod] public void Test_doc_to_date_time_func_sql() => TestScript(@"doc\to-date-time-func.sql");
    [TestMethod] public void Test_doc_try_catch_stmt_sql() => TestScript(@"doc\try-catch-stmt.sql");
    [TestMethod] public void Test_doc_uuid_blob_func_sql() => TestScript(@"doc\uuid-blob-func.sql");
    [TestMethod] public void Test_doc_uuid_str_func_sql() => TestScript(@"doc\uuid-str-func.sql");
    [TestMethod] public void Test_doc_while_stmt_sql() => TestScript(@"doc\while-stmt.sql");
    [TestMethod] public void Test_doc_windowfunctions___Aggregate_Window_Functions_1_sql() => TestScript(@"doc\windowfunctions - Aggregate Window Functions 1.sql");
    [TestMethod] public void Test_doc_windowfunctions___Built_in_Window_Functions_1_sql() => TestScript(@"doc\windowfunctions - Built-in Window Functions 1.sql");
    [TestMethod] public void Test_doc_windowfunctions___Built_in_Window_Functions_2_sql() => TestScript(@"doc\windowfunctions - Built-in Window Functions 2.sql");
    [TestMethod] public void Test_doc_windowfunctions___Built_in_Window_Functions_3_sql() => TestScript(@"doc\windowfunctions - Built-in Window Functions 3.sql");
    [TestMethod] public void Test_doc_windowfunctions___Frame_Boundaries_1_sql() => TestScript(@"doc\windowfunctions - Frame Boundaries 1.sql");
    [TestMethod] public void Test_doc_windowfunctions___Frame_Specifications_1_sql() => TestScript(@"doc\windowfunctions - Frame Specifications 1.sql");
    [TestMethod] public void Test_doc_windowfunctions___Introduction_to_Window_Functions_1_sql() => TestScript(@"doc\windowfunctions - Introduction to Window Functions 1.sql");
    [TestMethod] public void Test_doc_windowfunctions___Introduction_to_Window_Functions_2_sql() => TestScript(@"doc\windowfunctions - Introduction to Window Functions 2.sql");
    [TestMethod] public void Test_doc_windowfunctions___The_EXCLUDE_Clause_1_sql() => TestScript(@"doc\windowfunctions - The EXCLUDE Clause 1.sql");
    [TestMethod] public void Test_doc_windowfunctions___The_FILTER_Clause_1_sql() => TestScript(@"doc\windowfunctions - The FILTER Clause 1.sql");
    [TestMethod] public void Test_doc_windowfunctions___The_PARTITION_BY_Clause_1_sql() => TestScript(@"doc\windowfunctions - The PARTITION BY Clause 1.sql");
    [TestMethod] public void Test_doc_windowfunctions___The_PARTITION_BY_Clause_2_sql() => TestScript(@"doc\windowfunctions - The PARTITION BY Clause 2.sql");
    [TestMethod] public void Test_doc_windowfunctions___Window_Chaining_1_sql() => TestScript(@"doc\windowfunctions - Window Chaining 1.sql");
    [TestMethod] public void Test_doc_year_func_sql() => TestScript(@"doc\year-func.sql");
}
