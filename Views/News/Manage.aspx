<%@ Page Language="C#" AutoEventWireup="true" Theme="admin" MasterPageFile="~/Views/Shared/admin.master" CodeFile="Manage.aspx.cs" Inherits="Views_News_Manage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolderl" runat="server">
    <div style="text-align:center;margin:0 auto">
         <asp:GridView ID="GridViews1" runat="server" AutoGenerateColumns="False" CellPadding="4" DataSourceID="ObjectDataSource1" ForeColor="#333333" GridLines="None" AllowPaging="True" DataKeyNames="NewsId" HorizontalAlign="Center" Width="100%">
            <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
            <Columns>
                <asp:HyperLinkField DataNavigateUrlFields="NewsId" DataNavigateUrlFormatString="~/Views/News/Details.aspx?NewsId={0}"   HeaderText="新闻标题" DataTextField="NewsTitle" />
                <asp:BoundField DataField="NewsContent" HeaderText="新闻内容" SortExpression="NewsContent" />
                <asp:BoundField DataField="NewsDatetime" HeaderText="新闻创建时间" SortExpression="NewsDatetime" />
                <asp:TemplateField ShowHeader="False" HeaderText="操作">
                    <ItemTemplate>
                        <asp:LinkButton ID="LinkButton1" runat="server" CausesValidation="False" CommandName="Delete" Text="删除"></asp:LinkButton>
                        <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl='<%# Eval("NewsId","~/Views/News/Edit.aspx?NewsId={0}") %>'>修改</asp:HyperLink>
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
        <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" DataObjectTypeName="Ep229News" DeleteMethod="DeleteNews" InsertMethod="AddNews" SelectMethod="SelectAll" TypeName="Ep229NewsBLL" UpdateMethod="EditNews"></asp:ObjectDataSource><br />
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" style="height: 21px" Text="添加" />
      </div>
</asp:Content>