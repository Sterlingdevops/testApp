<%@ Page Language="C#" MasterPageFile="~/login.master" AutoEventWireup="true" CodeFile="AddComment.aspx.cs" Inherits="AddComment" Title="Untitled Page" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<div id="myFrm" style="margin:0px auto; width:854px; margin-top:12px; font-size:12px; ">
<h2 style="margin-left:400px; margin-bottom:50px;"> ADD COMMENTS</h2>
      

<fieldset  style="margin-left:200px;" >
<table class="myFrmA">
<tr style="padding-bottom:100px; margin-bottom:200px;" >
<td colspan="2"><spa:infoBar ID="ibox" runat="server" /></td>
</tr>
<tr style="padding-bottom:100px; margin-bottom:200px;" >
<td colspan="2"> Please select a department &nbsp;to add comment</td>
</tr>

<tr>
<td >Departments</td>
<td  >
    <asp:DropDownList ID="deptDD" runat="server" DataSourceID="SqlDataSource2" DataTextField="DeptRated" DataValueField="DeptRated">
    </asp:DropDownList><asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:dbConn %>"
        SelectCommand="spd_getRatingNoComments" SelectCommandType="StoredProcedure">
        <SelectParameters>
            <asp:SessionParameter Name="username" SessionField="currUser" Type="String" />
        </SelectParameters>
    </asp:SqlDataSource>
    <asp:SqlDataSource ID="commentWithoutRatingDS" runat="server"
        ConnectionString="<%$ ConnectionStrings:dbConn %>" SelectCommand="spd_getRatingNoComments"
        SelectCommandType="StoredProcedure">
        <SelectParameters>
            <asp:Parameter Name="username" Type="String" DefaultValue="fayemia" />
        </SelectParameters>
    </asp:SqlDataSource>
    <asp:SqlDataSource ID="SqlDataSource1" runat="server"></asp:SqlDataSource>
</td>
</tr>
<tr>
<td style="width:40%;"> Comment</td>
<td style="width:60%;">  <asp:TextBox ID="comment" runat="server" Height="58px" TextMode="MultiLine" OnTextChanged="comment_TextChanged"></asp:TextBox></td>
</tr>
<tr>
<td style="width:40%;"> </td>
<td style="width:40%;"align="left"><asp:Button ID="btnSubmit" runat="server" Text="Submit" OnClick="btnSubmit_Click" Enabled="true" /></td>
    
</tr>
</table>

</fieldset>
</div>
</asp:Content>

