<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="DataTableSample.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml" lang="nb">
<head runat="server">
    <meta charset="utf-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <title>Hus Oppslag</title>
    <meta name="description" content="Find and search for houses and house owners">
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
    <a class="cta" href="About.aspx">About</a>
    <p class="menu cta">Menu</p>
</header>

<div id="mobile__menu" class="overlay">
    <a class="close">&times;</a>
    <div class="overlay__content">
        <a href="Default.aspx">Home</a>
        <a href="About.aspx">About</a>
    </div>
</div>

<body>
<form id="form1" runat="server">
    <div class="content">
        <div class="container">
            Antall boliger i databasen:
            <asp:Label ID="LabelNumBoliger" runat="server" Text="LabelNumBoliger"></asp:Label>
            <br/>
            <br/>
            Søk med telefonnummer
            <asp:TextBox ID="TextBoxSearchByPhone" runat="server"></asp:TextBox>
            <asp:Button ID="ButtonSearchByPhone" runat="server" Text="Søk"/>
            <br/>
            Viser alle boliger
            <asp:Button ID="ButtonShowAllBoliger" runat="server" Text="Vis alle Boliger"/>
            <br/>
            <br/>
            <br/>
            <asp:GridView ID="GridViewBoligEiere" runat="server"></asp:GridView>
            <!--SEARCH BY BUILD YEAR | BETWEEN BUILD YEARS x=>y | SEARCH BY NAME | SEARCH BY PHONE NUMBER | SEARCH BY POSTNR |   -->
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