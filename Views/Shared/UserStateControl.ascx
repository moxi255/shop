<%@ Control Language="C#" AutoEventWireup="true" CodeFile="UserStateControl.ascx.cs" Inherits="Views_Shared_UserStateControl" %>
<asp:MultiView ID="MultiView1" runat="server">
            <asp:View ID="LoginView1" runat="server">
                <label for="UserName" style="margin: 4px">用户：</label>
                <asp:TextBox ID="UserName" style="margin:4px;" Width="110px"   runat="server" AutoCompleteType="Disabled" ></asp:TextBox><br />
                <label for="UserPwd" style="margin: 4px" >密码：</label>
                <asp:TextBox ID="Pwd" style="margin: 4px"   runat="server" TextMode="Password" Width="110px" AutoCompleteType="Disabled"></asp:TextBox><br />
                <asp:Button ID="Login" style="margin: 4px"  runat="server" Text="登录" OnClick="Login_Click" />
                <asp:Button ID="Register" style="margin: 4px"  runat="server" Text="注册" OnClick="Register_Click" />
                <asp:Button ID="FindPwd" style="margin: 4px" runat="server" Text="找回密码" PostBackUrl="~/Views/User/Find.aspx" />
                <br />
                <asp:CheckBox ID="Remember" style="margin: 4px"  runat="server" />记住我
            </asp:View>
            <asp:View ID="ShowView2" runat="server">
                <p>欢迎进入</p>
                当前用户<asp:Literal ID="Literal1" runat="server"></asp:Literal><br />
                <asp:LinkButton ID="LinkButton" runat="server" OnClick="LinkButton_Click">注销</asp:LinkButton>
                <asp:LinkButton ID="LinkButton1" runat="server" OnClick="LinkButton1_Click">删除Cookie</asp:LinkButton>
                <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/Views/User/Edit.aspx">个人修改</asp:HyperLink><br />
                <asp:HyperLink ID="HyperLink2" runat="server" NavigateUrl="~/Views/Product/Manage.aspx">产品</asp:HyperLink>
                <asp:HyperLink ID="HyperLink3" runat="server" NavigateUrl="~/Views/News/Manage.aspx">新闻</asp:HyperLink>
                <asp:HyperLink ID="HyperLink4" runat="server" NavigateUrl="~/Views/FeedBack/Manage.aspx">反馈</asp:HyperLink>
                <asp:HyperLink ID="HyperLink5" runat="server" NavigateUrl="~/Views/User/Manage.aspx">用户</asp:HyperLink>
            </asp:View>
</asp:MultiView>