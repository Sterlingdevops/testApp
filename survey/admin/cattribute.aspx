<%@ Page Language="C#" MasterPageFile="~/admin/login.master" AutoEventWireup="true" CodeFile="cattribute.aspx.cs" Inherits="admin_cattribute" Title="Survey | Critical Attribute" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<div id="report">
<table width="100%" border="0" class="tablereport">
  <tr>
    <td class="tablereporttd">
      <div class="ctrlize"> <p> &nbsp;INTERNAL CUSTOMER SATISFACTION SURVEY-Critical Issue Report</p></div></td>
  </tr>
  <tr>
    <td >

        <asp:Button ID="Button1" runat="server" Text="Export to Excel" Enabled="False" OnClick="Button1_Click" />&nbsp;<br />
       <div id="center">
           &nbsp;</div>
        <asp:GridView ID="grddisplay" runat="server" AutoGenerateColumns="False" DataSourceID="SqlDataSource1" CellPadding="4" ForeColor="#333333" Width="90%">
            <Columns>
                <asp:BoundField DataField="DeptRated" HeaderText="Departments" SortExpression="DeptRated" />
                <asp:TemplateField>
                    <HeaderTemplate>
                    Competence
                    </HeaderTemplate>
                    <ItemTemplate>
                  <%#  getCompetence(Convert.ToString(DataBinder.Eval(Container, "DataItem.DeptRated")))%>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField>
                    <HeaderTemplate>
                    Team Work
                    </HeaderTemplate>
                    <ItemTemplate>
                  <%#  getTeamWork(Convert.ToString(DataBinder.Eval(Container, "DataItem.DeptRated")))%>
                    </ItemTemplate>
                </asp:TemplateField>
                  <asp:TemplateField>
                    <HeaderTemplate>
                    Communication
                    </HeaderTemplate>
                    <ItemTemplate>
                  <%#  getCommunication(Convert.ToString(DataBinder.Eval(Container, "DataItem.DeptRated")))%>
                    </ItemTemplate>
                </asp:TemplateField>
                 <asp:TemplateField>
                    <HeaderTemplate>
                    Attitude
                    </HeaderTemplate>
                    <ItemTemplate>
                  <%#  getAttitude(Convert.ToString(DataBinder.Eval(Container, "DataItem.DeptRated")))%>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField>
                    <HeaderTemplate>
                    Responsibility
                    </HeaderTemplate>
                    <ItemTemplate>
                  <%#  getResponsibility(Convert.ToString(DataBinder.Eval(Container, "DataItem.DeptRated")))%>
                    </ItemTemplate>
                </asp:TemplateField>
            </Columns>
            <RowStyle BackColor="#FFFBD6" HorizontalAlign="Center" ForeColor="#333333" />
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
    <td class="tablereporttd">&nbsp;</td>
  </tr>
</table>
</div>
</asp:Content>

