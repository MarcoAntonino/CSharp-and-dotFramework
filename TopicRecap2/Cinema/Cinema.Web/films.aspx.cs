using Cinema.Classes;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;



public partial class films : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

        FilmCollection webFilmCollection = Utility.MakeRequest<FilmCollection>(ConfigurationManager.AppSettings["apiurl"]);

        webFilmCollectionViewer.DataSource = webFilmCollection.Results;
        webFilmCollectionViewer.ItemDataBound += WebFilmCollectionViewer_ItemDataBound;
        webFilmCollectionViewer.DataBind();
        

    }

    private void WebFilmCollectionViewer_ItemDataBound(object sender, RepeaterItemEventArgs e)
    {
        Film film = e.Item.DataItem as Film;
        Label titleLabel = (Label)e.Item.FindControl("Title");
        titleLabel.Text = film.Title;

        HyperLink linkToFilm = (HyperLink)e.Item.FindControl("linkToFilm");
        linkToFilm.NavigateUrl = film.WikipediaUrl;

    }

    /*
     * data la lista di film dentro a movie, una volta cliccato sul film, si va dentro la pagina linkata del film e si ottiene
     * il film id e da un'altra parte si ottiene tutti i dati del film.
     * Quindi per ogni film cliccato: pagina con i contenuti e i dettagli
     */


}