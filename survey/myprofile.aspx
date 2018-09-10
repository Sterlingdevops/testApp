<%@ Page Language="C#" MasterPageFile="~/login.master" AutoEventWireup="true" CodeFile="myprofile.aspx.cs" Inherits="myprofile" Title="Survey | Profile" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<div id="myFrm" style="margin:0px auto; width:854px; margin-top:12px; font-size:12px; ">
 <div id="noticeboard">
   <p>  <asp:Label ID="lblcount" runat="server"></asp:Label></p></div>
<spa:formTop ID="formTop1" runat="server" />
  <spa:infoBar ID="ibox" runat="server" />

        <h3>
            </h3> <strong style="color:#990000; font-size:12px; padding-bottom:4px;">
                    
                     <ul>
                        <li><span style="color:#D62B11;"><strong> Rating Instruction:</strong></span></li><li><span style="color: #d62b11"></span></li>
                         <br />
                     
                    <li> <span style="color:#03608B"><strong> You can rate Maximum of </strong>
                <asp:Label ID="Label1" runat="server" Text=""></asp:Label>&nbsp; Departments.</span></li><li><span style="color: blue"></span></li>
                <li> <strong><span style="color:#990000">*</span><asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/AddComment.aspx">Add Comment on existing Rating</asp:HyperLink><span style="color:#990000">*</span></strong>
                    | *<asp:HyperLink ID="HyperLink2" runat="server" NavigateUrl="~/deptRatedbyme.aspx">View Department(s) Rated</asp:HyperLink>*</li></ul>
            </strong>
                    
       <table width="100%" border="0" class="myFrmA" cellpadding="4">
          
           <tr>
               <td colspan="2">
               </td>
           </tr>
         
          <tr>
            <td style="width: 324px; height: 23px;"><strong>Please Select a department you want to rate</strong></td>
            <td style="width: 355px; height: 23px"><asp:DropDownList ID="ddldept" runat="server">
                </asp:DropDownList></td>
          </tr>
          <tr>
            <td style="height: 33px; width: 324px;"><strong>Do you Interface with the selected department?</strong></td>
            <td style="height: 33px; width: 355px;">
            <asp:DropDownList ID="decision" runat="server" AutoPostBack="true" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged">
              <asp:ListItem Value="-1"> - Please Select an Option - </asp:ListItem>
              <asp:ListItem Value="1">Yes</asp:ListItem>
              <asp:ListItem Value="0">No</asp:ListItem>
                </asp:DropDownList></td>
          </tr>
           <tr>
               <td style="width: 324px; height: 23px;">
                  <strong>How Often do you interface with them?</strong> </td>
               <td style="height: 23px; width: 355px;">
                   <asp:DropDownList ID="weight" runat="server">
                   <asp:ListItem Value="-1" Selected="true"> - Please Select an Option - </asp:ListItem>
                   <asp:ListItem Value="100">Always</asp:ListItem>
                   <asp:ListItem Value="70">Regularly</asp:ListItem>
                   <asp:ListItem Value="10">Rarely</asp:ListItem>
                   </asp:DropDownList></td>
           </tr>
           <tr>
               <td style="width: 324px">
               </td>
               <td style="width: 355px">
                   <asp:Button ID="proceed" runat="server" Text="Proceed" OnClick="proceed_Click" Enabled="False" /></td>
           </tr>
        </table>
        </div>
<spa:formBase ID="formBase1" runat="server" /></asp:Content>

