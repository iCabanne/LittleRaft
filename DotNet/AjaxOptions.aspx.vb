
Partial Class DotNet_AjaxOptions
    Inherits System.Web.UI.Page
    Protected Sub ddlAjax_SelectedIndexChanged(sender As Object, e As System.EventArgs) Handles ddlAjax.SelectedIndexChanged
        GetDescription()
    End Sub
    Public Sub GetDescription()
        Dim l As New LiteralControl
        If ddlAjax.SelectedValue = 1 Then
            l.Text = _
                "ScriptManager<br/>" & _
                "UpdatePanel<br/>" & _
                "ContentTemplate<br/>&nbsp;&nbsp;&nbsp;" & _
                "DropDownList AutoPostBack='true'<br/>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;" & _
                "ListItem<br/>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;" & _
                "ListItem<br/>&nbsp;&nbsp;&nbsp;" & _
                "PlaceHolder"
        ElseIf ddlAjax.SelectedValue = 2 Then
            l.Text = _
                "ddlAjax_SelectedIndexChanged<br/>&nbsp;&nbsp;&nbsp;" & _
                "Create New LiteralControl<br/>&nbsp;&nbsp;&nbsp;" & _
                "Assign LiteralControl.Text<br/>&nbsp;&nbsp;&nbsp;" & _
                "Clear PlaceHolder<br/>&nbsp;&nbsp;&nbsp;" & _
                "Add LiteralControl to PlaceHolder"
        End If
        phAsp.Controls.Clear()
        phAsp.Controls.Add(l)
    End Sub
End Class
