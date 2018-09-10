<%@ Page Language="C#" MasterPageFile="~/admin/login.master" AutoEventWireup="true" CodeFile="cSuccess.aspx.cs" Inherits="admin_cSuccess" Title="Survey | Critical Success" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server"><div id="report">
<table width="100%" border="0" class="tablereport">
  <tr>
    <td class="tablereporttd">
      <div class="ctrlize"> <p> &nbsp;INTERNAL CUSTOMER SATISFACTION SURVEY-Critical Success Report</p></div></td>
  </tr>
  <tr>
    <td >

        <asp:Button ID="Button1" runat="server" Text="Export to Excel" Enabled="False" OnClick="Button1_Click" />&nbsp;<br />
       <div id="center">
           &nbsp;&nbsp;
        </div>
        <asp:GridView ID="grddisplay" runat="server" AutoGenerateColumns="False" CellPadding="4"
            DataSourceID="SqlDataSource1" ForeColor="#333333" Width="90%">
            <RowStyle BackColor="#FFFBD6" HorizontalAlign="Center" ForeColor="#333333" />
            <Columns>
                <asp:BoundField DataField="DeptRated" HeaderText="Departments" SortExpression="DeptRated" />
                <asp:TemplateField>
                    <HeaderTemplate>
                    Staff
                    </HeaderTemplate>
                    <ItemTemplate>
                  <%#  getStaff(Convert.ToString(DataBinder.Eval(Container, "DataItem.DeptRated")))%>
                    </ItemTemplate>
                </asp:TemplateField>
                    <asp:TemplateField>
                    <HeaderTemplate>
                    Leadership
                    </HeaderTemplate>
                    <ItemTemplate>
                  <%#  getLeadership(Convert.ToString(DataBinder.Eval(Container, "DataItem.DeptRated")))%>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField>
                    <HeaderTemplate>
                    Infrastructure
                    </HeaderTemplate>
                    <ItemTemplate>
                  <%#  getInfrastructure(Convert.ToString(DataBinder.Eval(Container, "DataItem.DeptRated")))%>
                    </ItemTemplate>
                </asp:TemplateField>
                 <asp:TemplateField>
                    <HeaderTemplate>
                    Automation
                    </HeaderTemplate>
                    <ItemTemplate>
                  <%#  getAutomation(Convert.ToString(DataBinder.Eval(Container, "DataItem.DeptRated")))%>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField>
                    <HeaderTemplate>
                    Discipline
                    </HeaderTemplate>
                    <ItemTemplate>
                  <%#  getDiscipline(Convert.ToString(DataBinder.Eval(Container, "DataItem.DeptRated")))%>
                    </ItemTemplate>
                </asp:TemplateField>
            </Columns>
            <FooterStyle BackColor="#990000" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="#FFCC66" ForeColor="#333333" HorizontalAlign="Center" />
            <SelectedRowStyle BackColor="#FFCC66" Font-Bold="True" ForeColor="Navy" />
            <HeaderStyle BackColor="#990000" Font-Bold="True" ForeColor="White" HorizontalAlign="Left" />
            <AlternatingRowStyle BackColor="White" />
        </asp:GridView>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:dbConn %>"
            SelectCommand="spd_GetDistincDept" SelectCommandType="StoredProcedure"></asp:SqlDataSource>
        <br />
        <asp:Label ID="lblmsg" runat="server" Font-Size="11px" ForeColor="Blue"></asp:Label>
        </td>
  </tr>
  <tr>
    <td class="tablereporttd">&nbsp;
    </td>
  </tr>
</table>
</div>

</asp:Content>

