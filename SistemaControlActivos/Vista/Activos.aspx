<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Vista/PaginaMaestra.Master" CodeBehind="Activos.aspx.vb" Inherits="SistemaControlActivos.Activos" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container">
      <div> Mae Bryan, esto es super basico, esto sirve con bootstrap y lo de arriba es jquery para obtener los datos de los inputs del modal, abra el console en inspeccionar elementos para que vea como salen los datos</div>
      <a class="btn modal-toggle" href="#modal-dialog" data-toggle="modal" > Modal Submit</a>
  </div>
  <div id="modal-dialog" class="modal">
  	<div class="modal-dialog">
        <div class="modal-content">
          <div class="modal-header">
              <a href="#" data-dismiss="modal" aria-hidden="true" class="close">X</a>
               <h3>Mofication</h3>
          </div>
          <div class="modal-body">
            <div>Your name:</div><input name="name" id="name"/>
            <div>Your email:</div><input id="email"/>
            <div>Your phone:</div><input id="phone"/>
          </div>
          <div class="modal-footer">
            <a href="#" id="btnYes" class="btn confirm">Yes</a>
            <a href="#" data-dismiss="modal" aria-hidden="true" class="btn secondary">No</a>
          </div>
        </div>
      </div>
  </div>
</asp:Content>
