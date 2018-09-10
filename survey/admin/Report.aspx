<%@ Page Language="C#" MasterPageFile="~/admin/login.master" AutoEventWireup="true" CodeFile="Report.aspx.cs" Inherits="admin_Report" Title="Survey | Reports" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<div id="report">
<table width="100%" border="0" class="tablereport">
  <tr>
    <td class="tablereporttd">
      <div class="ctrlize"> <p> 
      
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:dbConn %>"
            SelectCommand="spd_SurveyReport" SelectCommandType="StoredProcedure"></asp:SqlDataSource>
    A DETAILED REPORT OF THE INTERNAL CUSTOMER SATISFACTION SURVEY</p></div></td>
  </tr>
  <tr>
    <td >

        <asp:Button ID="Button1" runat="server" Text="Export to Excel" Enabled="False" OnClick="Button1_Click" />
    <asp:GridView ID="grddisplay" runat="server" CellPadding="4" ForeColor="#333333" Width="100%" AutoGenerateColumns="False" DataSourceID="SqlDataSource1">
        <RowStyle BackColor="#FFFBD6" ForeColor="#333333" />
        <FooterStyle BackColor="#990000" Font-Bold="True" ForeColor="White" />
        <PagerStyle BackColor="#FFCC66" ForeColor="#333333" HorizontalAlign="Center" />
        <SelectedRowStyle BackColor="#FFCC66" Font-Bold="True" ForeColor="Navy" />
        <HeaderStyle BackColor="#990000" Font-Bold="True" ForeColor="White" />
        <AlternatingRowStyle BackColor="White" />
        <Columns>
            <asp:BoundField DataField="DEPARTMENT" HeaderText="DEPARTMENT" SortExpression="DEPARTMENT" />
            <asp:BoundField DataField="HITS" HeaderText="HITS" ReadOnly="True" SortExpression="HITS" />
            <asp:BoundField DataField="KNW" HeaderText="KNW" ReadOnly="True" SortExpression="KNW" />
            <asp:BoundField DataField="HELP" HeaderText="HELP" ReadOnly="True" SortExpression="HELP" />
            <asp:BoundField DataField="CRT" HeaderText="CRT" ReadOnly="True" SortExpression="CRT" />
            <asp:BoundField DataField="TOTAL" HeaderText="TOTAL" ReadOnly="True" SortExpression="TOTAL" />
            <asp:BoundField DataField="MAXSCORE" HeaderText="MAXSCORE" ReadOnly="True" SortExpression="MAXSCORE" />
            <asp:BoundField DataField="%SCORE" HeaderText="%SCORE" ReadOnly="True" SortExpression="%SCORE" />
            <asp:BoundField DataField="RESP" HeaderText="RESP" ReadOnly="True" SortExpression="RESP" />
            <asp:BoundField DataField="TME" HeaderText="TME" ReadOnly="True" SortExpression="TME" />
            <asp:BoundField DataField="EAS" HeaderText="EAS" ReadOnly="True" SortExpression="EAS" />
            <asp:BoundField DataField="TOTAL1" HeaderText="TOTAL1" ReadOnly="True" SortExpression="TOTAL1" />
            <asp:BoundField DataField="MAXSCORE1" HeaderText="MAXSCORE" ReadOnly="True" SortExpression="MAXSCORE1" />
            <asp:BoundField DataField="%SCORE1" HeaderText="%SCORE1" ReadOnly="True" SortExpression="%SCORE1" />
            <asp:BoundField DataField="CLA" HeaderText="CLA" ReadOnly="True" SortExpression="CLA" />
            <asp:BoundField DataField="CNT" HeaderText="CNT" ReadOnly="True" SortExpression="CNT" />
            <asp:BoundField DataField="ACC" HeaderText="ACC" ReadOnly="True" SortExpression="ACC" />
            <asp:BoundField DataField="TOTAL2" HeaderText="TOTAL2" ReadOnly="True" SortExpression="TOTAL2" />
            <asp:BoundField DataField="MAXSCORE2" HeaderText="MAXSCORE" ReadOnly="True" SortExpression="MAXSCORE2" />
            <asp:BoundField DataField="%SCORE2" HeaderText="%SCORE2" ReadOnly="True" SortExpression="%SCORE2" />
           
            <asp:BoundField DataField="MAXSCORE3" HeaderText="MAXSCORE" ReadOnly="True" SortExpression="MAXSCORE3" />
            <asp:BoundField DataField="%SCORE3" HeaderText="RANKING" ReadOnly="True" SortExpression="%SCORE3" dataformatstring="{0:F}"/>
        </Columns>
        </asp:GridView>
        <asp:Label ID="lblmsg" runat="server" Font-Size="11px" ForeColor="Blue"></asp:Label>
        </td>
  </tr>
  <tr>
    <td class="tablereporttd">&nbsp;</td>
  </tr>
</table>
</div>
</asp:Content>

