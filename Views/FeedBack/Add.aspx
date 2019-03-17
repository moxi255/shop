<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Views/Shared/MasterPage.master" CodeFile="Add.aspx.cs" Inherits="Views_FeedBack_Add" %>

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
            <div class="subtitle">反馈</div>
            <div class="subcontent">
                <table style="width:503px;text-align:left">
                    <tr><td><label for="TextBox1">反馈标题:</label></td>
                        <td>
                            <asp:TextBox ID="TextBox1" runat="server" AutoCompleteType="Disabled"></asp:TextBox>
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="不能为空" ControlToValidate="TextBox1"></asp:RequiredFieldValidator>
                        </td>
                    </tr>
                    <tr><td><label for="TextBox2">反馈内容</label></td>
                        <td>
                        <asp:TextBox ID="TextBox2" style="resize:none" runat="server" TextMode="MultiLine" AutoCompleteType="Disabled"></asp:TextBox>
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="不能为空" ControlToValidate="TextBox2"></asp:RequiredFieldValidator>
                        </td>

                    </tr>
                    <tr><td class="auto-style1" style="text-align:center" colspan="2">
                        <asp:Button ID="Button2" runat="server" Text="提交" OnClick="Button1_Click" />&nbsp;
                        &nbsp;<input type="reset" value="取消" /></td>

                    </tr>
            
                </table>
            </div>
        </div>
        <div class="clear"></div>
    </div>
</asp:Content>


