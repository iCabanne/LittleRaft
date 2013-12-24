<%@ Page Language="VB" AutoEventWireup="false" CodeFile="EditInCode.aspx.vb" Inherits="EditInCode" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Little Raft</title>
    <style type="text/css">
        body, table, input, p { font-family: Arial, Sans-Serif; font-size: 10pt; }
        .mytable { border-collapse: collapse; border: none; }
        .mytable th { border-bottom: solid 2px green; }
        .mytable td { border-bottom: solid 1px green; }
        .mytable td.collapsed { background-color: #cccccc; text-align: center; }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <asp:ScriptManager ID="ScriptManager1" runat="server">
    </asp:ScriptManager>
    <asp:UpdatePanel ID="UpdatePanel1" runat="server">
        <ContentTemplate>
            <div style="position: relative; margin: 10px 10%; width: auto; background-color: transparent;">
                <p>
                    <a href="../default.htm">Back to LittleRaft</a></p>
                <p>This is a sample of switching the modes of rows within a table. The table is entirely
                    created in code behind, and is placed in a PlaceHolder control on the page. Coding
                    the table makes it possible to create a grid type control that has limitless functionality
                    possibilities.</p>
                <p>The whole thing sits in an AJAX UpdatePanel so that only the table refreshes.</p>
                <p>Although this sample only shows changes in text and buttons, any number of controls,
                    both standard and custom, can appear in the table, with all sorts of functionality.
                    Individual rows and cells and controls, as well as specifically chosen groups, can
                    be extended with custom attributes and easily linked with javascript on the client
                    side. This sample is limited to the basic structure of switching modes.</p>
                <p>In this sample, only the selected row is placed into a different mode. However, it
                    would be relatively easy to extend the functionality to a number of rows, or to
                    use checkboxes, combined with selection buttons placed outside the table, to affect
                    mode changes on multiple rows at once.</p>
                <p>Mode 1 = Selected row is in mode 1 and can switch to default or other modes. All
                    other rows in default mode, with mode buttons enabled.<br />
                    Mode 2 = Selected row is in mode 2 and can only switch to default. All other rows
                    in default mode, with mode buttons enabled.<br />
                    Mode 3 = Selected row is in mode 3 and can only switch to default. All other rows
                    in default mode, with mode buttons disabled.<br />
                    Mode 4 = Like mode 2, except that the number of columns is reduced, noted with the
                    change of background color.</p>
                <asp:PlaceHolder ID="PlaceHolder1" runat="server"></asp:PlaceHolder>
            </div>
        </ContentTemplate>
    </asp:UpdatePanel>
    </form>
</body>
</html>
