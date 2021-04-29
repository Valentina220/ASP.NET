<%@ Page Title="Add product" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ProductCreate.aspx.cs" Inherits="WingtipToys.ProductCreate" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <h1>Add new product</h1>
    <div runat="server" ID="CreateProductForm">
        <asp:Label ID="LabelName" runat="server" AssociatedControlID="prodName" Text="Name:"></asp:Label>
        <br />     
        <asp:TextBox ID="ProdName" runat="server" Width="190px"></asp:TextBox>
        <asp:RequiredFieldValidator ID="NameValidator" runat="server" ControlToValidate="prodName" ErrorMessage="Category name is required" Display="Dynamic"></asp:RequiredFieldValidator>
        <br />

        <asp:Label ID="Price" runat="server" AssociatedControlID="Price" Text="Price:"></asp:Label>
        <br />
        <asp:TextBox ID="PriceInput" runat="server" Width="190px"></asp:TextBox>
        <asp:RangeValidator Type="Currency" ID="PriceValidator" runat="server" ControlToValidate="PriceInput" ErrorMessage="Price should be grater then zero. Maximum price is 600$" MaximumValue="600,00" MinimumValue="0,10" Display="Dynamic"></asp:RangeValidator>
        <asp:RequiredFieldValidator ID="PriceRequiredValidator" runat="server" ControlToValidate="PriceInput" EnableTheming="True" ErrorMessage="Price is required" Display="Dynamic"></asp:RequiredFieldValidator>
        <br />
        <br />

        <asp:Label ID="LabelCategory" runat="server" AssociatedControlID="Category" Text="Category:"></asp:Label>           
        <asp:DropDownList ID="Category" runat="server" Height="20px" Width="120px" SelectMethod="GetCategories" DataTextField="CategoryName"></asp:DropDownList>
        <asp:RequiredFieldValidator ID="CategoryFieldValidator" runat="server" ControlToValidate="Category" ErrorMessage="Category is required" Display="Dynamic"></asp:RequiredFieldValidator>
        <br />
        <br />

        <asp:Label ID="DescriptionLabel" runat="server" AssociatedControlID="Description" Text="Description:"></asp:Label>
        <br />
        <textarea ID="Description" name="S1" runat="server"></textarea>
        <asp:RegularExpressionValidator ID="DescriptionLengthValidator" runat="server" ControlToValidate="Description" ErrorMessage="Description should be maximum 500 symbols long" ValidationExpression="^.{0,500}$"></asp:RegularExpressionValidator>
        <br />

        <asp:Label ID="LabelImg" runat="server" AssociatedControlID="Image" Text="Product image URL:"></asp:Label>
        <br />
        <asp:TextBox ID="Image" runat="server" Width="190px"></asp:TextBox>
        <asp:RegularExpressionValidator ID="urlExpressionValidator" runat="server" ControlToValidate="Image" ValidationExpression="\b(https?|ftp):\/\/[-A-Z0-9+&@#\/%?=~_|!:,.;]*[-A-Z0-9+&@#\/%=~_|]" ErrorMessage="Path is invalid"></asp:RegularExpressionValidator>
        <br />

        <asp:Button ID="ButtonProduct" runat="server" Width="130px" Text="Create product" OnClick="ButtonProduct_Click"/>    
        <asp:ValidationSummary ID="ValidationSummary1" runat="server" />
    </div>

        <div runat="server" ID="SuccessBlock" Visible="False">
        <h2>New product<b><asp:Literal ID="MesageCategoryName" runat="server"></asp:Literal>&nbsp;</b>was successfully added to our store. You could <a href="~/ProductList" runat="server">check catalog</a></h2>
    </div>

</asp:Content>
