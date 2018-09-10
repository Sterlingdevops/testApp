<%@ Page Language="C#" MasterPageFile="~/admin/login.master" AutoEventWireup="true" CodeFile="menu.aspx.cs" Inherits="admin_menu" Title="Admin  | Menu " %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<div style="margin:0px auto; width:900px; margin-top:12px;">
<spa:formTop ID="formTop1" runat="server" />
<div style="background-color:#fff;">
<table width="700" border="0" class="tablemenu">
          <tr>
              <td class="tablemenutd" colspan="3" style="border-right: #ccc 1px solid; border-top: #ccc 1px solid;
                  border-left: #ccc 1px solid; border-bottom: #ccc 1px solid">
                  <h2> Admin Menu</h2>
              </td>
          </tr>
    <tr>
        <td class="tablemenutd" style="width:20%;border:1px solid #ccc;" >
            <h2>
                Activate Status</h2>
        </td>
        <td class="tablemenutd" style="width:20%;border:1px solid #ccc;">
         <h2>  Reports</h2></td>
        <td class="tablemenutd" style="border-right: #ccc 1px solid; border-top: #ccc 1px solid;
            border-left: #ccc 1px solid; width: 20%; border-bottom: #ccc 1px solid">
            <h2> Create Admin User</h2></td>
    </tr>
    <tr>
        <td class="tablemenutd" valign="top" style="border:1px solid #ccc;">
          <ul>
            <li>
                <asp:HyperLink ID="hypcreateaward" runat="server" NavigateUrl="~/admin/managerating.aspx">Manage Rating</asp:HyperLink></li><li>
                    </li></ul>
         </td>
        <td class="tablemenutd" valign="top" style="border:1px solid #ccc;">
            <ul>
                <li><asp:HyperLink ID="HyperLink2" runat="server" NavigateUrl="~/admin/Report.aspx">Survey Report</asp:HyperLink></li><li>
                    <asp:HyperLink ID="HyperLink3" runat="server" NavigateUrl="~/admin/cattribute.aspx">Critical Issue Report</asp:HyperLink></li><li>
                        <asp:HyperLink ID="HyperLink4" runat="server" NavigateUrl="~/admin/cSuccess.aspx">Key Success Factor Report</asp:HyperLink></li><li>
                            <asp:HyperLink ID="HyperLink5" runat="server" NavigateUrl="~/admin/allReport.aspx">Download Reports With Comment</asp:HyperLink></li></ul>
        </td>
        <td class="tablemenutd" style="border-right: #ccc 1px solid; border-top: #ccc 1px solid;
            border-left: #ccc 1px solid; border-bottom: #ccc 1px solid" valign="top">
            <ul>
                <li>
                    <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/admin/addadminuser.aspx">Create Admin Users</asp:HyperLink></li></ul>
        </td>
    </tr>
        </table>
        </div>
        <spa:formBase ID="formBase1" runat="server" />
     </div>
</asp:Content>

