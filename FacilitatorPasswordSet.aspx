<%@ Page Title="" Language="C#" MasterPageFile="~/Main.master" AutoEventWireup="true" CodeFile="FacilitatorPasswordSet.aspx.cs" Inherits="FacilitatorPasswordSet" %>

<asp:Content ID="Content1" ContentPlaceHolderID="StyleSection" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentSection" Runat="Server">
    <form id="form1" runat="server">
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <p>
            <asp:Label ID="lblFacilitator" runat="server"></asp:Label>
        </p>
        <p>
            <asp:Label ID="Label1" runat="server" Text="Enter Password"></asp:Label>
&nbsp;</p>
        <p>
            <asp:TextBox ID="txtPassword" runat="server"></asp:TextBox>
        </p>
        <p>
            <asp:Label ID="Label2" runat="server" Text="Re-Enter Password"></asp:Label>
        </p>
        <p>
            <asp:TextBox ID="txtReEnter" runat="server"></asp:TextBox>
        </p>
        <p>
            <asp:Button ID="btnSet" runat="server" Text="Confirm" OnClick="btnSet_Click" />
        </p>
    </form>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ScriptSection" Runat="Server">
</asp:Content>

