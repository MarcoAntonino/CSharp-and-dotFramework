<%@ Page Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeFile="films.aspx.cs" Inherits="films" %>


<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <asp:Repeater runat="server" ID="webFilmCollectionViewer">
        <ItemTemplate>
            <div>
                <asp:hyperlink id="linkToFilm" runat="server" ><asp:label ID="Title" runat="server"></asp:label></asp:hyperlink>
                
            </div>
        </ItemTemplate>
    </asp:Repeater>

</asp:Content>

