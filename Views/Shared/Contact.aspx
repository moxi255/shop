<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Views/Shared/MasterPage.master" CodeFile="Contact.aspx.cs" Inherits="Views_Shared_Contact" %>
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
            <div class="subtitle">联系我们</div>
            <div class="subcontent">
                <p><b>电话</b><a href="tel:4008001234" class="call">12345678</a></p>
                <p><b>传值</b>12345678</p>
                <p><b>邮编</b>1020600</p>
                <p><b>E-Mail</b><a href="Mailto:123@qq.com">123@qq.com</a></p>
                
            </div>
        </div>
        <div class="clear"></div>
    </div>
</asp:Content>