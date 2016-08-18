<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="WebFormsExample.Home" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    Home Page<br />
    <br />
    <asp:TextBox ID="txtField1" runat="server" Font-Size="Larger" Height="73px" Width="380px"></asp:TextBox>
    <br />
    <br />
    <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Button" />
    <br />
    <asp:Button ID="btnGoToPage" runat="server" Height="181px" OnClick="btnGoToPage_Click" Text="Go To Page" Width="309px" />
&nbsp;
</asp:Content>
