using System.Runtime.Serialization;

namespace Cinema.Classes
{
    [DataContract]
    public class Page
    {
        [DataMember(Name = "pageid")]
        public int PageId { get; set; }
        [DataMember(Name = "fullurl")]
        public string FullUrl { get; set; }

    }
}