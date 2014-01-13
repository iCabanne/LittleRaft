<%@ Page Language="VB" AutoEventWireup="false" CodeFile="AjaxOptions.aspx.vb" Inherits="DotNet_AjaxOptions" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Little Raft</title>
    <style type="text/css">
        body, input, p { font-family: Arial, Sans-Serif; font-size: 10pt; }
        .content { position: relative; margin: 10px 10%; width: auto; background-color: transparent; }
        .sample { width: 300px; float: left; overflow: hidden; border: solid 1px #999999; padding: 10px; margin: 10px; -moz-border-radius: 10px; -webkit-border-radius: 10px; -khtml-border-radius: 10px; border-radius: 10px; }
        p.code { font-family: "Lucida Console" , Monaco, monospace; font-size: 10pt; line-height: 1.2em; }
        .process { clear: both; }
        .process p { font-weight: bold; }
        td { text-align: center; }
        td.box { border: solid 1px #999999; max-width: 200px; padding: 0 5px 10px 5px; }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div class="content">
        <p>
            <a href="../default.htm">Back to LittleRaft</a></p>
        <p>The preferable method for making AJAX calls can differ depending on the application.
            This page demonstrates two options within asp.net. For the purpose of this test
            page it doesn't matter when and why each option would be chosen. The examples are
            overly simple because the point of the page is to test and maintain samples, not
            to create a complex implementation.</p>
        <p>1. A fully asp.net solution uses a ScriptManager, an UpdatePanel and .net controls.</p>
        <p>2. This combination solution uses HTML controls and jQuery on the client, and Web
            Services on the server. </p>
        <div class="sample">
            <asp:ScriptManager ID="ScriptManager1" runat="server">
            </asp:ScriptManager>
            <p>1. ScriptManager</p>
            <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                <ContentTemplate>
                    <asp:DropDownList ID="ddlAjax" runat="server" AutoPostBack="true">
                        <asp:ListItem Value="0">-- Make a Selection --</asp:ListItem>
                        <asp:ListItem Value="1">Show Pseudo HTML</asp:ListItem>
                        <asp:ListItem Value="2">Show Pseudo VB</asp:ListItem>
                    </asp:DropDownList>
                    <p class="code">
                        <asp:PlaceHolder ID="phAsp" runat="server"></asp:PlaceHolder>
                    </p>
                </ContentTemplate>
            </asp:UpdatePanel>
        </div>
        <div class="sample">
            <p>2. jQuery</p>
            <select id="ajaxtest">
                <option value="0">-- Make a Selection --</option>
                <option value="1">Show Pseudo HTML</option>
                <option value="2">Show Pseudo jQuery</option>
                <option value="3">Show Pseudo VB</option>
            </select>
            <p id="resultmessage" class="code"></p>
        </div>
        <div class="process">
            <p>&nbsp;<br />
                Process Flow</p>
            <table>
                <tr>
                    <td class="box">
                        <p>Listener</p>
                        When the listener detects a change in the selection, it kicks off the... </td>
                </tr>
                <tr>
                    <td>
                        <img src="downarroworange.png" /></td>
                </tr>
                <tr>
                    <td class="box">
                        <p>Process</p>
                        The process examines the selection and updates the... </td>
                </tr>
                <tr>
                    <td>
                        <img src="downarroworange.png" /></td>
                </tr>
                <tr>
                    <td class="box">
                        <p>HTML</p>
                    </td>
                </tr>
            </table>
        </div>
    </div>
    </form>
    <script type="text/javascript" src="http://code.jquery.com/jquery-1.10.0.min.js"></script>
    <script type="text/javascript">
        $(document).ready(function () {
            // use of body and .on is critical for function to stay attached after ajax call.
            $('body').on('change', '#ajaxtest', function () {
                $.ajax({
                    type: "POST",
                    url: "../Services/AjaxOptions.asmx/GetPseudoCode",
                    data: "{'selection':" + $(this).val() + "}",
                    contentType: "application/json; charset=utf-8",
                    dataType: "json",
                    success: function (msg) {
                        $("#resultmessage").html(msg.d);
                    }
                });
            });
        });
    </script>
</body>
</html>
