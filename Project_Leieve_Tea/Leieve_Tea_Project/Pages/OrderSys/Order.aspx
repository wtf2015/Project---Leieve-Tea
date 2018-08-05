<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Order.aspx.cs" Inherits="Leieve_Tea_Project.Pages.OrderSys.Order" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <link href="~/css/order.css" rel="stylesheet" type="text/css" />
    <h3>Waiting for UX design...</h3>
    <asp:Repeater ID="CategoryRepeater" runat="server" ItemType="LeieveTea.Data.DTOs.CategoryDTO" DataSourceID="MenuODS">
        <ItemTemplate>
            <div>
            <h2><%# Item.Description %></h2>
            <asp:Repeater ID="MenuItemRepeater" runat="server" DataSource='<%# Item.MenuItems %>' ItemType="LeieveTea.Data.DTOs.MenuItemPOCO">
                <HeaderTemplate>
                    <table>                    
                </HeaderTemplate>
                <FooterTemplate>
                    </table>
                </FooterTemplate>
                <ItemTemplate>
                    <tr>
                        <th><%# Item.ItemDescription%></th>
                        <td><i class="glyphicon glyphicon-info-sign"></i></td>
                        <td><%# $"{ Item.Price:C}" %></td>
                        <td>
                            <asp:LinkButton ID="AddMenuItemLB" runat="server">
                                <i class="fa fa-plus-circle"></i>
                            </asp:LinkButton></td>
                    </tr>
                </ItemTemplate>
            </asp:Repeater>
            </div>
            
        </ItemTemplate>
    </asp:Repeater>
    <asp:ObjectDataSource runat="server" ID="MenuODS" OldValuesParameterFormatString="original_{0}" SelectMethod="MenuByCategory_list" TypeName="LeieveTeaSystem.BLL.MenuController"></asp:ObjectDataSource>
</asp:Content>





























