<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm2.aspx.cs" Inherits="WebApplication4.WebForm2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <script src="Scripts1/jquery.3.6.0.js"></script>
    <script src="Scripts1/jquery-ui.js"></script>
    <link href="Bootstrap1/css/bootstrap.min.css" rel="stylesheet" />
    <link href="Scripts1/jquery-ui.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
        <div class="container">
            <div class="form-row">
                <div class="form-group">
                    <asp:Label ID="fromlabel" class="col-form-label" runat="server" Text="From Date"></asp:Label>
                    <asp:TextBox class="form-control" ID="fromtextbox" runat="server" PlaceHolder="Select Date"></asp:TextBox>
                </div>
                <div class="form-group">
                    <asp:Label ID="tolabel" class="col-form-label" runat="server" Text="To Date"></asp:Label>
                    <asp:TextBox class="form-control" ID="totextbox" runat="server" PlaceHolder="Select Date"></asp:TextBox>
                </div>
            </div>
            <div class="form-group">
                <asp:Button class="btn btn-primary" ID="button1" runat="server" Text="Submit" /> 
            </div>
        </div>
    </form>
</body>
</html>
