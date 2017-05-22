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

            return standardLinkFormat;

        }

        private WikipediaResponse makeRequest(string requestUrl)
        {
            try
            {
                HttpWebRequest request = WebRequest.Create(requestUrl) as HttpWebRequest;
                //as ci permette di definire un cast al volo a un altro type
                HttpWebResponse response = (HttpWebResponse)request.GetResponse();

                DataContractJsonSerializer serializer = new DataContractJsonSerializer(typeof(WikipediaResponse));

                return (WikipediaResponse)serializer.ReadObject(response.GetResponseStream());
                /*
                 * Data la wikiresponse bisognerà ciclcare su tutti gli oggetti del dictionary pages presente all'interno di query
                 * e in qualche modo abbinarli con i dati che abbiamo dall'altra parte (nella rista results)
                 */

            }
            catch (HttpListenerException e)
            {
                return null;
            }
            catch (InvalidOperationException ex)
            {

                return null;

            }
        }

    }
}
