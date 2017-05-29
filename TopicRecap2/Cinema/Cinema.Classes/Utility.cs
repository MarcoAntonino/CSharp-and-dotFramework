using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Runtime.Serialization.Json;
using System.Web.Script.Serialization;
using System.IO;

namespace Cinema.Classes
{
    public static class Utility
    {
        /*
         * Accetta come tipologia T (entity) e restituisce T
         * Quando usaiamo T si può dare un vincolo a T.
         * Come si esprime?
         * Questo metodo esiste, ma T deve essere where T : System.IComparable<T>
         */
        public static T MakeRequest<T>(string requestUrl, bool useJavaScriptSerializer=false) //where T : System.IComparable<T>
        {
            try
            {
                HttpWebRequest request = WebRequest.Create(requestUrl) as HttpWebRequest;
                //as ci permette di definire un cast al volo a un altro type
                HttpWebResponse response = (HttpWebResponse)request.GetResponse();

                if(useJavaScriptSerializer)
                {
                    JavaScriptSerializer jsSerializer = new JavaScriptSerializer();
                    using (StreamReader reader = new StreamReader(response.GetResponseStream()))
                    {
                        return jsSerializer.Deserialize<T>(reader.ReadToEnd());
                    }
                }

                DataContractJsonSerializer serializer = new DataContractJsonSerializer(typeof(T));

                return (T)serializer.ReadObject(response.GetResponseStream());
                /*
                 * Data la wikiresponse bisognerà ciclare su tutti gli oggetti del dictionary pages presente all'interno di query
                 * e in qualche modo abbinarli con i dati che abbiamo dall'altra parte (nella lista results)
                 */

            }
            catch (HttpListenerException e)
            {
                return default(T);
                //dato che T può essere qualsiasi tipologia (int, string ecc) nul potrebbe non essere
                //sempre valido (il null di int non esiste per esempio)
                //quindi usiamo default(T) che torna un valore valido (per esempio 0 per int e null per altro)
            }
            catch (InvalidOperationException ex)
            {

                return default(T);

            }
        }
    }
}
