<%@ Page Language="C#" AutoEventWireup="true" Theme="admin" MasterPageFile="~/Views/Shared/admin.master" CodeFile="Detail.aspx.cs" Inherits="Views_User_Detail" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolderl" runat="server">
    <div style="text-align:center">
        <h1>用户详情</h1>
        <table style="width:503px; margin:0 auto;text-align:left">
            <tr><td><label for="userid">用户账号</label></td>
                <td>
                <asp:TextBox ID="userid" runat="server" ReadOnly="True"></asp:TextBox>    
                </td>
            </tr>
            <tr><td><label for="name">用户姓名</label></td>
                <td>
                <asp:TextBox ID="name" runat="server" Height="124px" TextMode="MultiLine" style="resize:none" Width="291px" ReadOnly="True"></asp:TextBox>
                </td>

            </tr>
            <tr><td><label for="email">用户邮件</label></td>
                <td>
                <asp:TextBox ID="email" runat="server" ReadOnly="True"></asp:TextBox>    
                </td>
            </tr>
            <tr><td><label for="company">用户公司</label></td>
                <td>
                <asp:TextBox ID="company" runat="server" ReadOnly="True"></asp:TextBox>    
                </td>
            </tr>
            <tr><td><label for="tel">用户电话</label></td>
                <td>
                <asp:TextBox ID="tel" runat="server" ReadOnly="True"></asp:TextBox>    
                </td>
            </tr>
            <tr><td><label for="fax">用户传真</label></td>
                <td>
                <asp:TextBox ID="fax" runat="server" ReadOnly="True"></asp:TextBox>    
                </td>
            </tr>
            <tr><td class="auto-style1" style="text-align:center" colspan="2">
                <asp:Button ID="Button2" runat="server" Text="返回"  PostBackUrl="~/Views/Product/Manage.aspx" />&nbsp;
                &nbsp;</td>

            </tr>
            

        </table>
    </div>
</asp:Content>