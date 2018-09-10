<%@ Page Language="C#" MasterPageFile="~/login.master" AutoEventWireup="true" CodeFile="myprofile2.aspx.cs" Inherits="myprofile2" Title="Survey | Rate a Department" %>
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
      <li><a href="#fragment-2"><span>People</span></a></li><li><a href="#fragment-3"><span>Process</span></a></li><li><a href="#fragment-4"><span>System</span></a></li><li><a href="#fragment-5"><span>Area of Change</span></a></li></ul>
      
    <div id="fragment-2">
    <h3>People</h3>
    
    <table width="100%" border="0" class="myFrmA" cellpadding="4">
          <tr>
            <td style="width:643px">
                <strong>
                    <asp:Label ID="Label1" runat="server" Text=" "></asp:Label></strong></td>
            <td><strong>Rating Scale</strong></td>
          </tr>
          <tr>
            <td valign="top" style="width: 643px">
            <div class="scrolla">
                Knowledgeable - <em>Confidently demonstrates understanding of our business and offer solutions 
</em></div></td>
            <td valign="top">
            <div class="scrolla">
                <asp:DropDownList ID="DropDownList1" runat="server">
                </asp:DropDownList></div></td>
          </tr>
        <tr>
            <td valign="top" style="width: 643px">
                Helpful - <em>have patience to understand customers needs and treats customer like a respected partner
</em></td>
            <td valign="top">
                <asp:DropDownList ID="DropDownList2" runat="server">
                </asp:DropDownList></td>
        </tr>
        <tr>
            <td style="width: 643px; height: 35px;">Courteous - <em>maintain a friendly approachable disposition that engenders a warm relationship. Manage expectations in a courteous, personal and friendly manner
</em></td>
            <td style="height: 35px">
                <asp:DropDownList ID="DropDownList3" runat="server">
                </asp:DropDownList></td>
        </tr>
    </table>
    </div>
    <div id="fragment-3">
    <h3>Process - Problem Handling</h3>
    <table width="100%" border="0" class="myFrmA" cellpadding="4">
          <tr>
            <td style="width:643px">
                </td>
            <td>
                <strong>Rating Scale</strong></td>
          </tr>
          <tr>
            <td valign="top" style="width: 643px">
            <div class="scrolla">
                Responsiveness - <em>no silos – works with internal colleagues to overcome around obstacles and find ways to deliver without frustration
</em></div>
            </td>
            <td valign="top">
            <div class="scrolla">
                <asp:DropDownList ID="DropDownList4" runat="server">
                </asp:DropDownList></div>        </td>
          </tr>
        <tr>
            <td style="width: 643px" valign="top">
                Timeliness - <em>how quickly your requests are responded to. Turnaround time
</em></td>
            <td valign="top">
                <asp:DropDownList ID="DropDownList5" runat="server">
                </asp:DropDownList></td>
        </tr>
        <tr>
            <td valign="top" style="width: 643px">
                Feedback - <em>provide information updates and feedback on issues. 
</em></td>
            <td valign="top">
                <asp:DropDownList ID="DropDownList6" runat="server">
                </asp:DropDownList></td>
        </tr>
        </table>
     </div>
     
      <div id="fragment-4">
    <h3>System - Communications/feedback</h3>
    <table width="100%" border="0" class="myFrmA" cellpadding="4">
          <tr>
            <td style="width:641px">
                </td>
            <td>
                <strong>Rating Scale</strong></td>
          </tr>
          <tr>
            <td valign="top" style="width: 641px">
            <div class="scrolla">
                Ownership - <em>shows perseverance and responsibility in delivering to the client regardless of obstacles

</em></div>
            </td>
            <td valign="top">
            <div class="scrolla">
                <asp:DropDownList ID="DropDownList7" runat="server">
                </asp:DropDownList></div>        </td>
          </tr>
        <tr>
            <td style="width: 641px; height: 23px;" valign="top">
                Professionalism - <em>projects an image of integrity and competence. Professional appearance and demeanor
</em></td>
            <td valign="top" style="height: 23px">
                <asp:DropDownList ID="DropDownList8" runat="server">
                </asp:DropDownList></td>
        </tr>
        <tr>
            <td valign="top" style="width: 641px">
                Teamwork - <em>no silos – works with internal colleagues to overcome around obstacles and find ways to deliver without frustration
</em></td>
            <td valign="top">
                <asp:DropDownList ID="DropDownList9" runat="server">
                </asp:DropDownList></td>
        </tr>
        </table>
     </div>
     
     <div id="fragment-5">
    <h3>Critical areas for change</h3>
    <table width="100%" border="0" class="myFrmA" cellpadding="4">
          <tr>
            <td style="width:641px">
                </td>
            <td>
                <strong>Rating Scale</strong></td>
          </tr>
          <tr>
            <td valign="top" style="width: 641px; height: 23px;">
            <div class="scrolla">
                What is the most critical attribute you would like to see changed in this department</div>
            </td>
            <td valign="top" style="height: 23px">
            <div class="scrolla">
                <asp:DropDownList ID="DropDownList10" runat="server">
                <asp:ListItem Selected="True" Value="-1">- Select a critical attribute -</asp:ListItem>
                <asp:ListItem  Value="Competence"> Competence</asp:ListItem>
                <asp:ListItem  Value="Team Work">Team Work</asp:ListItem>
                 <asp:ListItem  Value="Communication">Communication</asp:ListItem>
                  <asp:ListItem  Value="Attitude">Attitude</asp:ListItem>
                  <asp:ListItem  Value="Responsibility">Responsibility</asp:ListItem>
                </asp:DropDownList></div>        </td>
          </tr>
        <tr>
            <td style="width: 641px" valign="top">
                What is the most critical success factor that can help this department improve</td>
            <td valign="top">
                <asp:DropDownList ID="DropDownList11" runat="server">
                    <asp:ListItem Selected="True" Value="-1">- Select a Factor-</asp:ListItem>
                <asp:ListItem  Value="Staff"> Staff</asp:ListItem>
                <asp:ListItem  Value="Leadership">Leadership</asp:ListItem>
                 <asp:ListItem  Value="Infrastructure">Infrastructure</asp:ListItem>
                  <asp:ListItem  Value="Automation">Automation</asp:ListItem>
                  <asp:ListItem  Value="Discipline">Discipline</asp:ListItem>
                  <asp:ListItem  Value="Other">Other</asp:ListItem>
                </asp:DropDownList></td>
        </tr>
        <tr>
            <td style="width: 641px" valign="top">
                Overall satisfaction with service received</td>
            <td valign="top">
                <asp:DropDownList ID="DropDownList12" runat="server">
             
                </asp:DropDownList></td>
        </tr>
        <tr>
            <td style="width: 641px; height: 15px" valign="top" align="right">
                <span style="color:#D62B11;"><strong>Comments</strong></span></td>
            <td style="height: 15px" valign="top">
                <asp:TextBox ID="TextBox1" runat="server" Height="58px" TextMode="MultiLine"></asp:TextBox></td>
        </tr>
        <tr>
            <td style="width: 641px; height: 15px" valign="top">
            </td>
            <td style="height: 15px" valign="top">
                <asp:Button ID="rateBtn" runat="server" Text="Make Rating" OnClick="rateBtn_Click" /></td>
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

