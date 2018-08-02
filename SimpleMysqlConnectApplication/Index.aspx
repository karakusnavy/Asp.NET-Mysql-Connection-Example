<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="SimpleMysqlConnectApplication.Index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Samed Karakuş</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <h1>Simple Mysql Application Status</h1><br />
        <a runat="server" id="connectsuccess" style="display:none;color:green">Mysql Connect is Successful!</a>
        <a runat="server" id="connectfailed" style="display:none;color:red">Mysql Connect Failed! </a>
    </div>
    </form>
</body>
</html>
