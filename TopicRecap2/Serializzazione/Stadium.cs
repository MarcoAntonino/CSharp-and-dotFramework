using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;


namespace Serializzazione
{
    public class Stadium
    {
        [XmlElement("IdStadium")]
        public string IdStadium { get; set; }
        [XmlElement("IdCity")]
        public string IdCity { get; set; }
        [XmlElement("IdCountry")]
        public string IdCountry { get; set; }
        [XmlElement("Name", typeof(LocalizedName))]
        public LocalizedName[] Name { get; set; }

        public override string ToString()
        {
            string name = string.Empty;
            if (Name.Length > 0)
            {
                name = Name[0].Description;
            }
            return string.Format("IdStadium: {0}\r\nIdCity: {1}\r\nIdCountry: {2}\r\nName: {3}", IdStadium, IdCity, IdCountry, name);
        }
    }
}
