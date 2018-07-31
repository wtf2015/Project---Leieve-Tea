<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Order.aspx.cs" Inherits="Leieve_Tea_Project.Pages.OrderSys.Order" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <link href="~/css/order.css" rel="stylesheet" type="text/css" />

     <header class="page-marque">
        <%--<div>
            <img src="img/LT_LOGO.png" alt="">
        </div>--%>      
        <div>
            <h1>L<span class="wave">O</span>VE TEA</h1>
            <img class="straw-art" src="img/svg/straw.svg" alt="" />
        </div>

           
    </header> 

   
    <asp:Repeater ID="CategoryRepeater" runat="server" 
        ItemType="LeieveTea.Data.DTOs.CategoryDTO" DataSourceID="MenuODS">
        <ItemTemplate >
            <div style="margin-left:100px">
            <h2><%# Item.Description %></h2>
            <asp:Repeater ID="MenuItemRepeater" runat="server" DataSource='<%# Item.MenuItems %>' 
                ItemType="LeieveTea.Data.DTOs.MenuItemPOCO" >
                <HeaderTemplate>
                    <table>                    
                </HeaderTemplate>
                <FooterTemplate>
                    </table>
                </FooterTemplate>
                <ItemTemplate>
                    <tr>
                        <th style="width: 400px"><%# Item.ItemDescription%></th>
                        <td><i class="glyphicon glyphicon-info-sign"></i></td>
                        <td><%# $"{ Item.Price:C}" %></td>
                        <td>
                            <asp:LinkButton ID="AddMenuItemLB" runat="server" OnCommand="AddMenuItemLB_Command" 
                                CommandArgument='<%# Item.ItemDescription + "," +  Item.Price %>'>
                                <span class="glyphicon glyphicon-plus"></span>
                            </asp:LinkButton>
                        </td>
                    </tr>
                </ItemTemplate>
            </asp:Repeater>
            </div>
            
        </ItemTemplate>
    </asp:Repeater>
    <br />
    <br />
    <div style="margin-left:100px">
        <asp:Label ID="SuntotalLabel" runat="server" Text="Subtotal">Subtotal: </asp:Label>
        <asp:TextBox ID="SubtotalTextBox" runat="server"></asp:TextBox>
    </div>
    <div>
        <asp:Label ID="GSTLabel" runat="server" Text="Subtotal">GST: </asp:Label>
         <asp:TextBox ID="GSTTextBox" runat="server"></asp:TextBox>
     </div>
    <div>
        <asp:Label ID="TotalLabel" runat="server" Text="Subtotal">Total: </asp:Label>
         <asp:TextBox ID="TotalTextBox" runat="server"></asp:TextBox>
    </div>
   
    <asp:ObjectDataSource runat="server" ID="MenuODS" OldValuesParameterFormatString="original_{0}" SelectMethod="MenuByCategory_list" TypeName="LeieveTeaSystem.BLL.MenuController"></asp:ObjectDataSource>
</asp:Content>





























