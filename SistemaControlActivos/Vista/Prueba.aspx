﻿<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Vista/PaginaMaestra.Master" CodeBehind="Prueba.aspx.vb" Inherits="SistemaControlActivos.Prueba" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1 class="page-header">Plantas</h1>
    <button id="boton1" class="btn btn-primary" >Agregar</button><br/><br/>
    <div class="panel panel-primary">
        <div class="panel-heading">Detalles</div>
        <table id="table1" class="table table-hover" runat="server">
            <thead>
                <tr>
                    <th>Código</th>
                    <th>Nombre</th>
                    <th>Telefono</th>
                </tr>
            </thead>
        </table>
    </div>
</asp:Content>
