<%@ Page Title="" Language="C#" MasterPageFile="~/Main.master" AutoEventWireup="true" CodeFile="LoginPage.aspx.cs" Inherits="ContentPage" %>

<asp:Content ID="Content1" ContentPlaceHolderID="StyleSection" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentSection" Runat="Server">
    <br />
       <div class="container">
           
      <form class="form-signin" role="form" runat="server">
        <br /><br />
          <div class="jumbotron">
           <h2 class="form-signin-heading">&nbsp;</h2>
          <h2 class="form-signin-heading">Site Login</h2>
        <label for="txtID">UserID: </label>
        <asp:TextBox ID="txtID" runat="server" CssClass="form-control" Width="30%" OnTextChanged="txtID_TextChanged"></asp:TextBox>
              <br />
        <label for="txtPassword">Password: </label>
        <asp:TextBox ID="txtPassword" runat="server" TextMode="Password" CssClass="form-control" Width="30%"></asp:TextBox>
             
             <%--<div class="checkbox">
             <label>
            <input type="checkbox" value="remember-me"> Remember me
          </label>
        &nbsp;</div>--%>
             <br />
       <asp:Button ID="btnLogin" runat="server" OnClick="btnLogin_Click" Text="Sign In" CssClass ="btn btn-lg btn-primary btn-block" Width="30%"/>
     <br /><br />
             
               <asp:Label ID="AlertWindow" Visible="false" CssClass="alert alert-success" runat="server" Width ="30%"></asp:Label>
             
               </div>
               </form>
           
    </div> <!-- /container -->
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ScriptSection" Runat="Server"/>

