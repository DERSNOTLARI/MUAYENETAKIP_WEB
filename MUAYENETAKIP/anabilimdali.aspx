<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="anabilimdali.aspx.cs" Inherits="MUAYENETAKIP.anabilimdali" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
            height: 288px;
        }
        .auto-style2 {
            height: 23px;
        }
        .auto-style3 {
            text-align: right;
            height: 27px;
        }
        .auto-style4 {
            height: 23px;
            text-align: right;
        }
        .auto-style5 {
            text-align: center;
        }
        .auto-style6 {
            height: 27px;
        }
        .auto-style7 {
            height: 220px;
        }
    </style>
</head>
<body>
    <p class="auto-style5">
        &nbsp;</p>
    <form id="form1" runat="server">
        <table class="auto-style1">
            <tr>
                <td class="auto-style3">Anabilim Dalı Adı:</td>
                <td class="auto-style6">
                    <asp:TextBox ID="txtAdi" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style4">Açıklama:</td>
                <td class="auto-style2">
                    <asp:TextBox ID="txtAciklama" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td>
                    <asp:Button ID="btnTemizle" runat="server" OnClick="btnTemizle_Click" Text="TEMİZLE" />
                    <asp:Button ID="kaydetBtn" runat="server" OnClick="kaydetBtn_Click" Text="KAYDET" CommandName="KAYDET" />
                </td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td>
                    <asp:Label ID="sonucLbl" runat="server"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="auto-style7"></td>
                <td class="auto-style7">
                  
                    <asp:GridView ID="gridListe" runat="server" AutoGenerateColumns="False" CellPadding="4" ForeColor="#333333" GridLines="None" Width="479px" DataKeyNames="ANABILIMDALIID" OnRowCommand="gridListe_RowCommand">
                        <AlternatingRowStyle BackColor="White" />
                        <Columns>
                            <asp:ButtonField ButtonType="Button" CommandName="Düzenle" Text="Düzenle" />
                            <asp:ButtonField ButtonType="Button" CommandName="SİL" Text="SİL" />
                            <asp:BoundField DataField="ADI" HeaderText="Anabilimdalı Adı" />
                            <asp:BoundField DataField="ACIKLAMA" HeaderText="Açıklama" />
                        </Columns>
                        <EditRowStyle BackColor="#2461BF" />
                        <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                        <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                        <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
                        <RowStyle BackColor="#EFF3FB" />
                        <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
                        <SortedAscendingCellStyle BackColor="#F5F7FB" />
                        <SortedAscendingHeaderStyle BackColor="#6D95E1" />
                        <SortedDescendingCellStyle BackColor="#E9EBEF" />
                        <SortedDescendingHeaderStyle BackColor="#4870BE" />
                    </asp:GridView>
                  
                </td>
            </tr>
        </table>
    </form>
    </body>
</html>
