<%@ Page Language="C#" AutoEventWireup="true"  Theme="admin" MasterPageFile="~/Views/Shared/admin.master" CodeFile="Edit.aspx.cs" Inherits="Views_Product_Edit" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolderl" runat="server">
     <asp:DetailsView ID="DetailsViews1" runat="server" AutoGenerateRows="False" CellPadding="4" DataSourceID="ObjectDataSource1" DefaultMode="Edit" ForeColor="#333333" GridLines="None" Height="50px" HorizontalAlign="Center" OnItemUpdated="DetailsViews1_ItemUpdated" OnItemUpdating="DetailsViews1_ItemUpdating" OnModeChanging="DetailsViews1_ModeChanging" Width="100%" DataKeyNames="ProdId">
            <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
            <CommandRowStyle BackColor="#E2DED6" Font-Bold="True" />
            <EditRowStyle BackColor="#999999" HorizontalAlign="Left" />
            <FieldHeaderStyle BackColor="#E9ECF1" Font-Bold="True" />
            <Fields>
                <asp:TemplateField HeaderText="产品类别">
                    <EditItemTemplate>
                        <asp:DropDownList ID="DropDownList1" runat="server" DataSourceID="ObjectDataSource2" DataTextField="CatName" DataValueField="CatId" SelectedValue='<%# ((Ep229Category)Eval("Category")).CatId %>'>
                        </asp:DropDownList>
                        <asp:ObjectDataSource ID="ObjectDataSource2" runat="server" SelectMethod="FindCategoryies" TypeName="Ep229CategoryBLL"></asp:ObjectDataSource>
                    </EditItemTemplate>
                    <HeaderStyle HorizontalAlign="Right" VerticalAlign="Middle" />
                </asp:TemplateField>
                <asp:BoundField DataField="ProdName" HeaderText="产品名称" SortExpression="ProdName" >
                <HeaderStyle HorizontalAlign="Right" VerticalAlign="Middle" />
                </asp:BoundField>
                <asp:BoundField DataField="ProdType" HeaderText="产品型号" SortExpression="ProdType" >
                <HeaderStyle HorizontalAlign="Right" VerticalAlign="Middle" />
                </asp:BoundField>
                <asp:BoundField DataField="ProdPrice" HeaderText="产品价格" SortExpression="ProdPrice" >
                <HeaderStyle HorizontalAlign="Right" VerticalAlign="Middle" />
                </asp:BoundField>
                <asp:TemplateField HeaderText="产品描述" SortExpression="ProdDesc">
                    <EditItemTemplate>
                        <asp:TextBox ID="TextBox1" runat="server" Text='<%# Bind("ProdDesc") %>' TextMode="MultiLine"></asp:TextBox>
                    </EditItemTemplate>
                    <InsertItemTemplate>
                        <asp:TextBox ID="TextBox1" runat="server" Text='<%# Bind("ProdDesc") %>'></asp:TextBox>
                    </InsertItemTemplate>
                    <ItemTemplate>
                        <asp:Label ID="Label1" runat="server" Text='<%# Bind("ProdDesc") %>'></asp:Label>
                    </ItemTemplate>
                    <HeaderStyle HorizontalAlign="Right" VerticalAlign="Middle" />
                </asp:TemplateField>
                <asp:CheckBoxField DataField="ProdFirstShow" HeaderText="在首页" SortExpression="ProdFirstShow" >
                <HeaderStyle HorizontalAlign="Right" VerticalAlign="Middle" />
                </asp:CheckBoxField>
                <asp:CommandField ShowEditButton="True" >
                <FooterStyle HorizontalAlign="Center" VerticalAlign="Middle" />
                <ItemStyle HorizontalAlign="Center" VerticalAlign="Middle" />
                </asp:CommandField>
            </Fields>
            <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
            <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
            <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
        </asp:DetailsView>
        <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" OnUpdated="ObjectDataSource1_Updated" SelectMethod="FindProductById" TypeName="Ep229ProductBLL" DataObjectTypeName="Ep229Product" UpdateMethod="EditProduct">
            <SelectParameters>
                <asp:QueryStringParameter Name="prodId" QueryStringField="prodId" Type="Int32" />
            </SelectParameters>
        </asp:ObjectDataSource>
       
</asp:Content>

