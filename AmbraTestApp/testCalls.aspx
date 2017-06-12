<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="testCalls.aspx.cs" Inherits="AmbraTestApp.testCalls" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Button ID="btnCreateSession" runat="server" 
            onclick="btnCreateSession_Click" Text="Create Session" />
&nbsp;<asp:Button ID="btnGetStudyList" runat="server" onclick="btnGetStudyList_Click" 
            Text="Get Study List" />
&nbsp;<asp:Button ID="btnGeStudy" runat="server" onclick="btnGeStudy_Click" 
            Text="Get Study" />
    
        &nbsp;<asp:Button ID="btnGetWebhook" runat="server" 
            onclick="btnGetWebhook_Click" Text="Get WebHook List" />
        &nbsp;<asp:Button ID="btnCreateWebHook" runat="server" 
            onclick="btnCreateWebHook_Click" Text="Create WebHook" />
        &nbsp;<asp:Button ID="btnTestDateTime" runat="server" 
            onclick="btnTestDateTime_Click" Text="Test Date Time" />
        <br />
    
    </div>
    </form>
</body>
</html>
