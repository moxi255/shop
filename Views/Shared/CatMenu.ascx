<%@ Control Language="C#" AutoEventWireup="true" CodeFile="CatMenu.ascx.cs" Inherits="Views_Shared_Controls_CatMenu" %>
<asp:DataList ID="DataList1" runat="server" DataSourceID="ObjectDataSource1" HorizontalAlign="Center" OnItemCommand="DataList1_ItemCommand" RepeatColumns="2" Width="100%">
    <ItemStyle Width="150px" HorizontalAlign="Center" VerticalAlign="Middle" />
    <ItemTemplate>
        <asp:LinkButton ID="LinkButton2" runat="server" CommandArgument='<%# Eval("CatId") %>' Text='<%# Eval("CatName") %>'></asp:LinkButton>
<br />
    </ItemTemplate>
</asp:DataList>
<asp:ObjectDataSource ID="ObjectDataSource1" runat="server" SelectMethod="FindCategoryies" TypeName="Ep229CategoryBLL"></asp:ObjectDataSource>

