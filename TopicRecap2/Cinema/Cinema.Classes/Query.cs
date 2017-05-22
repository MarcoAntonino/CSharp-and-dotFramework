using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Cinema.Classes
{
    [DataContract]
    public class Query
    {
        [DataMember(Name = "pages")]
        public Dictionary<string, Page> Pages { get; set; }
    }
}