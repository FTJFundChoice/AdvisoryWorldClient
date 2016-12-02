using System.Collections.Generic;
using System.Runtime.Serialization;

namespace AdvisoryWorldClient.Model {

    [DataContract]
    public class AWRequest {

        [DataMember(Name = "paging")]
        public Paging Paging { get; set; }
    }

    [DataContract]
    public class AWRequest<T> {

        [DataMember(Name = "paging")]
        public Paging Paging { get; set; }

        [DataMember(Name = "items")]
        public List<T> Items { get; set; }
    }
}