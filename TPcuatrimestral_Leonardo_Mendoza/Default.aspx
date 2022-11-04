<%@ Page Title="" Language="C#" MasterPageFile="~/SiteMaster.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="TPcuatrimestral_Leonardo_Mendoza.Default" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1> Login ...   </h1>
    <hr /> 
    <div class="mb-3">
  <label for="exampleFormControlInput1" class="form-label">Usuario</label>
  <input type="email" class="form-control" id="inputUsuario" placeholder="name@example.com">
</div>
    <div class="mb-3">
  <label for="exampleFormControlInput1" class="form-label">Contraseña</label>
  <input type="email" class="form-control" id="inputContraseña" placeholder="name@example.com">
</div>
    <button type="buttonIngresar" class="btn btn-dark">Ingresar</button>

</asp:Content>
