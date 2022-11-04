<%@ Page Title="" Language="C#" MasterPageFile="~/SiteMaster.Master" AutoEventWireup="true" CodeBehind="Depositos.aspx.cs" Inherits="TPcuatrimestral_Leonardo_Mendoza.Depositos" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
   
    <h1>  Depositos:  </h1>
    <hr />
    
    
    <div>  
     <asp:GridView runat="server" ID="dgvDepositos" DataKeyNames="IdDeposito"  CssClass="table-striped alert-warning table" AutoGenerateColumns ="False">
      <columns>
         <asp:BoundField HeaderText="ID DEPOSITO" DataField = "IDDEPOSITO" />
          <asp:BoundField HeaderText="Nombre" DataField = "Nombre" />
           <asp:BoundField HeaderText="Dirección" DataField = "Direccion" />
         <asp:BoundField HeaderText="Telefono" DataField = "Telefono" />
           <asp:BoundField HeaderText="Codigo Postal" DataField = "CP" />
    
         <asp:CommandField ShowSelectButton="true" SelectText="Modificar" HeaderText="Acción"/>
    </columns> 

 </asp:GridView>
         </div>
</asp:Content>
