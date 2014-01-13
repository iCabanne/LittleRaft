Imports System.Web
Imports System.Web.Services
Imports System.Web.Services.Protocols

' To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line.
<System.Web.Script.Services.ScriptService()> _
<WebService(Namespace:="http://www.littleraft.com/")> _
<WebServiceBinding(ConformsTo:=WsiProfiles.BasicProfile1_1)> _
<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Public Class AjaxOptions
    Inherits System.Web.Services.WebService
    <WebMethod()> _
    Public Function GetPseudoCode(ByVal selection As String) As String
        Dim nSelection As Integer = CInt(selection)
        Dim sReturn As String = ""
        If nSelection = 1 Then
            sReturn = _
                "select id='ajaxtest'<br/>&nbsp;&nbsp;&nbsp;" & _
                "option<br/>&nbsp;&nbsp;&nbsp;" & _
                "option<br/>" & _
                "p id='resultmessage'"
        ElseIf nSelection = 2 Then
            sReturn = _
                "$(document).ready...<br/>&nbsp;&nbsp;&nbsp;" & _
                ".on('change','#ajaxtest'...<br/>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;" & _
                "$.ajax({...<br/>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;" & _
                "success: [write msg]"
        ElseIf nSelection = 3 Then
            sReturn = _
                "Function as string<br/>&nbsp;&nbsp;&nbsp;" & _
                "Create string based on selection<br/>&nbsp;&nbsp;&nbsp;" & _
                "Return string"
        End If
        Return sReturn
    End Function
End Class