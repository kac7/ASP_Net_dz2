<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="TebleUsers.aspx.cs" Inherits="WebApplication_dz1.TebleUsers" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="Style.css" rel="stylesheet" />
</head>

<body>
    
    <form id="form1" runat="server" class="formReg">
        <div class="form_content">
            <h2 class="formH2">Зарегистрированные пользователи</h2>
            <asp:CheckBoxList ID="CheckBoxList1" runat="server" RepeatLayout="Table" AutoPostBack="true"></asp:CheckBoxList>
            
            <div class="footer">
                <asp:Button ID="del" runat="server" CssClass="btn btn-cancel" Text="Удалить" OnClick="ButtonDelete_Click" Visible="false"/>
                <asp:HyperLink ID="Return" runat="server" CssClass="btn btn-success">Регистрация</asp:HyperLink>
            </div>
        </div>
    </form>
    
</body>
</html>
