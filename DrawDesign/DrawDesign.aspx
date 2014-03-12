<%@ Page Language="VB" AutoEventWireup="false" CodeFile="DrawDesign.aspx.vb" Inherits="DrawDesign_DrawDesign" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        table { border-collapse: collapse; }
        td { border: solid 1px pink; width:40px; }
        td.bb { border-bottom: solid 1px #333; }
        td.br { border-right: solid 1px #333; }
        td.r1 {background-color:Gray}
        td.r2 {background-color:Aqua}
        td.r3 {background-color:Fuchsia;}
        td.r4 {background-color:Teal;}
        td.r5 {background-color:Yellow;}
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:PlaceHolder ID="phDraw" runat="server"></asp:PlaceHolder>
    </div>
    </form>
</body>
</html>
