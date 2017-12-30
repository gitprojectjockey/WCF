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
                        <asp:TextBox ID="TextBox1" runat="server" ReadOnly="true"></asp:TextBox></td>
                </tr>
                <tr>
                    <td>Name:</td>
                    <td>
                        <asp:TextBox ID="TextBox2" runat="server" ReadOnly="true"></asp:TextBox></td>

                </tr>
                <tr>
                    <td>Gender:</td>
                    <td>
                        <asp:TextBox ID="TextBox3" runat="server" ReadOnly="true"></asp:TextBox></td>

                </tr>
                <tr>
                    <td>Birth Date:</td>
                    <td>
                        <asp:TextBox ID="TextBox4" runat="server" ReadOnly="true"></asp:TextBox></td>

                </tr>
                <tr>
                    <td>Employee Type:</td>
                    <td>
                        <asp:TextBox ID="TextBox5" runat="server" ReadOnly="true"></asp:TextBox></td>

                </tr>
            </table>
            <table>
                <tr>
                    <td>
                        <asp:Button ID="Button1" runat="server" Text="Get Employee" OnClick="Button1_Click" />
                    </td>
                    <td>Enter EmployeeID </td>
                    <td>
                        <asp:TextBox ID="TextBox6" runat="server" Width="20px"></asp:TextBox></td>
                </tr>
            </table>
        </div>
        <p></p>
        <div style="width: 20%; background-color:beige">
            <table style="width: 100%;">
                <tr>
                    <td>ID:</td>
                    <td>
                        <asp:TextBox ID="TextBox7" runat="server" ></asp:TextBox></td>
                </tr>
                <tr>
                    <td>Name:</td>
                    <td>
                        <asp:TextBox ID="TextBox8" runat="server" ></asp:TextBox></td>

                </tr>
                <tr>
                    <td>Gender:</td>
                    <td>
                        <asp:TextBox ID="TextBox9" runat="server" ></asp:TextBox></td>

                </tr>
                <tr>
                    <td>Birth Date:</td>
                    <td>
                        <asp:TextBox ID="TextBox10" runat="server"></asp:TextBox></td>

                </tr>
                <tr>
                    <td>Employee Type:</td>
                    <td>
                        <asp:TextBox ID="TextBox11" runat="server" ></asp:TextBox></td>

                </tr>
            </table>
            <table>
                <tr>
                    <td>
                        <asp:Button ID="Button2" runat="server" Text="Add Employee" OnClick="Button2_Click" />
                    </td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
