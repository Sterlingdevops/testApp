<%@ Page Language="C#" MasterPageFile="~/admin/login.master" AutoEventWireup="true" CodeFile="managerating.aspx.cs" Inherits="admin_managerating" Title="Untitled Page" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<script type="text/javascript">
function ResultStatus(Refid)
{

    url = "../sync/ratingstatus.aspx?Refid=" + Refid + "&r=" + rando(); 
    //alert(url);
    loadResp2(url,Refid);
    
}
function loadResp2(fragment_url,Refid) {
    xmlhttp.open("GET", fragment_url);
    xmlhttp.onreadystatechange = function() {
        if (xmlhttp.readyState == 4 && xmlhttp.status == 200) {
            var nomstatus = xmlhttp.responseText;
            
            if(nomstatus == 'False')
            {
                document.getElementById("result-" + Refid).src = "../images/152.png";
            }
            else
            {
                document.getElementById("result-" + Refid).src = "../images/151.png";
            }
        }
    }
    xmlhttp.send(null);
}

</script>

<div class="myFrm" style="margin:120px auto; width:497px;">
    <spa:formTop ID="formTop1" runat="server" />
    
    <h3>
        Enable / Disable Rating</h3>
    
    <table width="100%" cellpadding="4" cellspacing="0">
    <tr>
       <td style=" padding:4px;"> 
       <div id="Activate">
       <asp:GridView ID="GridView1" runat="server" CellPadding="4" ForeColor="#333333" AutoGenerateColumns="False" DataSourceID="SqlDataSource1" Width="100%">
        <RowStyle BackColor="#FFFBD6" ForeColor="#333333" />
        <FooterStyle BackColor="#990000" Font-Bold="True" ForeColor="White" />
        <PagerStyle BackColor="#FFCC66" ForeColor="#333333" HorizontalAlign="Center" />
        <SelectedRowStyle BackColor="#FFCC66" Font-Bold="True" ForeColor="Navy" />
        <HeaderStyle BackColor="#990000" Font-Bold="True" ForeColor="White" />
        <AlternatingRowStyle BackColor="White" />
           <Columns>
             
                      <asp:TemplateField>
                    <HeaderTemplate>
                      Rating Status
                    </HeaderTemplate>
                    <ItemTemplate>
                  <%#  getResultStatus(Convert.ToBoolean(DataBinder.Eval(Container, "DataItem.statusflag")), Convert.ToString(DataBinder.Eval(Container, "DataItem.Refid")))%>
                    </ItemTemplate>
                    </asp:TemplateField>
           </Columns>
    </asp:GridView>
           <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:dbConn %>"
               SelectCommand="spd_GetRatingStatus" SelectCommandType="StoredProcedure"></asp:SqlDataSource>
       </div></td>
    </tr>
    </table>
    
    
   <spa:formBase ID="formBase1" runat="server" />
   
   </div>
</asp:Content>

