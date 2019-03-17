<%@ Page Language="C#" AutoEventWireup="true"  Theme="admin" MasterPageFile="~/Views/Shared/admin.master" CodeFile="Add.aspx.cs" Inherits="Views_Product_Add" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolderl" runat="server">
     <asp:DetailsView ID="DetailsViews1" runat="server" AutoGenerateRows="False" CellPadding="4" DataSourceID="ObjectDataSource1" DefaultMode="Insert" ForeColor="#333333" GridLines="None" Height="50px" HorizontalAlign="Center" OnItemInserted="DetailsViews1_ItemInserted" OnItemInserting="DetailsViews1_ItemInserting" OnModeChanging="DetailsViews1_ModeChanging" Width="100%" >
            <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
            <CommandRowStyle BackColor="#E2DED6" Font-Bold="True" />
            <EditRowStyle BackColor="#999999" />
            <FieldHeaderStyle BackColor="#E9ECF1" Font-Bold="True" HorizontalAlign="Left" />
            <Fields>
                <asp:TemplateField HeaderText="产品类别">
                    <InsertItemTemplate>
                        <asp:DropDownList ID="DropDownList1" runat="server" DataSourceID="ObjectDataSource2" DataTextField="CatName" DataValueField="CatId" SelectedValue='<%# Bind("CatId") %>'>
                        </asp:DropDownList>
                        <asp:ObjectDataSource ID="ObjectDataSource2" runat="server" SelectMethod="FindCategoryies" TypeName="Ep229CategoryBLL"></asp:ObjectDataSource>
                    </InsertItemTemplate>
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
                <asp:TemplateField HeaderText="产品图片" SortExpression="ProdImage">
                    <EditItemTemplate>
                        <asp:TextBox ID="TextBox1" runat="server" Text='<%# Bind("ProdImage") %>'></asp:TextBox>
                    </EditItemTemplate>
                    <InsertItemTemplate>
                        <asp:FileUpload ID="FileUpload1" runat="server" />
                    </InsertItemTemplate>
                    <ItemTemplate>
                        <asp:Label ID="Label1" runat="server" Text='<%# Bind("ProdImage") %>'></asp:Label>
                    </ItemTemplate>
                    <HeaderStyle HorizontalAlign="Right" VerticalAlign="Middle" />
                </asp:TemplateField>
                <asp:TemplateField HeaderText="产品简介" SortExpression="ProdDesc">
                    <EditItemTemplate>
                        <asp:TextBox ID="TextBox2" runat="server" Text='<%# Bind("ProdDesc") %>'></asp:TextBox>
                    </EditItemTemplate>
                    <InsertItemTemplate>
                        <asp:TextBox ID="TextBox2" runat="server" Text='<%# Bind("ProdDesc") %>' TextMode="MultiLine"></asp:TextBox>
                    </InsertItemTemplate>
                    <ItemTemplate>
                        <asp:Label ID="Label2" runat="server" Text='<%# Bind("ProdDesc") %>'></asp:Label>
                    </ItemTemplate>
                    <HeaderStyle HorizontalAlign="Right" VerticalAlign="Middle" />
                </asp:TemplateField>
                <asp:CheckBoxField DataField="ProdFirstShow" HeaderText="在首页" SortExpression="ProdFirstShow" >
                <HeaderStyle HorizontalAlign="Right" VerticalAlign="Middle" />
                </asp:CheckBoxField>
                <asp:CommandField ShowInsertButton="True" ItemStyle-HorizontalAlign="Center" ItemStyle-VerticalAlign="Middle" >
<ItemStyle HorizontalAlign="Center" VerticalAlign="Middle"></ItemStyle>
                </asp:CommandField>
            </Fields>
            <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
            <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" HorizontalAlign="Right" VerticalAlign="Middle" />
            <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
            <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
        </asp:DetailsView>
        <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" OnInserted="ObjectDataSource1_Inserted" SelectMethod="FindProducts" TypeName="Ep229ProductBLL" DataObjectTypeName="Ep229Product" InsertMethod="AddProduct">
        </asp:ObjectDataSource>
       
</asp:Content>
