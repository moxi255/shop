<%@ Page Language="C#" AutoEventWireup="true"  MasterPageFile="~/Views/Shared/MasterPage.master" CodeFile="Edit.aspx.cs" Inherits="Views_User_Edit" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolderl" runat="server">
    <style>

        .btn{
            display: inline-block;
            padding: 6px 12px;
            margin-bottom: 0;
            font-size: 14px;
            font-weight: 400;
            line-height: 1.42857143;
            text-align: center;
            white-space: nowrap;
            vertical-align: middle;
            -ms-touch-action: manipulation;
            touch-action: manipulation;
            cursor: pointer;
            -webkit-user-select: none;
            -moz-user-select: none;
            -ms-user-select: none;
            user-select: none;
            background-image: none;
            border: 1px solid transparent;
            border-radius: 4px;
            font-family: inherit;
            font-size: inherit;
            line-height: inherit;
            color: #fff;
            background-color: #286090;
            border-color: #204d74;
        }
    </style>
   <h1>更改密码</h1>
        <table style="margin: 0 auto;">
            <tr>
                <td style="text-align: right" class="auto-style2">用户名</td>
                <td style="text-align: left"><asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td style="text-align: right" class="auto-style2">密码</td>
                <td style="text-align: left">
                    <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td colspan="3">
                    <asp:Button ID="Button1" runat="server" Text="修改" OnClick="Button1_Click" />
                    <asp:Button ID="Button2" runat="server" Text="返回" PostBackUrl="~/Views/Index.aspx" />
                </td>
            </tr>
        </table>
</asp:Content>
