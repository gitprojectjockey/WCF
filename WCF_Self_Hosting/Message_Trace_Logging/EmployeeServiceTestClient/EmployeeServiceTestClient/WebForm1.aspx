<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="EmployeeServiceTestClient.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>

<body>
    <form id="form1" runat="server">
        <div style="width: 20%; background-color:beige">
            <table style="width: 100%">
                <tr>
                    <td>ID:</td>
                    <td>
                        <asp:TextBox ID="txtId" runat="server" ReadOnly="true"></asp:TextBox></td>
                </tr>
                <tr>
                    <td>Name:</td>
                    <td>
                        <asp:TextBox ID="txtName" runat="server" ReadOnly="true"></asp:TextBox></td>

                </tr>
                <tr>
                    <td>Gender:</td>
                    <td>
                        <asp:TextBox ID="txtGender" runat="server" ReadOnly="true"></asp:TextBox></td>

                </tr>
                <tr>
                    <td>Birth Date:</td>
                    <td>
                        <asp:TextBox ID="txtBirthDate" runat="server" ReadOnly="true"></asp:TextBox></td>

                </tr>
                <tr>
                    <td>Employee Type:</td>
                    <td>
                        <asp:TextBox ID="txtType" runat="server" ReadOnly="true"/>
                    </td>

                </tr>
                 <tr id ="trAnnualSalary" runat="server">
                    <td>Annual Salary</td>
                    <td>
                        <asp:TextBox ID="txtSalary" runat="server" ReadOnly="true"></asp:TextBox></td>

                </tr>
                 <tr id ="trHourlyPay" runat="server">
                    <td>Hourly Pay:</td>
                    <td>
                        <asp:TextBox ID="txtHourlyPay" runat="server" ReadOnly="true"></asp:TextBox></td>

                </tr>
                  <tr id ="trHoursWorked" runat="server">
                    <td>Hourly Pay:</td>
                    <td>
                        <asp:TextBox ID="txtHoursWorked" runat="server" ReadOnly="true"></asp:TextBox></td>

                </tr>
            </table>
            <table>
                <tr>
                    <td>
                        <asp:Button ID="btnGetEmployee" runat="server" Text="Get Employee" OnClick="Button1_Click" />
                    </td>
                    <td>Enter EmployeeID </td>
                    <td>
                        <asp:TextBox ID="txtEnterId" runat="server" Width="20px"></asp:TextBox></td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="lblGetStatus" runat="server" Width="100%" ForeColor="#00cc00"></asp:Label>
                    </td>
                </tr>
            </table>
        </div>
        <p></p>
        <div style="width: 20%; background-color:beige">
            <table style="width: 100%;">
                <tr>
                    <td>ID:</td>
                    <td>
                        <asp:TextBox ID="txtSetId" runat="server" ></asp:TextBox></td>
                </tr>
                <tr>
                    <td>Name:</td>
                    <td>
                        <asp:TextBox ID="txtSetName" runat="server" ></asp:TextBox></td>

                </tr>
                <tr>
                    <td>Gender:</td>
                    <td>
                        <asp:TextBox ID="txtSetGender" runat="server" ></asp:TextBox></td>

                </tr>
                <tr>
                    <td>Birth Date:</td>
                    <td>
                        <asp:TextBox ID="txtSetBirthDate" runat="server"></asp:TextBox></td>

                </tr>
                <tr>
                    <td>Employee Type:</td>
                    <td>
                        <asp:DropDownList ID="ddlType" runat="server" OnSelectedIndexChanged="ddlType_SelectedIndexChanged" AutoPostBack="True">
                            <asp:ListItem Text="Select Employee Type" Value="-1"></asp:ListItem>
                             <asp:ListItem Text="Full Time" Value="1"></asp:ListItem>
                             <asp:ListItem Text="Part Time" Value="2"></asp:ListItem>
                        </asp:DropDownList>
                   </td>

                </tr>
                 <tr id ="trSetAnnualSalary" runat="server">
                    <td>Annual Salary</td>
                    <td>
                        <asp:TextBox ID="txtSetAnnualSalary" runat="server"></asp:TextBox></td>

                </tr>
                 <tr id ="trSetHourlyPay" runat="server">
                    <td>Hourly Pay:</td>
                    <td>
                        <asp:TextBox ID="txtSetHourlyPay" runat="server"></asp:TextBox></td>

                </tr>
                  <tr id ="trSetHours" runat="server">
                    <td>Hourly Pay:</td>
                    <td>
                        <asp:TextBox ID="txtSetHours" runat="server"></asp:TextBox></td>

                </tr>
            </table>
            <table>
                <tr>
                    <td>
                        <asp:Button ID="Button2" runat="server" Text="Add Employee" OnClick="Button2_Click" />
                    </td>
                </tr>
                 <tr>
                    <td>
                        <asp:Label ID="lblSetStatus" runat="server" Width="100%" ForeColor="#00cc00"></asp:Label>
                    </td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
