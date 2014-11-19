<%@ Page Title="" Language="C#" MasterPageFile="~/Main.master" AutoEventWireup="true" CodeFile="LoginPage.aspx.cs" Inherits="ContentPage" %>

<asp:Content ID="Content1" ContentPlaceHolderID="StyleSection" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentSection" Runat="Server">
    <div class="jumbotron">
        <h1>Site Login</h1>
        <form id="form1" runat="server">
        <label for="username">Username:</label>
            <asp:TextBox ID="txtID" runat="server" Width="180px"></asp:TextBox>
&nbsp;<br />
        <br />
        <label for="password">Password:</label>
            <asp:TextBox ID="txtPassword" runat="server" TextMode="Password" Width="180px"></asp:TextBox>
            <br />
&nbsp;<div id="lower">
    
    &nbsp;<asp:Button ID="BtnLogin" runat="server" OnClick="BtnLogin_Click" Text="Login" CssClass ="btn-default" />
                <br />
                <asp:Label ID="lblResult" runat="server"></asp:Label>
</div>
            <!--/ lower-->
        </form>
      </div>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ScriptSection" Runat="Server"/>

