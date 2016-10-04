<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="WebApplication1.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <script src="Scripts/jquery-3.1.1.js"></script>
    <script>
        function cli(a) {
            console.log(a.innerText)
            $('#t').val(5);
        }
        Date.toString();
    </script>
</head>
<body>
    <form id="form1" runat="server">
    <div>
       <input  id="t"/>
        <label>doqwejoqwiejo</label>
        <button onclick="cli(this);">wwww</button>
    </div>
    </form>
</body>
</html>
