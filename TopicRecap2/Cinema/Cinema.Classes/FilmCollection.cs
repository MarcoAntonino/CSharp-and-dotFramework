using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Threading.Tasks;


namespace Cinema.Classes
{
    [DataContract]
    public class FilmCollection
    {
        [DataMember(Name = "results")]
        public List<Film> Results { get; set; }
        /*
         * Il json tendenzialmente per lui è tutto camelCase
         * altrimenti ci gira intorno
         */

        public string RequestWikipediaUrl ( )
        {
            string ids = string.Empty;

            foreach (Film film in Results)
            {
                ids += String.Concat(film.WikipediaId,"|");
            }

            ids = ids.Substring(0, (ids.Length - 1));
            string standardLinkFormat = "https://en.wikipedia.org/w/api.php?action=query&prop=info&pageids={0}&inprop=url&format=json";
            standardLinkFormat = string.Format(standardLinkFormat, ids);

            WikipediaResponse wikiResponse = Utility.MakeRequest < WikipediaResponse >(standardLinkFormat, true);
            matchWikiIDWithWikiURL(wikiResponse);

            return standardLinkFormat;

        }

        private void matchWikiIDWithWikiURL (WikipediaResponse wikiResponse)
        {
            foreach (KeyValuePair<string, Page> kvpage in wikiResponse.Query.Pages)
            {
                foreach ( Film film in Results)
                {
                    if(film.WikipediaId == kvpage.Value.PageId)
                    {
                        film.WikipediaUrl = kvpage.Value.FullUrl;
                    }
                }
            }
        }



        

        

    }
}
