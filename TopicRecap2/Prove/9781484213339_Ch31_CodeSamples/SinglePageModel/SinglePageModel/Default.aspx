<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="SinglePageModel.Default" %>
<%@ Import Namespace="AutoLotDAL.Models" %>
<%@ Import Namespace="AutoLotDAL.Repos" %>
<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Fun with Web Pages!</title>
</head>
    <script runat="server">
        public IEnumerable<Inventory> GetData()
        {
            return new InventoryRepo().GetAll();
        }
    </script>
    
<body>
    <form id="form1" runat="server">
        <div><!--Permette un controllo per le liste fortemente tipizzate-->
            <asp:GridView ID="carsGridView" runat="server"
                ItemType="AutoLotDAL.Models.Inventory"
                SelectedMethod="GetData"
                ></asp:GridView><!--è il metodo utilizzato per popolare la tabella...mah-->
        </div>
    </form>
</body>
</html>
