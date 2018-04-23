@Imports DevExpress.Web.Office

@Html.DevExpress().Spreadsheet(Function(settings)
settings.Name = "Spreadsheet"
settings.CallbackRouteValues = New With { _
	Key .Controller = "Home", _
	Key .Action = "SpreadsheetPartial" _
}
settings.CustomActionRouteValues = New With { _
	Key .Controller = "Home", _
	Key .Action = "SpreadsheetCustomPartial" _
}
settings.Width = 700
settings.Height = 800
settings.[ReadOnly] = False
settings.RibbonMode = SpreadsheetRibbonMode.Ribbon
settings.PreRender = Function(s, e)
Dim spreadsheert As MVCxSpreadsheet = DirectCast(s, MVCxSpreadsheet)
spreadsheert.CreateDefaultRibbonTabs(True)
spreadsheert.RibbonTabs(0).Visible = False 'Hide the file tab


End Function

End Function).Open(Server.MapPath("~/App_Data/MonthlyBudget.xlsx")).GetHtml()
