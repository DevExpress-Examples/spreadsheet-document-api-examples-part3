Imports System
Imports DevExpress.Spreadsheet

Namespace SpreadsheetControl_API_Part03
	Public NotInheritable Class RowAndColumnActions

		Private Sub New()
		End Sub

		Private Shared Sub DeleteRowsBasedOnCondition(ByVal workbook As IWorkbook)
			' #Region "#DeleteRowsBasedOnCondition"
			' Load a document from a file.
			workbook.LoadDocument("Documents\Document.xlsx")

			' Access a worksheet.
			Dim worksheet As Worksheet = workbook.Worksheets(0)

			' Specify the condition to remove worksheet rows.
			' If a value in column "A" is greater than 3
			' and less than 14, remove the corresponding row.
			Dim rowRemovalCondition As Func(Of Integer, Boolean) = Function(x) worksheet.Cells(x, 0).Value.NumericValue > 3.0 AndAlso worksheet.Cells(x, 0).Value.NumericValue < 14.0

			' Fill cells with data.
			For i As Integer = 0 To 14
				worksheet.Cells(i, 0).Value = i + 1
				worksheet.Cells(0, i).Value = i + 1
			Next i

			' Delete all rows that meet the specified condition.
			'worksheet.Rows.Remove(rowRemovalCondition);

			' Delete rows that meet the specified condition.
			' Check from the 8th row.
			worksheet.Rows.Remove(7, rowRemovalCondition)

			' Delete rows that meet the specified condition.
			' Check rows 6 through 15.
			'worksheet.Rows.Remove(5, 14, rowRemovalCondition);
			' #End Region ' #DeleteRowsBasedOnCondition
		End Sub

		Private Shared Sub DeleteColumnssBasedOnCondition(ByVal workbook As IWorkbook)
			' #Region "#DeleteColumnsBasedOnCondition"
			' Load a document from a file.
			workbook.LoadDocument("Documents\Document.xlsx")

			' Access a worksheet.
			Dim worksheet As Worksheet = workbook.Worksheets(0)

			' Specify the condition to remove worksheet columns.
			' If a value in the first row is greater than 3
			' and less than 14, remove the corresponding column.
			Dim columnRemovalCondition As Func(Of Integer, Boolean) = Function(x) worksheet.Cells(0, x).Value.NumericValue > 3.0 AndAlso worksheet.Cells(0, x).Value.NumericValue < 14.0

			' Fill cells with data.
			For i As Integer = 0 To 14
				worksheet.Cells(i, 0).Value = i + 1
				worksheet.Cells(0, i).Value = i + 1
			Next i

			' Delete all columns that meet the specified condition.
			'worksheet.Columns.Remove(columnRemovalCondition);

			' Delete columns that meet the specified condition.
			' Check from column "H".
			worksheet.Columns.Remove(7, columnRemovalCondition)

			' Delete columns that meet the specified condition.
			' Check columns "F" through "O".
			'worksheet.Columns.Remove(5, 14, columnRemovalCondition);

			' #End Region ' #DeleteColumnsBasedOnCondition
		End Sub
	End Class
End Namespace
