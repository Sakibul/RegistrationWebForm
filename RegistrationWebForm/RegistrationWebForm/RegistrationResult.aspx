<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="RegistrationResult.aspx.cs" Inherits="RegistrationWebForm.RegistrationResult" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <h1>Registration successful</h1>
    <asp:Panel ID="userInfoPanel" runat="server">
        <table cellpadding="3" border="0">
            <tr>
                <td>Name:</td>
                <td>
                    <asp:Label ID="firstNameLabel" runat="server" />
                    <asp:Label ID="lastNameLabel" runat="server" />
                </td>
            </tr>
            <tr>
                <td valign="top">address:</td>
                <td>
                    <asp:Label ID="addressLabel" runat="server" /><br />
                    <asp:Label ID="cityLabel" runat="server" />,
            <asp:Label ID="stateOrProvinceLabel" runat="server" />
                    <asp:Label ID="zipCodeLabel" runat="server" /><br />
                    <asp:Label ID="countryLabel" runat="server" />
                </td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td>
                    <!--
                        <asp:Button ID="changeInfoButton" runat="server" Text="Change user information"/>
                    -->
                </td>
            </tr>
        </table>
    </asp:Panel>

</asp:Content>
