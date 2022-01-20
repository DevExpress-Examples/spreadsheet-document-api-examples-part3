Namespace Spreadsheet_Document_Api_Part_3

#Region "SpreadsheetExampleEvaluatorByTimer"
    Public Class SpreadsheetExampleEvaluatorByTimer
        Inherits ExampleEvaluatorByTimer

        Public Sub New()
            MyBase.New()
        End Sub

        Protected Overrides Function GetExampleCodeEvaluator(ByVal language As ExampleLanguage) As ExampleCodeEvaluator
            If language = ExampleLanguage.VB Then Return New SpreadsheetVbExampleCodeEvaluator()
            Return New SpreadsheetCSExampleCodeEvaluator()
        End Function
    End Class
#End Region
End Namespace
