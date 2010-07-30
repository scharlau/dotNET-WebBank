<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true"
    CodeBehind="Default.aspx.cs" Inherits="WebBank._Default" %>
    
<asp:Content ID="HeaderContent" runat="server" ContentPlaceHolderID="HeadContent">
</asp:Content>
<asp:Content ID="BodyContent" runat="server" ContentPlaceHolderID="MainContent">
    <h2>
        Welcome to the Web Bank
    </h2>
    
    <p>
     Your Balance is <asp:Label ID="Label1" runat="server"></asp:Label>
    </p>
    <p>Transfer xx to account yy </p>
  
</asp:Content>
