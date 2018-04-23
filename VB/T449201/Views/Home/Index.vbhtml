


<script type="text/javascript">
    function OnClick(s, e) {
        Spreadsheet.PerformCallback();
    }

</script>

@Html.DevExpress().Button(Function(settings)
settings.Name = "Button"
settings.UseSubmitBehavior = False
settings.RenderMode = ButtonRenderMode.Link
settings.Text = "Reload the document"
settings.Styles.Style.Font.Size = System.Web.UI.WebControls.FontUnit.Larger
settings.ClientSideEvents.Click = "OnClick"

End Function).GetHtml()
<br />
<br />
Modify the document and click the "Reload the document"link
<br /><br />
@Using (Html.BeginForm())

@Html.Action("SpreadsheetPartial")
    End Using
