﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Main.master" AutoEventWireup="true" CodeFile="EditOptions.aspx.cs" Inherits="EditOptions" %>

<asp:Content ID="Content1" ContentPlaceHolderID="StyleSection" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentSection" Runat="Server">
    <form id="form1" runat="server">
        <div class="container">           
              <div class="jumbotron container">  
                  <br /><br />   
            <asp:GridView ID="GridView1" runat="server" AllowSorting="True" AutoGenerateColumns="False" AutoGenerateDeleteButton="True" AutoGenerateEditButton="True" DataKeyNames="ID" DataSourceID="SqlDataSource1" OnSelectedIndexChanged="GridView1_SelectedIndexChanged" ShowFooter="True" CssClass="table table-hover table-bordered">
                <Columns>
                    <asp:TemplateField HeaderText="ID" SortExpression="ID">
                        <EditItemTemplate>
                            <asp:Label ID="Label1" runat="server" Text='<%# Eval("ID") %>'></asp:Label>
                        </EditItemTemplate>
                        <FooterTemplate>
                            <asp:Button ID="btnAdd" runat="server" OnClick="btnAdd_Click" Text="Add" />
                            <asp:TextBox ID="txtID" runat="server" OnTextChanged="txtID_TextChanged" Width="74px"></asp:TextBox>
                        </FooterTemplate>
                        <ItemTemplate>
                            <asp:Label ID="Label1" runat="server" Text='<%# Bind("ID") %>'></asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="FName" SortExpression="FName">
                        <EditItemTemplate>
                            <asp:TextBox ID="TextBox1" runat="server" Text='<%# Bind("FName") %>'></asp:TextBox>
                        </EditItemTemplate>
                        <FooterTemplate>
                            <asp:TextBox ID="txtFName" runat="server" Width="68px"></asp:TextBox>
                        </FooterTemplate>
                        <ItemTemplate>
                            <asp:Label ID="Label2" runat="server" Text='<%# Bind("FName") %>'></asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="LName" SortExpression="LName">
                        <EditItemTemplate>
                            <asp:TextBox ID="TextBox2" runat="server" Text='<%# Bind("LName") %>'></asp:TextBox>
                        </EditItemTemplate>
                        <FooterTemplate>
                            <asp:TextBox ID="txtLName" runat="server" Width="68px"></asp:TextBox>
                        </FooterTemplate>
                        <ItemTemplate>
                            <asp:Label ID="Label3" runat="server" Text='<%# Bind("LName") %>'></asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="Contact" SortExpression="Contact">
                        <EditItemTemplate>
                            <asp:TextBox ID="TextBox3" runat="server" Text='<%# Bind("Contact") %>'></asp:TextBox>
                        </EditItemTemplate>
                        <FooterTemplate>
                            <asp:TextBox ID="txtContact" runat="server" Width="68px"></asp:TextBox>
                        </FooterTemplate>
                        <ItemTemplate>
                            <asp:Label ID="Label4" runat="server" Text='<%# Bind("Contact") %>'></asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="Email" SortExpression="Email">
                        <EditItemTemplate>
                            <asp:TextBox ID="TextBox4" runat="server" Text='<%# Bind("Email") %>'></asp:TextBox>
                        </EditItemTemplate>
                        <FooterTemplate>
                            <asp:TextBox ID="txtEmail" runat="server" Width="68px"></asp:TextBox>
                        </FooterTemplate>
                        <ItemTemplate>
                            <asp:Label ID="Label5" runat="server" Text='<%# Bind("Email") %>'></asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="Ocheck" SortExpression="Ocheck">
                        <EditItemTemplate>
                            <asp:TextBox ID="TextBox5" runat="server" Text='<%# Bind("Ocheck") %>'></asp:TextBox>
                        </EditItemTemplate>
                        <FooterTemplate>
                            <asp:TextBox ID="txtOCheck" runat="server" Width="68px"></asp:TextBox>
                        </FooterTemplate>
                        <ItemTemplate>
                            <asp:Label ID="Label6" runat="server" Text='<%# Bind("Ocheck") %>'></asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="Ext" SortExpression="Ext">
                        <EditItemTemplate>
                            <asp:TextBox ID="TextBox6" runat="server" Text='<%# Bind("Ext") %>'></asp:TextBox>
                        </EditItemTemplate>
                        <FooterTemplate>
                            <asp:TextBox ID="txtExt" runat="server" Width="68px"></asp:TextBox>
                        </FooterTemplate>
                        <ItemTemplate>
                            <asp:Label ID="Label7" runat="server" Text='<%# Bind("Ext") %>'></asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="Facilitator" SortExpression="Facilitator">
                        <EditItemTemplate>
                            <asp:TextBox ID="TextBox7" runat="server" Text='<%# Bind("Facilitator") %>'></asp:TextBox>
                        </EditItemTemplate>
                        <FooterTemplate>
                            <asp:TextBox ID="txtFacilitator" runat="server" Width="68px"></asp:TextBox>
                        </FooterTemplate>
                        <ItemTemplate>
                            <asp:Label ID="Label8" runat="server" Text='<%# Bind("Facilitator") %>'></asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>
                </Columns>
            </asp:GridView>
            <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:DefaultConnection %>" DeleteCommand="DELETE FROM [Emp] WHERE [ID] = @ID" InsertCommand="INSERT INTO [Emp] ([ID], [FName], [LName], [Contact], [Email], [Ocheck], [Ext], [Facilitator]) VALUES (@ID, @FName, @LName, @Contact, @Email, @Ocheck, @Ext, @Facilitator)" SelectCommand="SELECT * FROM [Emp]" UpdateCommand="UPDATE [Emp] SET [FName] = @FName, [LName] = @LName, [Contact] = @Contact, [Email] = @Email, [Ocheck] = @Ocheck, [Ext] = @Ext, [Facilitator] = @Facilitator WHERE [ID] = @ID">
                <DeleteParameters>
                    <asp:Parameter Name="ID" Type="Int32" />
                </DeleteParameters>
                <InsertParameters>
                    <asp:Parameter Name="ID" Type="Int32" />
                    <asp:Parameter Name="FName" Type="String" />
                    <asp:Parameter Name="LName" Type="String" />
                    <asp:Parameter Name="Contact" Type="Decimal" />
                    <asp:Parameter Name="Email" Type="String" />
                    <asp:Parameter Name="Ocheck" Type="String" />
                    <asp:Parameter Name="Ext" Type="String" />
                    <asp:Parameter Name="Facilitator" Type="String" />
                </InsertParameters>
                <UpdateParameters>
                    <asp:Parameter Name="FName" Type="String" />
                    <asp:Parameter Name="LName" Type="String" />
                    <asp:Parameter Name="Contact" Type="Decimal" />
                    <asp:Parameter Name="Email" Type="String" />
                    <asp:Parameter Name="Ocheck" Type="String" />
                    <asp:Parameter Name="Ext" Type="String" />
                    <asp:Parameter Name="Facilitator" Type="String" />
                    <asp:Parameter Name="ID" Type="Int32" />
                </UpdateParameters>
            </asp:SqlDataSource>
            <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:DefaultConnection %>" SelectCommand="SELECT LTRIM(RTRIM(FName)) + ' ' + LTRIM(RTRIM(LName)) AS Expr1 FROM Emp WHERE (Facilitator = 'N') ORDER BY FName"></asp:SqlDataSource>
            <asp:SqlDataSource ID="SqlDataSource3" runat="server" ConnectionString="<%$ ConnectionStrings:DefaultConnection %>" SelectCommand="SELECT LTRIM(RTRIM(Emp.FName)) + ' ' + LTRIM(RTRIM(Emp.LName)) AS Expr1 FROM Emp INNER JOIN Facilitator ON Emp.ID = Facilitator.ID WHERE (Emp.Facilitator = 'Y') ORDER BY Emp.FName"></asp:SqlDataSource>
            <asp:DropDownList ID="DropDownListNames"  CssClass="btn btn-default dropdown-toggle" runat="server" DataSourceID="SqlDataSource2" DataTextField="Expr1" DataValueField="Expr1" AutoPostBack="True">
            </asp:DropDownList>
            <asp:Button ID="btnFacilitator" runat="server" CssClass ="btn btn-sm btn-primary" OnClick="btnFacilitator_Click" Text="Add as Facilitator" />
        
            <br /><br /> <br />

            <asp:DropDownList ID="DropDownListRemoveFacilitator"  CssClass="btn btn-default dropdown-toggle" runat="server" DataSourceID="SqlDataSource3" DataTextField="Expr1" DataValueField="Expr1" AutoPostBack="True">
            </asp:DropDownList>
            <asp:Button ID="btnRemoveFacilitator" CssClass ="btn btn-sm btn-primary" runat="server" OnClick="btnRemoveFacilitator_Click" Text="Remove Facilitator" />
                     </div><!--jumbotron-->

        </div> <!--container-->
    </form>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ScriptSection" Runat="Server">
</asp:Content>
