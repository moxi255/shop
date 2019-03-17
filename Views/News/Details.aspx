<%@ Page Language="C#" AutoEventWireup="true" Theme="admin" MasterPageFile="~/Views/Shared/admin.master" CodeFile="Details.aspx.cs" Inherits="Views_News_Details" %>
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
    <div style="text-align:center;margin:0 auto">
        <h1>查看新闻</h1>
        <table style="width:503px; margin:0 auto;text-align:left">
            <tr><td><label for="TextBox1">新闻标题</label></td>
                <td>
                <asp:TextBox ID="TextBox3" runat="server" ReadOnly="True"></asp:TextBox>    
                </td>
            </tr>
            <tr><td><label for="TextBox2">新闻内容</label></td>
                <td>
                <asp:TextBox ID="TextBox4" runat="server" Height="124px" TextMode="MultiLine" style="resize:none" Width="291px" ReadOnly="True"></asp:TextBox>
                </td>

            </tr>
            <tr><td class="auto-style1" style="text-align:center" colspan="2">
                <asp:Button ID="Button2" runat="server" Text="返回"  />&nbsp;
                &nbsp;</td>

            </tr>
            

        </table>
       </div>
</asp:Content>
