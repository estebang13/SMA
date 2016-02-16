<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Vista/PaginaMaestra.Master" CodeBehind="Plantas.aspx.vb" Inherits="SistemaControlActivos.Plantas1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1 class="page-header">Plantas</h1>
    <input type="button" class="btn btn-primary" data-toggle="modal" data-target="#ModalModificar" data-whatever="ingresar" value="INGRESAR" />
    <br/><br/>
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
    <div class="modal fade" id="ModalModificar" tabindex="-1" role="dialog" aria-labelledby="exampleModalLabel">
        <div class="modal-dialog" role="document">
            <div class="modal-content">
                <div class="modal-header">
                    <button type="button" class="close" data-dismiss="modal" aria-label="Close"><span aria-hidden="true">&times;</span></button>
                    <h4 class="modal-title-modificar" id="ModalLabelModificar">New message</h4>
                </div>
                <div class="modal-body">
                    <div class="form-group">
                        <input type="hidden" class="form-control" id="idPlanta" name="idPlanta" />
                    </div>
                    <div class="form-group">
                        <label for="exampleInputEmail1">Nombre Planta</label>
                        <input type="text" class="form-control" id="nombrePlanta" name="nombrePlanta" />
                    </div>
                    <div class="form-group">
                        <label for="exampleInputEmail1">Telefono Planta</label>
                        <input type="text" class="form-control" id="telefonoPlanta" name="telefonoPlanta" />
                    </div>
                </div>
                <div class="modal-footer">
                    <button type="button" class="btn btn-default" data-dismiss="modal">Cancelar</button>
                    <input id="insertarModal" name="insertarModal" type="button" onserverclick="insertarPlanta" runat="server" class="btn btn-primary" value="Insertar" />
                    <input id="modificarModal" name="modificarModal" type="button" onserverclick="modificarPlanta" runat="server" class="btn btn-primary" value="Modificar" />
                </div>
            </div>
        </div>
    </div>
    <div class="modal fade" id="ModalEliminar" tabindex="-1" role="dialog" aria-labelledby="exampleModalLabel">
        <div class="modal-dialog" role="document">
            <div class="modal-content">
                <div class="modal-header">
                    <button type="button" class="close" data-dismiss="modal" aria-label="Close"><span aria-hidden="true">&times;</span></button>
                    <h4 class="modal-title-eliminar" id="ModalLabelEliminar">Eliminar</h4>
                </div>
                <div class="modal-body">
                    <div class="form-group">
                        <input type="hidden" class="form-control" id="idPlantaEliminar" name="idPlantaEliminar" />
                    </div>
                    <div class="form-group">
                        <h3><a id="infoElim"></a></h3>
                    </div>
                </div>
                <div class="modal-footer">
                    <button type="button" class="btn btn-default" data-dismiss="modal">Cancelar</button>
                    <input id="Button2" name="eliminarPlanta" type="button" onserverclick="eliminarPlanta" runat="server" class="btn btn-danger" value="Eliminar" />
                </div>
            </div>
        </div>
    </div>
</asp:Content>