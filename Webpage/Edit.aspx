<%@ Page Language="C#" CodeBehind="Edit.aspx.cs" Inherits="DataTableSample.Edit" ValidateRequest="false" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" lang="nb">
<head runat="server">
    <meta charset="utf-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <title>CMS</title>
    <meta name="description" content="CMS">
    <meta name="viewport" content="width=device-width, initial-scale=1">
    <link rel="icon" type="image/x-icon" href="images/logo.svg">
    <link rel="stylesheet" href="css/style.css">
    <link href="https://fonts.googleapis.com/css?family=Montserrat:500&display=swap" rel="stylesheet">
    <link rel="preconnect" href="https://fonts.googleapis.com"><link rel="preconnect" href="https://fonts.gstatic.com" crossorigin>
    <link href="https://fonts.googleapis.com/css2?family=Roboto:ital,wght@0,100;0,300;0,400;0,700;1,300&display=swap" rel="stylesheet">
</head>
<header>
    <a class="logo" href="Default.aspx">
        <img src="images/logo.svg" alt="logo">
    </a>
    <nav>
        <ul class="nav__links">
            <li id="MoveToTop">
                <a href="Default.aspx">Home</a>
            </li>
        </ul>
    </nav>
    <a class="cta" href="Edit.aspx">Edit</a>
    <p class="menu cta">Menu</p>
</header>

<div id="mobile__menu" class="overlay">
    <a class="close">&times;</a>
    <div class="overlay__content">
        <a href="Default.aspx">Home</a>
        <a href="Edit.aspx">Edit</a>
    </div>
</div>

<body>
<form id="form1" runat="server">
    <div class="content">
        <div class="container">
            <p>USE HTML TAGS IN TEXTBOX TO FORMAT TEXT</p>
            <br/>
            <p>
                <asp:Label ID="LabelParagraph1" runat="server" Text="Label"></asp:Label>
            </p>
            <br/>
            <asp:TextBox ID="TextParagraph1Edit" runat="server" TextMode="MultiLine" Rows="15" Columns="132" class="textbox"></asp:TextBox>
            <br/>
            <asp:Button ID="ButtonSave" OnClick="ButtonSave_OnClick" runat="server" Text="Publish" class="button"/>
            <br/>
            <br/>
            <h4>Image Upload:</h4>
            <h5>Max file size: 4MB</h5>
            <asp:FileUpload ID="FileUpload1" runat="server" class="button"/>
            <br/>
            <asp:Button ID="ButtonUpload" runat="server" OnClick="ButtonUpload_Click" Text="Upload" class="button"/>
        </div>
    </div>
    <footer>
        Made by Robin Begby @
        <a class="link" href="mailto:robinbeg@viken.no">Robinbeg@viken.no</a>
        <a class="link centerfooter" href="#MoveToTop">Move to top</a>
    </footer>
</form>
<script type="text/javascript" src="JS/mobile.js"></script>
</body>
</html>