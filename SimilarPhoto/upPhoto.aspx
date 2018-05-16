<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="upPhoto.aspx.cs" Inherits="SimilarPhoto.upPhoto" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title></title>

</head>
<body>
    <form id="form1" runat="server" method="post" enctype="multipart/form-data">
        <div>
            <input name="f" type="file" id="filepath" /><br />
            <input name="s" type="submit" id="btn_submit"/>
        </div>
    </form>
</body>
</html>