<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="DataTableSample.Login" %>

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
    <a class="cta" href="Login.aspx">Edit</a>
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
            <asp:Login ID="Login1" runat="server" OnAuthenticate="Login1_Authenticate" DestinationPageUrl="~/Edit.aspx"></asp:Login>
            <asp:LoginStatus ID="LoginStatus1" runat="server" Visible="true"/>
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