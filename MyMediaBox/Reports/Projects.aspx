<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Projects.aspx.cs" Inherits="MyMediaBox.Reports.Projects" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
<asp:Table ID="tabProjects" runat="server">
    <asp:TableHeaderRow>
        <asp:TableHeaderCell>Project ID</asp:TableHeaderCell>
        <asp:TableHeaderCell>Project Number</asp:TableHeaderCell>
        <asp:TableHeaderCell>Submission Type</asp:TableHeaderCell>
        <asp:TableHeaderCell>Submission ID</asp:TableHeaderCell>
        <asp:TableHeaderCell>Submission Number</asp:TableHeaderCell>
    </asp:TableHeaderRow>
</asp:Table>
</body>
</html>
