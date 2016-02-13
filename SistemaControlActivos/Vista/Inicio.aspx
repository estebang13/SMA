<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Vista/PaginaMaestra.Master" CodeBehind="Inicio.aspx.vb" Inherits="SistemaControlActivos.Inicio" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="CSS/fullcalendar.css" rel="stylesheet" />
    <link href="CSS/fullcalendar.print.css" rel="stylesheet" media="print" />
    <script src="JS/moment.min.js"></script>
    <script src="JS/fullcalendar.min.js"></script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div id='calendar'></div>
    <script src="JS/calendar.js"></script>
    <link href="CSS/style.css" rel="stylesheet" />
</asp:Content>
