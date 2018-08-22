<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CalculatorForm.aspx.cs" Inherits="Calculator.WinForms.CalculatorForm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <div>
                <asp:Label ID="lblNumber1" runat="server" Text="Number 1: "></asp:Label>
                <asp:TextBox ID="txtNumber1" runat="server"></asp:TextBox>
            </div>
            <div>
                <asp:Label ID="lblNumber2" runat="server" Text="Number 2: "></asp:Label>
                <asp:TextBox ID="txtNumber2" runat="server"></asp:TextBox>
            </div>
            <div>
                <asp:RadioButtonList ID="rbtnOperator" runat="server" RepeatDirection="Horizontal"></asp:RadioButtonList>
            </div>
            <div>
                <asp:Button ID="btnCalculate" runat="server" Text="Calculate" OnClick="btnCalculate_Click" />
                <asp:Label ID="lblResult" runat="server" Text=""></asp:Label>
            </div>
        </div>
    </form>
</body>
</html>
