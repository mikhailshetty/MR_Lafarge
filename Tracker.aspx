<%@ Page Title="" Language="C#" MasterPageFile="~/Main.master" AutoEventWireup="true" CodeFile="Tracker.aspx.cs" Inherits="Tracker"  %>

<%@ Register assembly="AjaxControlToolkit" namespace="AjaxControlToolkit" tagprefix="ajax" %>

<asp:Content ID="Content1" ContentPlaceHolderID="StyleSection" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentSection" Runat="Server">
     <form id="form1" runat="server">
        <div class="container">
         
         <br /><br />
   <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
         
            <br /><br /> 
             
              <div class="jumbotron container">       
             <div class="dropdown">
                <div class="col-md-2"></div>
                <div class="col-md-4">
                
                    <asp:DropDownList ID="DropDownListNames" CssClass="btn btn-default dropdown-toggle" runat="server" DataSourceID="SqlDataSource1" DataTextField="Expr1" DataValueField="Expr1" AutoPostBack="True" OnSelectedIndexChanged="DropDownListNames_SelectedIndexChanged">
                    </asp:DropDownList>
                </div>
                <div class="col-md-2">
                   
                    <asp:Button ID="btnSignIn" CssClass ="btn btn-sm btn-primary btn-block" runat="server" Text="Sign In" OnClick="btnSignIn_Click"/>
                </div>
            
                  <div class="col-md-2"></div>
                 </div>
                
      <br /><br /><br />
      <div>      
           <div class="col-md-2"></div>
           <div class="col-md-8">

            <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="ID" DataSourceID="SqlDataSource2" OnSelectedIndexChanged="GridView1_SelectedIndexChanged" CssClass="table table-hover table-bordered" OnRowCreated="GridView1_RowCreated">
                <Columns>
                    <asp:BoundField DataField="ID" HeaderText="ID" ReadOnly="True" SortExpression="ID" />
                    <asp:BoundField DataField="FName" HeaderText="FName" SortExpression="FName" />
                    <asp:BoundField DataField="LName" HeaderText="LName" SortExpression="LName" />
                    <asp:BoundField DataField="SignIN" HeaderText="SignIN" SortExpression="SignIN" />
                    <asp:BoundField DataField="Date" HeaderText="Date" SortExpression="Date" DataFormatString="{0:MM/dd/yy}" />
                    <asp:TemplateField HeaderText="SignOUT" SortExpression="SignOUT">
                        <EditItemTemplate>
                            <asp:TextBox ID="TextBox1" runat="server" Text='<%# Bind("SignOUT") %>'></asp:TextBox>
                        </EditItemTemplate>
                        <ItemTemplate>
                            <asp:Label ID="Label1" runat="server" Text='<%# Bind("SignOUT") %>'></asp:Label>
                            <asp:Button ID="btnSignOut" runat="server" OnClick="btnSignOut_Click" Text="Sign Out" />
                        </ItemTemplate>
                    </asp:TemplateField>
           <asp:TemplateField ItemStyle-Width="40" ItemStyle-HorizontalAlign="Right"> 
       <%--  <ItemTemplate> 

            <asp:Image ID="Image1" runat="server" ImageUrl="~/images/magnify.gif" /> 
             <ajax:PopupControlExtender ID="PopupControlExtender1" runat="server" 
               PopupControlID="Panel1" 
               TargetControlID="Image1" 
               DynamicContextKey='<%# Eval("ID") %>' 
               DynamicControlID="Panel1" 
               DynamicServiceMethod="GetDynamicContent" Position="Bottom"> 
            </ajax:PopupControlExtender> 
            

         </ItemTemplate> --%>

<ItemStyle HorizontalAlign="Right" Width="40px"></ItemStyle>

      </asp:TemplateField> 
               
                </Columns>
            </asp:GridView>
             </div>  
           <div class="col-md-2"></div>
             
      </div>   
            <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:DefaultConnection %>" SelectCommand="SELECT LTRIM(RTRIM(FName)) + ' ' + LTRIM(RTRIM(LName)) AS Expr1 FROM Emp ORDER BY FName"></asp:SqlDataSource>
        
            <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:DefaultConnection %>" SelectCommand="SELECT Emp.ID, Emp.FName, Emp.LName, TimeLog.SignIN, TimeLog.Date, TimeLog.SignOUT FROM Emp INNER JOIN TimeLog ON Emp.ID = TimeLog.ID WHERE (TimeLog.Date = CONVERT (DATE, GETDATE(), 101))"></asp:SqlDataSource>
        <asp:Panel ID="Panel1" runat="server">
        </asp:Panel>
        
                  <br /><br />
               <asp:Label ID="AlertWindow" Visible="false" CssClass="alert alert-success" runat="server" Width ="30%"></asp:Label>

       
             </div><!--jumbotron-->

        </div> <!--container-->
        
    </form>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ScriptSection" Runat="Server">
</asp:Content>

