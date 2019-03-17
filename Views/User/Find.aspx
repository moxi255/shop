<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Views/Shared/MasterPage.master" CodeFile="Find.aspx.cs" Inherits="Views_User_Find" %>
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
    <h1>找回密码</h1>
    <table style="margin: 0 auto; border-width: 0px; text-align: left;">
            <tr>
                <td style="text-align: right">请输入用户名</td>
                <td style="text-align: left">
                    <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="用户名不能为空" ControlToValidate="TextBox1" Display="Dynamic"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td style="text-align: right">请输入邮箱</td>
                <td style="text-align: left">
                    <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="TextBox2" ErrorMessage="邮箱不能为空" Display="Dynamic"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td style="text-align: right">请输入验证码</td>
                <td style="text-align: left">
                    <asp:TextBox ID="TextBox3" runat="server" ></asp:TextBox>
                    <asp:Image ID="Image1" runat="server"  src="../Shared/ImgPng.aspx" style="cursor:pointer" onclick="this.src=this.src+'?'" align="middle"  alt="看不清楚，点击换一张！" />
                    <asp:CustomValidator ID="CustomValidator1" runat="server" ControlToValidate="TextBox3" ErrorMessage="验证码错误" OnServerValidate="CustomValidator1_ServerValidate"></asp:CustomValidator>
                </td>
            </tr>
            <tr>
                <td colspan="2" style="text-align: center">
                    <asp:Button ID="Button1" runat="server" Text="确认" OnClick="Button1_Click" />
                    <input id="Button2" style="margin-top:4px;" class="btn" type="reset" value="取消" /></td>
            </tr>
        </table>
</asp:Content>
