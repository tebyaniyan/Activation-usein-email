<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Defaull.aspx.cs" Inherits="Activation usein email.Defaull" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="css/bootstrap-rtl.css" rel="stylesheet" />
    <link href="css/justified-nav.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
        <div class="container">
            <div class="container-inner">
            
                    <div class="form-group">
                        <asp:Label runat="server" ID="lblEmail" Text="ایمیل:"></asp:Label>
                        <asp:TextBox runat="server" ID="txtEmail" Width="50%" CssClass="form-control"></asp:TextBox>
                    </div>
                    <div class="form-group">
                        <asp:Button ID="btnSendActivelink" runat="server" CssClass="btn btn-success" OnClick="btnSendActivelink_OnClick" Text="ارسال لینک فعال سازی"></asp:Button>
                    </div>

            </div>
        </div>
    </form>
</body>
</html>
