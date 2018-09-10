<%@ Page Language="C#" MasterPageFile="~/admin/login.master" AutoEventWireup="true" CodeFile="addadminuser.aspx.cs" Inherits="admin_addadminuser" Title="Admin | Add admin User" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<div class="myFrm" style="margin:120px auto; width:497px;">
    <spa:formTop ID="formTop1" runat="server" />
    
    <h3>
        Create Admin User</h3>
    <spa:infoBar ID="ibox" runat="server" />
    
    <table width="100%" cellpadding="4" cellspacing="0">
    <tr>
        <th rowspan="1" class="tdpadding">
            </th>
    <th class="flatthleft">
        Enter the Logon name for the user:</th>
    <td class="tdpadding">
        <asp:TextBox ID="txtUne" runat="server"></asp:TextBox></td>
    </tr>
    <tr>
        <th colspan="2">
            &nbsp;</th>
    <td>
        <asp:Button ID="btnLogin" runat="server" Text="Submit" OnClick="btnLogin_Click" /></td>
    </tr>
    </table>
    
    
   <spa:formBase ID="formBase1" runat="server" />
   </div>
</asp:Content>

