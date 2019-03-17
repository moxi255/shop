<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Views/Shared/MasterPage.master" CodeFile="Index.aspx.cs" Inherits="Views_Index" %>
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
                <p><b>电话:</b><a href="tel:4008001234" class="call">12345678</a></p>
                <p><b>传值:</b>12345678</p>
                <p><b>邮编:</b>1020600</p>
                <p><b>E-Mail:</b><a href="Mailto:123@qq.com">123@qq.com</a></p>
            </div>
        </div>
        <div id="right">
            <div class="subtitle">公司简介</div>
            <div class="subcontent">
                <asp:UpdatePanel ID="UpdatePanel2" runat="server">
                    <ContentTemplate>
                        <asp:ListView ID="ListViews1" runat="server" DataSourceID="ObjectDataSource1" GroupItemCount="5" OnItemCommand="ListViews1_ItemCommand">
                    
                    <EmptyDataTemplate>
                        <table runat="server" style="">
                            <tr>
                                <td>未返回数据。</td>
                            </tr>
                        </table>
                    </EmptyDataTemplate>
                    <EmptyItemTemplate>
                            <td runat="server" />
                    </EmptyItemTemplate>
                    <GroupTemplate>
                        <tr id="itemPlaceholderContainer" runat="server">
                            <td id="itemPlaceholder" runat="server"></td>
                        </tr>
                    </GroupTemplate>
                    
                    <ItemTemplate>
                        <td runat="server" style="text-align: center; width: 147px; height: 99px;"><br />
                            <asp:ImageButton ID="ImageButton1" runat="server" CommandArgument='<%# Eval("ProdId") %>' Height="88px" ImageUrl='<%# Eval("ProdImage","~/Views/Images/{0}") %>' Width="70px" />
                        </td>
                    </ItemTemplate>
                    <LayoutTemplate>
                        <table runat="server">
                            <tr runat="server">
                                <td runat="server">
                                    <table id="groupPlaceholderContainer" runat="server" border="0" style="">
                                        <tr id="groupPlaceholder" runat="server">
                                        </tr>
                                    </table>
                                </td>
                            </tr>
                            <tr runat="server">
                                <td runat="server" style="text-align:center">
                                    <asp:DataPager ID="DataPager1" runat="server">
                                        <Fields>
                                            <asp:NextPreviousPagerField ShowFirstPageButton="True" ShowNextPageButton="False" ShowPreviousPageButton="False" />
                                            <asp:NumericPagerField />
                                            <asp:NextPreviousPagerField ShowLastPageButton="True" ShowNextPageButton="False" ShowPreviousPageButton="False" />
                                        </Fields>
                                    </asp:DataPager>
                                </td>
                            </tr>
                        </table>
                    </LayoutTemplate>
                </asp:ListView>
                <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" SelectMethod="FindProductsForFirst" TypeName="Ep229ProductBLL">
                    <SelectParameters>
                        <asp:Parameter Direction="Output" Name="total" Type="Int32" />
                        <asp:Parameter Name="start" Type="Int32" />
                        <asp:Parameter Name="count" Type="Int32" />
                    </SelectParameters>
                </asp:ObjectDataSource>
                    </ContentTemplate>
                </asp:UpdatePanel>
                
            </div>
        </div>
        <div class="clear"></div>
    </div>
</asp:Content>
