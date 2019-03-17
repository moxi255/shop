<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Views/Shared/MasterPage.master" CodeFile="Browse.aspx.cs" Inherits="Views_News_Browse" %>
<%@ Register Src="~/Views/Shared/UserStateControl.ascx"   TagName="UserStateControl" TagPrefix="ucl"%>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolderl" runat="server">
<asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
    <div class="index">
        <div id="left">
            <div id="userstate">
                <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                    <ContentTemplate>
                        <ucl:UserStateControl ID="ContentPlaceHolderl" runat="server"></ucl:UserStateControl>
                    </ContentTemplate>
                </asp:UpdatePanel>
                
            </div>
            <div id="info">
                <p><b>电话</b><a href="tel:4008001234" class="call">12345678</a></p>
                <p><b>传值</b>12345678</p>
                <p><b>邮编</b>1020600</p>
                <p><b>E-Mail</b><a href="Mailto:123@qq.com">123@qq.com</a></p>
            </div>
        </div>
        <div id="right">
            <div class="subtitle">公司新闻</div>
            <div class="subcontent">
                <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" CellPadding="4" DataSourceID="ObjectDataSource1" ForeColor="#333333" GridLines="None" Width="100%" DataKeyNames="NewsId">
                    <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
                    <Columns>
                        <asp:BoundField DataField="NewsTitle" HeaderText="新闻标题" SortExpression="NewsTitle" />
                        <asp:HyperLinkField  DataNavigateUrlFields="NewsId" DataNavigateUrlFormatString="~/Views/News/Details.aspx?NewsId={0}" DataTextField="NewsContent" HeaderText="新闻内容" HeaderStyle-HorizontalAlign="NotSet" />
                        <asp:BoundField DataField="NewsDatetime" HeaderText="新闻创建时间" SortExpression="NewsDatetime" />
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
                <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" SelectMethod="SelectAll" TypeName="Ep229NewsDAL"></asp:ObjectDataSource>
            </div>
        </div>
        <div class="clear"></div>
    </div>
</asp:Content>

