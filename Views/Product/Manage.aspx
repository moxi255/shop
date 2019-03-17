<%@ Page Language="C#" AutoEventWireup="true" Theme="admin" MasterPageFile="~/Views/Shared/admin.master" CodeFile="Manage.aspx.cs" Inherits="Views_Product_Manage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolderl" runat="server">
    <div style="text-align:center;margin:0 auto">
        <asp:Literal ID="Literal1" runat="server" Text="产品名称"></asp:Literal>
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        <asp:Button ID="Button1" runat="server" Text="查询" OnClick="Button1_Click" />
        <asp:Button ID="Button2" runat="server" PostBackUrl="~/Views/Product/Add.aspx" Text="添加产品" />
        <asp:GridView ID="GridViews1" runat="server" AllowPaging="True" AutoGenerateColumns="False" CellPadding="4" DataKeyNames="ProdId" DataSourceID="ObjectDataSource1" ForeColor="#333333" GridLines="None" HorizontalAlign="Center" Width="100%">
            <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
            <Columns>
                <asp:TemplateField HeaderText="产品类别">
                    <ItemTemplate>
                        <asp:Literal ID="Literal2" runat="server" Text='<%# ((Ep229Category)Eval("Category")).CatName %>'></asp:Literal>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:BoundField DataField="ProdType" HeaderText="产品型号" SortExpression="ProdType" />
                <asp:HyperLinkField DataNavigateUrlFields="ProdId" DataNavigateUrlFormatString="~/Views/Product/Details.aspx?ProdId={0}" DataTextField="ProdName" HeaderText="产品名称" />
                <asp:BoundField DataField="ProdPrice" HeaderText="产品价格" SortExpression="ProdPrice" />
                <asp:BoundField DataField="ProdDatetime" HeaderText="发布时间" SortExpression="ProdDatetime" />
                <asp:CheckBoxField DataField="ProdFirstShow" HeaderText="在首页" SortExpression="ProdFirstShow" />
                <asp:TemplateField HeaderText="操作" ShowHeader="False">
                    <ItemTemplate>
                        <asp:LinkButton ID="LinkButton1" runat="server" CausesValidation="False" CommandName="Delete" Text="删除"></asp:LinkButton>
                        <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl='<%# Eval("ProdId","~/Views/Product/Edit.aspx?prodId={0}") %>'>编辑</asp:HyperLink>
                    </ItemTemplate>
                </asp:TemplateField>
            </Columns>
            <EditRowStyle BackColor="#999999" />
            <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
            <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
            <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
            <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
            <SortedAscendingCellStyle BackColor="#E9E7E2" />
            <SortedAscendingHeaderStyle BackColor="#506C8C" />
            <SortedDescendingCellStyle BackColor="#FFFDF8" />
            <SortedDescendingHeaderStyle BackColor="#6F8DAE" />
        </asp:GridView>
        <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" SelectMethod="FindProducts" TypeName="Ep229ProductBLL" DataObjectTypeName="Ep229Product" DeleteMethod="DeleteProduct"></asp:ObjectDataSource>
       </div>
</asp:Content>
