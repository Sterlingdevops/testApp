<%@ Page Language="C#" MasterPageFile="~/login.master" AutoEventWireup="true" CodeFile="deptRatedbyme.aspx.cs" Inherits="deptRatedbyme" Title="Survey | Department Rated By Me" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<div id="myFrm" style="margin:0px auto; width:854px; margin-top:12px; font-size:12px; ">
<div class="report">
<spa:formTop ID="formTop1" runat="server" />
  <spa:infoBar ID="ibox" runat="server" />

        <strong style="color:#990000; font-size:12px; padding-bottom:4px;">
                    
                     <ul>
                     
                    <li> <span style="color:#03608B"><strong> Department(s) Rated by You</strong></span></li>
                         <li><span style="color: #03608b"><strong>
                  <asp:Button ID="Button1" runat="server" Text="Export to Excel" OnClick="Button1_Click" /></strong></span></li>
                     </ul>
            </strong>
                    
       <table width="100%" border="0" class="myFrmA" cellpadding="4">
         
          <tr>
              <td colspan="2" rowspan="3">
                      <asp:GridView ID="grddisplay" runat="server" AutoGenerateColumns="False" CellPadding="6"
                          DataSourceID="SqlDataSource1" ForeColor="#333333" Width="100%" Font-Bold="False">
                          <RowStyle BackColor="#FFFBD6" ForeColor="#333333" />
                          <Columns>
                              <asp:BoundField DataField="DeptRated" HeaderText="Department Rated" SortExpression="DeptRated" />
                              <asp:BoundField DataField="comment" HeaderText="Comments" SortExpression="comment" />
                              <asp:BoundField DataField="datedone" HeaderText="Date Added" ReadOnly="True" SortExpression="datedone" />
                          </Columns>
                          <FooterStyle BackColor="#990000" Font-Bold="True" ForeColor="White" />
                          <PagerStyle BackColor="#FFCC66" ForeColor="#333333" HorizontalAlign="Center" />
                          <SelectedRowStyle BackColor="#FFCC66" Font-Bold="True" ForeColor="Navy" />
                          <HeaderStyle BackColor="#990000" Font-Bold="True" ForeColor="White" HorizontalAlign="Left" />
                          <AlternatingRowStyle BackColor="White" />
                      </asp:GridView>
                      <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:dbConn %>"
                          SelectCommand="spd_ViewdeptRated" SelectCommandType="StoredProcedure">
                          <SelectParameters>
                              <asp:SessionParameter Name="username" SessionField="username" Type="String" />
                          </SelectParameters>
                      </asp:SqlDataSource> </td>
          </tr>
          <tr>
          </tr>
           <tr>
           </tr>
           <tr>
               <td style="width: 19px">
              <a href="javascript:history.go(-1)">Back</a>&nbsp;
               </td>
               <td style="width: 355px">
                  </td>
           </tr>
        </table>
        </div>
        
<spa:formBase ID="formBase1" runat="server" />
</div>
</asp:Content>

