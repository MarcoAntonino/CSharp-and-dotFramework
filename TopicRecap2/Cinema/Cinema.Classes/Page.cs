using System.Runtime.Serialization;

namespace Cinema.Classes
{
    [DataContract]
    public class Page
    {
        [DataMember(Name = "pageid")]
        public int Id { get; set; }
        [DataMember(Name = "fullurl")]
        public string Url { get; set; }

    }
}