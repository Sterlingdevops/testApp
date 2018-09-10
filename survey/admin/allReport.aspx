<%@ Page Language="C#" MasterPageFile="~/admin/login.master" AutoEventWireup="true" CodeFile="allReport.aspx.cs" Inherits="admin_allReport" Title="Survey | Report" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<div id="report">
<table width="100%" border="0" class="tablereport">
  <tr>
    <td class="tablereporttd">
      <div class="ctrlize"> <p> &nbsp;DETAILED REPORT WITH COMMENTS</p></div></td>
  </tr>
  <tr>
    <td >

        <asp:Button ID="Button1" runat="server" Text="Export to Excel" Enabled="False" OnClick="Button1_Click" />&nbsp;<br />
        <asp:GridView ID="grddisplay" runat="server" AutoGenerateColumns="False" CellPadding="4"
            DataSourceID="SqlDataSource1" ForeColor="#333333" Width="100%">
            <RowStyle BackColor="#FFFBD6" ForeColor="#333333" />
            <Columns>
                  <asp:TemplateField>
                    <HeaderTemplate>
                    Staff Name
                    </HeaderTemplate>
                    <ItemTemplate>
                  <%#  getStaffName(Convert.ToString(DataBinder.Eval(Container, "DataItem.username")))%>
                    </ItemTemplate>
                </asp:TemplateField>
                 <asp:TemplateField>
                    <HeaderTemplate>
                    Staff Department
                    </HeaderTemplate>
                    <ItemTemplate>
                  <%#  getStaffDept(Convert.ToString(DataBinder.Eval(Container, "DataItem.username")))%>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField>
                    <HeaderTemplate>
                     Staff Grade
                    </HeaderTemplate>
                    <ItemTemplate>
                  <%#  getStaffGrade(Convert.ToString(DataBinder.Eval(Container, "DataItem.username")))%>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:BoundField DataField="comment" HeaderText="Comment" SortExpression="comment" />
                <asp:BoundField DataField="deptrated" HeaderText="Department Rated" SortExpression="deptrated" />
                <asp:BoundField DataField="datedone" HeaderText="Date Done" SortExpression="datedone" />
            </Columns>
            <FooterStyle BackColor="#990000" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="#FFCC66" ForeColor="#333333" HorizontalAlign="Center" />
            <SelectedRowStyle BackColor="#FFCC66" Font-Bold="True" ForeColor="Navy" />
            <HeaderStyle BackColor="#990000" Font-Bold="True" ForeColor="White" HorizontalAlign="Left" />
            <AlternatingRowStyle BackColor="White" />
        </asp:GridView>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:dbConn %>"
            SelectCommand="spd_GetComments" SelectCommandType="StoredProcedure"></asp:SqlDataSource>
        <br />
        <asp:Label ID="lblmsg" runat="server" Font-Size="11px" ForeColor="Blue"></asp:Label>
        </td>
  </tr>
  <tr>
    <td class="tablereporttd">&nbsp;</td>
  </tr>
</table>
</div>
</asp:Content>

