<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Vista/PaginaMaestra.Master" CodeBehind="Plantas.aspx.vb" Inherits="SistemaControlActivos.Plantas1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <script src="JS/jquery-2.1.4.min.js"></script>
    <script src="JS/bootstrap.min.js"></script>
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