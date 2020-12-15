<%@ Page Title="About" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="About.aspx.cs" Inherits="WebPage.About" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server" ViewStateMode="Inherit">
    <h2 style="color: #FF0000; font-size: x-large; font-weight: normal; font-style: italic"><%: Label3.Text %>!</h2>

    <p>
        <asp:Label ID="Label2" runat="server" ForeColor="#FE281D" Text="Видно Только для Админа" Visible="False"></asp:Label>
    </p>
    <p>&nbsp;</p>
    <p>

    </p>
    <p>
        <asp:Label ID="Label1" runat="server" Text="Label" ForeColor="Blue"></asp:Label>
        <asp:Label ID="Label3" runat="server" Text="" Visible="False"></asp:Label>
    </p>
    <p>
        &nbsp;</p>
    <p>
        &nbsp;</p>
    <p>
        c&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Width="28px" />
        <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Width="25px" />
        <asp:Button ID="Button3" runat="server" OnClick="Button3_Click" Width="27px" />
    </p>
    <p>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;<asp:Button ID="Button4" runat="server" OnClick="Button4_Click" Width="29px" />
        <asp:Button ID="Button5" runat="server" OnClick="Button5_Click" Width="26px" />
        <asp:Button ID="Button6" runat="server" OnClick="Button6_Click" Width="25px" />
    </p>
    <p>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;<asp:Button ID="Button7" runat="server" OnClick="Button7_Click" Width="27px" />
        <asp:Button ID="Button8" runat="server" OnClick="Button8_Click" Width="26px" />
        <asp:Button ID="Button9" runat="server" OnClick="Button9_Click" Width="27px" />
    </p>
</asp:Content>
