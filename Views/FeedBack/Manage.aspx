<%@ Page Language="C#" AutoEventWireup="true" Theme="admin" MasterPageFile="~/Views/Shared/admin.master"  CodeFile="Manage.aspx.cs" Inherits="Views_FeedBack_Manage" EnableEventValidation="false"  %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolderl" runat="server">

        <asp:GridView ID="GridViews1"  runat="server" AutoGenerateColumns="False" DataKeyNames="FbackId" DataSourceID="ObjectDataSource1"  CellPadding="4" ForeColor="#333333" GridLines="None" Width="100%">
            <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
            <Columns>
                <asp:BoundField DataField="FbackTitle" HeaderText="反馈标题" SortExpression="FbackTitle" />
                <asp:BoundField DataField="FbackContent" HeaderText="反馈内容" SortExpression="FbackContent" />
                <asp:TemplateField HeaderText="反馈人">
                    <ItemTemplate>
                        <asp:Literal ID="Literal1" runat="server" Text='<%# ((Ep229User)Eval("user")).UserName %>'></asp:Literal>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:BoundField DataField="FbackDatetime" HeaderText="反馈日期" SortExpression="FbackDatetime" />
                <asp:CommandField ShowDeleteButton="True" HeaderText="操作" ShowEditButton="True" />
            </Columns>
            <EditRowStyle BackColor="#999999" />
            <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
            <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
            <RowStyle BackColor="#F7F6F3" ForeColor="#333333" HorizontalAlign="Center" VerticalAlign="Middle" />
            <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
            <SortedAscendingCellStyle BackColor="#E9E7E2" />
            <SortedAscendingHeaderStyle BackColor="#506C8C" />
            <SortedDescendingCellStyle BackColor="#FFFDF8" />
            <SortedDescendingHeaderStyle BackColor="#6F8DAE" />
        </asp:GridView>
        <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" SelectMethod="FindFeedBacks" TypeName="Ep229FeedBackBLL" DataObjectTypeName="Ep229FeedBack" DeleteMethod="DeleteFeedBack" UpdateMethod="EditFeedBack"></asp:ObjectDataSource>
    
        <br />
</asp:Content>