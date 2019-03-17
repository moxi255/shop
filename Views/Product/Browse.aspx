<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Views/Shared/MasterPage.master"  CodeFile="Browse.aspx.cs" Inherits="Views_Product_Browse" %>
<%@ Register Src="~/Views/Shared/UserStateControl.ascx"   TagName="UserStateControl" TagPrefix="ucl"%>
<%@ Register Src="~/Views/Shared/CatMenu.ascx"   TagName="CatMenu" TagPrefix="ucl"%>



<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolderl" runat="server">
    <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
    <div class="index">
        <div id="left">
            <div id="userstate">
                <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                    <ContentTemplate>
                        <ucl:UserStateControl ID="UserStateControl1" runat="server"></ucl:UserStateControl>
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
            <div class="subtitle">产品分类</div>
            <div class="subcontent">
                <ucl:CatMenu ID="ContentPlaceHolderl" runat="server"></ucl:CatMenu><br />
        <asp:GridView ID="GridViews1" runat="server" AllowPaging="True" AutoGenerateColumns="False" CellPadding="4" DataSourceID="ObjectDataSource1" ForeColor="#333333" GridLines="None" HorizontalAlign="Center" Width="100%">
            <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
            <Columns>
                <asp:BoundField DataField="ProdName" HeaderText="产品名称" SortExpression="ProdName" />
                <asp:BoundField DataField="ProdType" HeaderText="产品型号" SortExpression="ProdType" />
                <asp:BoundField DataField="ProdPrice" HeaderText="产品价格" SortExpression="ProdPrice" />
                <asp:BoundField DataField="ProdDatetime" HeaderText="发布时间" SortExpression="ProdDatetime" />
                <asp:TemplateField HeaderText="产品类别">
                    <ItemTemplate>
                        <asp:Literal ID="Literal1" runat="server" Text='<%# ((Ep229Category)Eval("Category")).CatName %>'></asp:Literal>
                    </ItemTemplate>
                </asp:TemplateField>
            </Columns>
            <EditRowStyle BackColor="#999999" />
            <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
            <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
            <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
            <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
            <SortedAscendingCellStyle BackColor="#E9E7E2" />
            <SortedAscendingHeaderStyle BackColor="#506C8C" />
            <SortedDescendingCellStyle BackColor="#FFFDF8" />
            <SortedDescendingHeaderStyle BackColor="#6F8DAE" />
        </asp:GridView>
        <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" SelectMethod="FindProducts" SortParameterName="sortExpression" TypeName="Ep229ProductBLL">
            <SelectParameters>
                <asp:Parameter DefaultValue="" Direction="Output" Name="total" Type="Int32" />
                <asp:ControlParameter ControlID="ContentPlaceHolderl" DefaultValue="0" Name="catId" PropertyName="CatId" Type="Int32" />
                <asp:Parameter Name="prodName" Type="String" />
                <asp:Parameter Name="sortExpression" Type="String" />
                <asp:Parameter Name="start" Type="Int32" />
                <asp:Parameter Name="count" Type="Int32" />
            </SelectParameters>
        </asp:ObjectDataSource>
            </div>
        </div>
        <div class="clear"></div>
    </div>
</asp:Content>
