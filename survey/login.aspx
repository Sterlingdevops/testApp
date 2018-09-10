<%@ Page Language="C#" MasterPageFile="~/login.master" AutoEventWireup="true" CodeFile="login.aspx.cs" Inherits="login" Title="Survey | Login" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<div class="myFrm" style="margin:120px auto; width:400px;">
    <spa:formTop ID="formTop1" runat="server" />
    
    
    <spa:infoBar ID="ibox" runat="server" />
    <h3>Login with your Sterling Username and Password</h3>
    <div id="spacedown"></div>
    <table width="100%" cellpadding="4" cellspacing="0">
    <tr>
        <th rowspan="2" class="tdpadding">
            </th>
    <th class="flatthleft">Username:</th>
    <td class="tdpadding">
        <asp:TextBox ID="txtUne" runat="server" ToolTip="Enter your Sterling username"></asp:TextBox></td>
    </tr>
    <tr>
    <th class="flatthleft">Password:</th>
    <td class="tdpadding">
        <asp:TextBox ID="txtPwd" runat="server" TextMode="Password" ToolTip="Enter your Sterling password"></asp:TextBox></td>
    </tr>
    <tr>
        <th colspan="2">
            &nbsp;</th>
    <td>
        <asp:Button ID="btnLogin" runat="server" Text="Submit" OnClick="btnLogin_Click" /></td>
    </tr>
    </table>
    
     </div>
   <spa:formBase ID="formBase1" runat="server" />
  
</asp:Content>

