

<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="View.aspx.cs" Inherits="CarModelViewer.Views.View" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataSourceID="ObjectDataSource1">
            <Columns>
                <asp:BoundField DataField="VehicleMakeID" HeaderText="VehicleMakeID" SortExpression="VehicleMakeID" />
                <asp:BoundField DataField="ManufacturerName" HeaderText="ManufacturerName" SortExpression="ManufacturerName" />
            </Columns>
        </asp:GridView>



        <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" SelectMethod="GetManufacturer" TypeName="CarModelViewer.Models.VehicleModelRepository"></asp:ObjectDataSource>
         </div>
    </form>
    </body>
</html>
