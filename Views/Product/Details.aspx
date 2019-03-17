<%@ Page Language="C#" AutoEventWireup="true"  Theme="admin" MasterPageFile="~/Views/Shared/admin.master" CodeFile="Details.aspx.cs" Inherits="Views_Product_Details" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolderl" runat="server">
    <div style="text-align:center;margin:0 auto">
     <asp:FormView ID="FormViews1" style="margin:0 auto;" runat="server" CellPadding="4" DataSourceID="ObjectDataSource1" ForeColor="#333333" Width="920px">
            <EditItemTemplate>
                ProdId:
                <asp:TextBox ID="ProdIdTextBox" runat="server" Text='<%# Bind("ProdId") %>' />
                <br />
                Category:
                <asp:TextBox ID="CategoryTextBox" runat="server" Text='<%# Bind("Category") %>' />
                <br />
                ProdName:
                <asp:TextBox ID="ProdNameTextBox" runat="server" Text='<%# Bind("ProdName") %>' />
                <br />
                ProdType:
                <asp:TextBox ID="ProdTypeTextBox" runat="server" Text='<%# Bind("ProdType") %>' />
                <br />
                ProdPrice:
                <asp:TextBox ID="ProdPriceTextBox" runat="server" Text='<%# Bind("ProdPrice") %>' />
                <br />
                ProdImage:
                <asp:TextBox ID="ProdImageTextBox" runat="server" Text='<%# Bind("ProdImage") %>' />
                <br />
                ProdDesc:
                <asp:TextBox ID="ProdDescTextBox" runat="server" Text='<%# Bind("ProdDesc") %>' />
                <br />
                ProdDatetime:
                <asp:TextBox ID="ProdDatetimeTextBox" runat="server" Text='<%# Bind("ProdDatetime") %>' />
                <br />
                ProdFirstShow:
                <asp:CheckBox ID="ProdFirstShowCheckBox" runat="server" Checked='<%# Bind("ProdFirstShow") %>' />
                <br />
                <asp:LinkButton ID="UpdateButton" runat="server" CausesValidation="True" CommandName="Update" Text="更新" />
                &nbsp;<asp:LinkButton ID="UpdateCancelButton" runat="server" CausesValidation="False" CommandName="Cancel" Text="取消" />
            </EditItemTemplate>
            <EditRowStyle BackColor="#999999" />
            <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
            <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" HorizontalAlign="Center" />
            <InsertItemTemplate>
                ProdId:
                <asp:TextBox ID="ProdIdTextBox" runat="server" Text='<%# Bind("ProdId") %>' />
                <br />
                Category:
                <asp:TextBox ID="CategoryTextBox" runat="server" Text='<%# Bind("Category") %>' />
                <br />
                ProdName:
                <asp:TextBox ID="ProdNameTextBox" runat="server" Text='<%# Bind("ProdName") %>' />
                <br />
                ProdType:
                <asp:TextBox ID="ProdTypeTextBox" runat="server" Text='<%# Bind("ProdType") %>' />
                <br />
                ProdPrice:
                <asp:TextBox ID="ProdPriceTextBox" runat="server" Text='<%# Bind("ProdPrice") %>' />
                <br />
                ProdImage:
                <asp:TextBox ID="ProdImageTextBox" runat="server" Text='<%# Bind("ProdImage") %>' />
                <br />
                ProdDesc:
                <asp:TextBox ID="ProdDescTextBox" runat="server" Text='<%# Bind("ProdDesc") %>' />
                <br />
                ProdDatetime:
                <asp:TextBox ID="ProdDatetimeTextBox" runat="server" Text='<%# Bind("ProdDatetime") %>' />
                <br />
                ProdFirstShow:
                <asp:CheckBox ID="ProdFirstShowCheckBox" runat="server" Checked='<%# Bind("ProdFirstShow") %>' />
                <br />
                <asp:LinkButton ID="InsertButton" runat="server" CausesValidation="True" CommandName="Insert" Text="插入" />
                &nbsp;<asp:LinkButton ID="InsertCancelButton" runat="server" CausesValidation="False" CommandName="Cancel" Text="取消" />
            </InsertItemTemplate>
            <ItemTemplate>
                <table class="auto-style3" >
                    <tr>
                        <td class="auto-style2" style="width:200px;height:200px" rowspan="6">
                            <asp:Image ID="Image1"  runat="server" ImageUrl='<%# Eval("ProdImage","~/Views/Images/{0}") %>' />
                        </td>
                        <td style="width:150px;" class="auto-style1">产品名称:</tdstyle="width:200px;>
                        <td class="auto-style1">
                            <asp:Literal ID="Literal1" runat="server" Text='<%# Eval("ProdName") %>'></asp:Literal>
                        </td>
                    </tr>
                    <tr>
                        <td>产品类别:</td>
                        <td>
                            <asp:Literal ID="Literal2" runat="server" Text='<%# ((Ep229Category)Eval("Category")).CatName %>'></asp:Literal>
                        </td>
                    </tr>
                    <tr>
                        <td>产品型号:</td>
                        <td>
                            <asp:Literal ID="Literal3" runat="server" Text='<%# Eval("ProdType") %>'></asp:Literal>
                        </td>
                    </tr>
                    <tr>
                        <td>产品单价:</td>
                        <td>
                            <asp:Literal ID="Literal4" runat="server" Text='<%# Eval("ProdPrice") %>'></asp:Literal>
                        </td>
                    </tr>
                    <tr>
                        <td>产品简介:</td>
                        <td rowspan="2">
                            <asp:Literal ID="Literal5" runat="server" Text='<%# Eval("ProdDesc") %>'></asp:Literal>
                        </td>
                    </tr>
                    <tr>
                        <td>&nbsp;</td>
                    </tr>
                </table>
                <br />
            </ItemTemplate>
            <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
            <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
        </asp:FormView>
        <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" SelectMethod="FindProductById" TypeName="Ep229ProductBLL">
            <SelectParameters>
                <asp:QueryStringParameter Name="prodId" QueryStringField="prodId" Type="Int32" />
            </SelectParameters>
        </asp:ObjectDataSource>
        <br />
        <asp:Button ID="Button1" runat="server" PostBackUrl="~/Views/Product/Manage.aspx" Text="返回"  />
       </div>
</asp:Content>