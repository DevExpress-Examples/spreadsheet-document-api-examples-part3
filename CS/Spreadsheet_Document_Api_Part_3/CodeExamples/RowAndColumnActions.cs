using System;
using DevExpress.Spreadsheet;

namespace SpreadsheetControl_API_Part03
{
    public static class RowAndColumnActions
    {
        static void DeleteRowsBasedOnCondition(IWorkbook workbook)
        {
            #region #DeleteRowsBasedOnCondition
            // Load a document from a file.
            workbook.LoadDocument("Documents\\Document.xlsx");

            // Access a worksheet.
            Worksheet worksheet = workbook.Worksheets[0];

            // Specify the condition to remove worksheet rows.
            // If a value in column "A" is greater than 3
            // and less than 14, remove the corresponding row. 
            Func<int, bool> rowRemovalCondition = x => worksheet.Cells[x, 0].Value.NumericValue > 3.0 && worksheet.Cells[x, 0].Value.NumericValue < 14.0;

            // Fill cells with data.
            for (int i = 0; i < 15; i++)
            {
                worksheet.Cells[i, 0].Value = i + 1;
                worksheet.Cells[0, i].Value = i + 1;
            }

            // Delete all rows that meet the specified condition.
            //worksheet.Rows.Remove(rowRemovalCondition);

            // Delete rows that meet the specified condition.
            // Check from the 8th row.
            worksheet.Rows.Remove(7, rowRemovalCondition);

            // Delete rows that meet the specified condition.
            // Check rows 6 through 15.
            //worksheet.Rows.Remove(5, 14, rowRemovalCondition);
            #endregion #DeleteRowsBasedOnCondition
        }

        static void DeleteColumnssBasedOnCondition(IWorkbook workbook)
        {
            #region #DeleteColumnsBasedOnCondition
            // Load a document from a file.
            workbook.LoadDocument("Documents\\Document.xlsx");

            // Access a worksheet.
            Worksheet worksheet = workbook.Worksheets[0];

            // Specify the condition to remove worksheet columns.
            // If a value in the first row is greater than 3
            // and less than 14, remove the corresponding column. 
            Func<int, bool> columnRemovalCondition = x => worksheet.Cells[0, x].Value.NumericValue > 3.0 && worksheet.Cells[0, x].Value.NumericValue < 14.0;

            // Fill cells with data.
            for (int i = 0; i < 15; i++)
            {
                worksheet.Cells[i, 0].Value = i + 1;
                worksheet.Cells[0, i].Value = i + 1;
            }

            // Delete all columns that meet the specified condition.
            //worksheet.Columns.Remove(columnRemovalCondition);

            // Delete columns that meet the specified condition.
            // Check from the 8th column.
            worksheet.Columns.Remove(7, columnRemovalCondition);

            // Delete columns that meet the specified condition.
            // Check columns "F" through "O".
            //worksheet.Columns.Remove(5, 14, columnRemovalCondition);

            #endregion #DeleteColumnsBasedOnCondition
        }
    }
}
