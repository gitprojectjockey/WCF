<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebClient.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Pizza Service</title>


     <script type="text/javascript">
        function setPageDirty() {
            document.getElementById("<%= btnPizza.ClientID %>").value = "Retrieving pizza list...";
            document.getElementById("<%= lstPizza.ClientID %>").length = 0;
        }
    </script>




</head>
<body>
    <form id="form1" runat="server">
        <div style="font-family: Arial">
            <asp:Literal ID="litPizza" runat="server">Microsoft has now developed an in-process memory cache that does not rely on the ASP.NET framework.<br />This cache can be found in the “System.Runtime.Caching.dll” assembly.<br />
            This sample pizza service caches the results after the first IIS message activation of the service.<br /> 
            The first call takes some time because the data must first be retrived and chached but after that the cached data is returned very quickly.<br /><br />
            The cache is set in the service code to expire after one hour and the service config setting (system.runtime.caching) sets cache memory useage not to exceed 20%.
            </asp:Literal>
            <br />
        </div>
        <br />
        <div style="font-family: Arial">
            <asp:ListBox ID="lstPizza" runat="server" Width="206px"></asp:ListBox>
        </div>
        <br />
        <div style="font-family: Arial">
            <asp:Button ID="btnPizza" runat="server" Text="Get List of Pizza Types" OnClick="btnPizza_Click" CausesValidation="False" EnableViewState="False"  OnClientClick="javascript:setPageDirty();"/>
        </div>
    </form>
</body>
</html>

