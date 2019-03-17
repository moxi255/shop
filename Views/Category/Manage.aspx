<%@ Page Language="C#" AutoEventWireup="true" Theme="admin" MasterPageFile="~/Views/Shared/admin.master" CodeFile="Manage.aspx.cs" Inherits="Views_Category_Manage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolderl" runat="server">
    <div style="text-align:center;margin:0 auto">
        <asp:GridView ID="GridViews1" runat="server" AutoGenerateColumns="False" CellPadding="4" DataKeyNames="CatId" DataSourceID="ObjectDataSource1" ForeColor="#333333" GridLines="None" HorizontalAlign="Center" Width="100%">
            <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
            <Columns>
                <asp:BoundField DataField="CatId" HeaderText="分类号" SortExpression="CatId" />
                <asp:BoundField DataField="CatName" HeaderText="属性名" SortExpression="CatName" />
                <asp:CommandField HeaderText="操作" ShowDeleteButton="True" ShowEditButton="True" />
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
        <br />
        <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" OnInserting="ObjectDataSource1_Inserting" SelectMethod="FindCategoryies" TypeName="Ep229CategoryBLL" DataObjectTypeName="Ep229Category" DeleteMethod="DeleteCategory" InsertMethod="AddCategory" UpdateMethod="EditCategory"></asp:ObjectDataSource>
    
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click1" Text="添加" />
        <asp:Button ID="Button2" runat="server" OnClick="Button2_Click1" Text="保存" Visible="False" />
        <asp:Button ID="Button3" runat="server" OnClick="Button3_Click1" Text="取消" Visible="False" />
        <asp:TextBox ID="TextBox1" runat="server" Visible="False"></asp:TextBox>
       </div>
</asp:Content>