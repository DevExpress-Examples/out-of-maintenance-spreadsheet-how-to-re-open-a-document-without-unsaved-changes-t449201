Imports DevExpress.Web.Mvc
Imports DevExpress.Web.Office
Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Web
Imports System.Web.Mvc

Namespace T449201.Controllers
    Public Class HomeController
        Inherits Controller

        ' GET: Home
        Public Function Index() As ActionResult
            Return View()
        End Function

        Public Function SpreadsheetPartial() As ActionResult
            Return PartialView("_SpreadsheetPartial")
        End Function
        Public Function SpreadsheetCustomPartial() As ActionResult
            Dim documentID As String = SpreadsheetExtension.GetDocumentId("Spreadsheet")
            SpreadsheetExtension.CloseDocument("Spreadsheet")
            Return SpreadsheetExtension.Open("Spreadsheet", documentID)

        End Function
    End Class
End Namespace