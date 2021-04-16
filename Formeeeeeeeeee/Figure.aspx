<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Figure.aspx.cs" Inherits="Formeeeeeeeeee.Figure" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <h1>SCEGLIERE FIGURA</h1>
    <table runat="server" visible="true" id="tbl_Figure">
        <tr>
            <td><asp:Button runat="server" ID="btn_Rettangolo" Text="RETTANGOLO" onclick="btn_R"/></td>
        </tr>
        <tr>
            <td><asp:Button runat="server" ID="btn_Cerchio" Text="CERCHIO" onclick="btn_C"/></td>
        </tr>
        <tr>
            <td><asp:Button runat="server" ID="btn_Triangolo" Text="TRIANGOLO" onclick="btn_T"/></td>
        </tr>
    </table><br />

    <asp:Label runat="server" ID="lbl_tipoT" Visible="false"></asp:Label>
    <br /> <table runat="server" visible="false" id="tbl_T">
        <tr>
            <td>INSERIRE MISURA LATO</td>
            <td><asp:TextBox runat="server" ID="txtLatoT" ></asp:TextBox></td>
        </tr>
        <tr>
            <td>INSERIRE MISURA ALTEZZA</td>
            <td><asp:TextBox runat="server" ID="txt_AltT"></asp:TextBox></td>
        </tr>
        <tr>
            <td><asp:Button runat="server" Text="CALCOLO PERIMETRO" onclick="btn_CalcoloPerT" /> </td>
            <td><asp:Label runat="server" ID="lbl_PerT" Visible="false"></asp:Label></td>
        </tr>
        <tr>
            <td><asp:Button runat="server" Text="CALCOLO AREA" onclick="btn_CalcoloAreaT" /></td>
            <td><asp:Label runat="server" ID="lbl_AreaT" Visible="false"></asp:Label></td>
        </tr>
     </table><br />

    <asp:Label runat="server" ID="lbl_TipoRett" Visible="false"></asp:Label><br />
    <br /><table runat="server" visible="false" id="tbl_LatoAlt">
        <tr>
            <td>INSERIRE MISURA LATO</td>
            <td><asp:TextBox runat="server" ID="txt_Lato" ></asp:TextBox></td>
        </tr>
        <tr>
            <td>INSERIRE MISURA ALTEZZA</td>
            <td><asp:TextBox runat="server" ID="txt_Altezza"></asp:TextBox></td>
        </tr>
        <tr>
            <td><asp:Button runat="server" Text="CALCOLO PERIMETRO" onclick="btn_CalcoloPer" /> </td>
            <td><asp:Label runat="server" ID="lbl_Perimetro" Visible="false"></asp:Label></td>
        </tr>
        <tr>
            <td><asp:Button runat="server" Text="CALCOLO AREA" onclick="btn_CalcoloArea" /></td>
            <td><asp:Label runat="server" ID="lbl_Area" Visible="false"></asp:Label></td>
        </tr>
     </table><br />


    <table runat="server" id="tbl_Raggio" visible="false">
        <tr>
             <td>INSERIRE MISURA RAGGIO</td>
            <td><asp:TextBox runat="server" ID="txt_Raggio"></asp:TextBox></td>
        </tr>
          <tr>
            <td><asp:Button runat="server" Text="CALCOLO CIRCONFEREZA" onclick="btn_CalcoloCirc" /> </td>
            <td><asp:Label runat="server" ID="lbl_Circ" Visible="false"></asp:Label></td>
        </tr>
        <tr>
            <td><asp:Button runat="server" Text="CALCOLO AREA" onclick="btn_CalcoloAreaC" /></td>
            <td><asp:Label runat="server" ID="lbl_Area2" Visible="false"></asp:Label></td>
        </tr>
    </table><br />


    <asp:Button runat="server" ID="btn_Indietro" OnClick="btn_IndietroClick" visible="false" Text="INDIETRO"/>




</asp:Content>
