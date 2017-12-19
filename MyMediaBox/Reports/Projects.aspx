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
<br />
    <table id="mediaTable">
        <tbody>
            <tr>
                <th>Media ID</th>
                <th>Short Description</th>
                <th>Date Created</th>
                <th>Title</th>
                <th>File Size</th>
            </tr>
        </tbody>
    </table>
</body>

</html>
    <script src="/scripts/jquery-1.10.2.min.js"></script>
    <script type="text/javascript">
        $(function () {
            getMediaList();
        });
        
    function getMediaList(){
        var url = 'https://test40-pa-dev01.uat.mymediabox.com/inbox/get-media-list-for-folder.xml?g4_ignoretransform=yes';
        $.ajax({
            url: url,
            type: 'GET',
            async: true,
            dataType: 'xml',
        })
        .success(function (data) {
            displayMediaList(data);
        });
    }

    function displayMediaList(data)
    {
        var mediaList = $(data).find('get-media-list-for-folder').each(function () { addRow($(this));});
    }

    function addRow(node)
    {
        $("#mediaTable > tbody:last-child").append(
            '<tr><td>' + $(node).find('MediaID').text() + '</td>'
            + '<td>' + $(node).find('ShortDescription').text() + '</td>'
            + '<td>' + $(node).find('DateCreated').text() + '</td>'
            + '<td>' + $(node).find('Title').text() + '</td>'
            + '<td>' + $(node).find('FileSize').text() + '</td></tr>'
            );
    }
</script>
