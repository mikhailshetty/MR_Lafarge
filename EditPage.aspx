﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Main.master" AutoEventWireup="true" CodeFile="EditPage.aspx.cs" Inherits="EditPage" %>

<asp:Content ID="Content1" ContentPlaceHolderID="StyleSection" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentSection" Runat="Server">
    <br />    <div class="container">
        <div class="jumbotron">
            <br />
      <form class="form-signin" role="form" runat="server">
        <h2 class="form-signin-heading">&nbsp;</h2>
          <h2 class="form-signin-heading">Lafarge Manager Login</h2>
          <br />
        <label for="txtID">Manager ID: </label>
        <asp:TextBox ID="txtID" runat="server" CssClass="form-control" Width="30%"></asp:TextBox>
        <br />
          <label for="txtPassword">Password: </label>
        <asp:TextBox ID="txtPassword" runat="server" TextMode="Password" CssClass="form-control" Width="30%"></asp:TextBox>
       <br /><br />
          <asp:Button ID="BtnSubmit" runat="server" OnClick="BtnSubmit_Click" Text="Sign In" CssClass ="btn btn-lg btn-primary btn-block" Width="30%"/>
        <br />
               <asp:Label ID="AlertWindow" Visible="false" CssClass="alert alert-success" runat="server" Width ="30%"></asp:Label>          
      </form>
            
     </div> <!--jumbotron-->
    </div> <!-- /container -->
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ScriptSection" Runat="Server">
    
</asp:Content>

