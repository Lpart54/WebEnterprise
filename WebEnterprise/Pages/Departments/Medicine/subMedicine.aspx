﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="subMedicine.aspx.cs" Inherits="WebEnterprise.Pages.Departments.Medicine.subMedicine" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <script src="../../../Scripts/jquery-3.3.1.min.js"></script>
    <script src="https://cdn.datatables.net/1.10.19/js/jquery.dataTables.min.js"></script>
    <link href="https://cdn.datatables.net/1.10.19/css/jquery.dataTables.min.css" rel="stylesheet" />


    <script type="text/javascript">
    $(document).ready(function () {
        $('#<%= medicinePostGridView.ClientID %>').DataTable({
                    "pageLength": 5
        });
    });
</script>


<div  class="jumbotron">

    <asp:GridView class="dataTable" ID="medicinePostGridView" runat="server" OnRowDataBound="medicinePostGridView_RowDataBound" AutoGenerateColumns="False"  OnSelectedIndexChanged="medicinePostGridView_SelectedIndexChanged">
        <Columns>
            <asp:BoundField DataField="postTitle" HeaderText="postTitle" SortExpression="postTitle" />
            <asp:BoundField DataField="postCategory" HeaderText="postCategory" SortExpression="postCategory" />
            <asp:BoundField DataField="postDate" HeaderText="postDate" SortExpression="postDate" />
        </Columns>
    </asp:GridView>
    <asp:SqlDataSource ID="medicineDataSource" runat="server" ConnectionString="<%$ ConnectionStrings:DefaultConnection %>" SelectCommand="SELECT [postTitle], [postCategory], [postDate] FROM [Posts]"></asp:SqlDataSource>
  <br />

</div>
</asp:Content>
