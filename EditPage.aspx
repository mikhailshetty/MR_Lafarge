<%@ Page Title="" Language="C#" MasterPageFile="~/Main.master" AutoEventWireup="true" CodeFile="EditPage.aspx.cs" Inherits="EditPage" %>

<asp:Content ID="Content1" ContentPlaceHolderID="StyleSection" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentSection" Runat="Server">
    <p>
        <br />
    </p>
    <p>
    </p>
    Lafarge Employee Verification
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ScriptSection" Runat="Server">
    <form id="form1" runat="server">
        <label for="username">
        Username:</label><asp:TextBox ID="txtID" runat="server" Width="180px"></asp:TextBox>
        <br />
        <label for="password">
        Password:</label><asp:TextBox ID="txtPassword" runat="server" TextMode="Password" Width="180px"></asp:TextBox>
        <br />
        <br />
        <asp:Button ID="BtnSubmit" runat="server" OnClick="BtnSubmit_Click" Text="Submit" CssClass ="btn-default" />
        <br />
                <asp:Label ID="lblResult" runat="server"></asp:Label>
    </form>
</asp:Content>

