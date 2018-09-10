<%@ Page Language="C#" MasterPageFile="~/login.master" AutoEventWireup="true" CodeFile="compulsory.aspx.cs" Inherits="compulsory" Title="Untitled Page" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
  <div style="margin:0px auto; width:100%; margin-top:12px; font-size:12px; ">
<spa:formTop ID="formTop1" runat="server" />
  <spa:infoBar ID="ibox" runat="server" />
<table width="100%" border="0">
  <tr>
    <td valign="top" colspan="2">
   
      <asp:Panel ID="Panel1" runat="server" Visible ="true" Width="994px">
    <div id="tabs">
    <ul>
      <li><a href="#fragment-2"><span>People-Staff</span></a></li><li><a href="#fragment-3"><span>Process-Problem Handling</span></a></li><li><a href="#fragment-4"><span>System-Communications/feedback</span></a></li><li><a href="#fragment-5"><span>Critical areas for change</span></a></li></ul>
      
    <div id="fragment-2">
    <h3>People-Staff</h3>
    
    <table width="100%" border="0" class="myFrmA" cellpadding="4">
          <tr>
            <td style="width:643px">
                <strong></strong></td>
            <td><strong>Rating Scale</strong></td>
          </tr>
          <tr>
            <td valign="top" style="width: 643px">
            <div class="scrolla">
                Knowledgeable - <em>understanding of their role/responsibility</em></div></td>
            <td valign="top">
            <div class="scrolla">
                <asp:DropDownList ID="ddlknowledge" runat="server">
                </asp:DropDownList></div></td>
          </tr>
        <tr>
            <td valign="top" style="width: 643px">
                Helpful - <em>resourcefulness of the staff</em></td>
            <td valign="top">
                <asp:DropDownList ID="ddlhelpful" runat="server">
                </asp:DropDownList></td>
        </tr>
        <tr>
            <td style="width: 643px">Courteous - <em>attitude</em></td>
            <td>
                <asp:DropDownList ID="ddlcourteous" runat="server">
                </asp:DropDownList></td>
        </tr>
    </table>
    </div>
    <div id="fragment-3">
    <h3>Process</h3>
    <table width="100%" border="0" class="myFrmA" cellpadding="4">
          <tr>
            <td style="width:645px">
                </td>
            <td>
                <strong>Rating Scale</strong></td>
          </tr>
          <tr>
            <td valign="top" style="width: 645px">
            <div class="scrolla">
                Responsiveness - <em>efficiency of handling requests</em></div>
            </td>
            <td valign="top">
            <div class="scrolla">
                <asp:DropDownList ID="ddlresponsesive" runat="server">
                </asp:DropDownList></div>        </td>
          </tr>
        <tr>
            <td style="width: 645px" valign="top">
                Timeliness - <em>quick response to issues</em></td>
            <td valign="top">
                <asp:DropDownList ID="ddltimeliness" runat="server">
                </asp:DropDownList></td>
        </tr>
        <tr>
            <td valign="top" style="width: 645px">
                Ease - <em>was your problem handled skillfully?</em></td>
            <td valign="top">
                <asp:DropDownList ID="ddlease" runat="server">
                </asp:DropDownList></td>
        </tr>
        </table>
     </div>
     
      <div id="fragment-4">
    <h3>System</h3>
    <table width="100%" border="0" class="myFrmA" cellpadding="4">
          <tr>
            <td style="width:649px">
                </td>
            <td>
                <strong>Rating Scale</strong></td>
          </tr>
          <tr>
            <td valign="top" style="width: 649px">
            <div class="scrolla">
                Clarify - <em>the effectiveness of communication or ease of understanding of information</em></div>
            </td>
            <td valign="top">
            <div class="scrolla">
                <asp:DropDownList ID="ddlclarify" runat="server">
                </asp:DropDownList></div>        </td>
          </tr>
        <tr>
            <td style="width: 649px" valign="top">
                Content - <em>the quality of feedback</em></td>
            <td valign="top">
                <asp:DropDownList ID="ddlcontent" runat="server">
                </asp:DropDownList></td>
        </tr>
        <tr>
            <td valign="top" style="width: 649px">
                Access - <em>ease of sourcing information</em></td>
            <td valign="top">
                <asp:DropDownList ID="ddlaccess" runat="server">
                </asp:DropDownList></td>
        </tr>
        </table>
     </div>
     
     <div id="fragment-5">
    <h3>Critical</h3>
    <table width="100%" border="0" class="myFrmA" cellpadding="4">
          <tr>
            <td style="width:650px">
                </td>
            <td>
                <strong>Rating Scale</strong></td>
          </tr>
          <tr>
            <td valign="top" style="width: 650px">
            <div class="scrolla">
                What is the most critical attribute you would like to see changed in this department</div>
            </td>
            <td valign="top">
            <div class="scrolla">
                <asp:DropDownList ID="ddlcriticalattri" runat="server">
                    <asp:ListItem Value="-1" Selected="True">Please select a critical attribute</asp:ListItem>
                    <asp:ListItem Value="Competence">Competence</asp:ListItem>
                    <asp:ListItem Value="Teamwork">Teamwork</asp:ListItem>
                    <asp:ListItem Value="Communication">Communication</asp:ListItem>
                    <asp:ListItem Value="Attitude">Attitude</asp:ListItem>
                    <asp:ListItem Value="Responsibility">Responsibility</asp:ListItem>
                </asp:DropDownList></div>        </td>
          </tr>
        <tr>
            <td style="width: 650px" valign="top">
                What is the most critical success factor that can help this department improve</td>
            <td valign="top">
                <asp:DropDownList ID="ddlcriticalsucc" runat="server">
                    <asp:ListItem Value="-1" Selected="True">Please select a factor</asp:ListItem>
                    <asp:ListItem Value="Staff">Staff</asp:ListItem>
                    <asp:ListItem Value="Leadership">Leadership</asp:ListItem>
                    <asp:ListItem Value="Infrastructure">Infrastructure</asp:ListItem>
                    <asp:ListItem Value="Automation">Automation</asp:ListItem>
                    <asp:ListItem Value="Discipline">Discipline</asp:ListItem>
                    <asp:ListItem Value="Other">Other</asp:ListItem>
                </asp:DropDownList></td>
        </tr>
        <tr>
            <td style="width: 650px" valign="top">
                Overall satisfaction with service received</td>
            <td valign="top">
                <asp:DropDownList ID="ddloverall" runat="server">
                
                </asp:DropDownList></td>
        </tr>
        <tr>
            <td style="width: 650px; height: 15px" valign="top">
                Comments</td>
            <td style="height: 15px" valign="top">
                <asp:TextBox ID="TextBox1" runat="server" Height="58px" TextMode="MultiLine" MaxLength="2000"></asp:TextBox></td>
        </tr>
        <tr>
            <td style="width: 650px; height: 15px" valign="top">
            </td>
            <td style="height: 15px" valign="top">
                <asp:Button ID="Button1" runat="server" Text="Button" /></td>
        </tr>
        </table>
     </div>
     
    </div>
    </asp:Panel>
    </td>
     
    
  </tr>
</table>

<spa:formBase ID="formBase1" runat="server" />

<script type="text/javascript">
	$(function() {
		$( "#tabs" ).tabs();
	});
	
	function chooseTab(itm)
	{
	    var $tabs = $('#tabs').tabs(); // first tab selected
        $('#tablink' + itm).click(function() { // bind click event to link
            $tabs.tabs('select', itm); // switch to third tab
            return false;
        });
	}
	</script>
</div>
</asp:Content>

