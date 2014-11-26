<%@ Page Title="" Language="C#" MasterPageFile="~/Main.master" AutoEventWireup="true" CodeFile="Orientation.aspx.cs" Inherits="Orientation" %>

<asp:Content ID="Content1" ContentPlaceHolderID="StyleSection" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentSection" Runat="Server">
    <form id="form1" runat="server">
        <div class="container">
            <div class="jumbotron">
            <br /><br />
            <asp:Label ID="lblName" runat="server" Text="Provide orientation for: "></asp:Label>
&nbsp;<asp:DropDownList ID="DropDownListNames" CssClass="btn btn-default dropdown-toggle" runat="server" DataSourceID="SqlDataSource1" DataTextField="Expr1" DataValueField="Expr1" OnSelectedIndexChanged="DropDownListNames_SelectedIndexChanged" AutoPostBack="True">
            </asp:DropDownList>
            <br /> <br />
                  <asp:Button CssClass ="btn btn-lg btn-primary btn-block" ID="btnSubmit" runat="server" OnClick="btnSubmit_Click" Text="Submit" />
                   <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:DefaultConnection %>" SelectCommand="SELECT LTRIM(RTRIM(FName)) + ' ' + LTRIM(RTRIM(LName)) AS Expr1 FROM Emp WHERE (Ocheck = 'N') ORDER BY FName"></asp:SqlDataSource>
            <br /><br />
               <asp:Label ID="AlertWindow" Visible="false" CssClass="alert alert-success" runat="server" Width ="30%"></asp:Label>
              
            </div><!--jumbotroon-->
            </div><!--container-->
    </form>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ScriptSection" Runat="Server">
</asp:Content>

