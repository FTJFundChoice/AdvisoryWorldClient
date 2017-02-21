using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace FTJFundChoice.AdvisoryWorldClient.Model {

    [DataContract]
    public class AWRequest {

        [DataMember(Name = "filter", EmitDefaultValue = false)]
        public string Filter { get; set; }

        [DataMember(Name = "filterationFields", EmitDefaultValue = false)]
        public string[] FilterationFields { get; set; }

        [DataMember(Name = "lastUpdate", EmitDefaultValue = false)]
        public DateTime? LastUpdate { get; set; }

        [DataMember(Name = "paging", EmitDefaultValue = false)]
        public Paging Paging { get; set; }

        [DataMember(Name = "sort", EmitDefaultValue = false)]
        public Sort Sort { get; set; }

        [DataMember(Name = "userIds", EmitDefaultValue = false)]
        public int[] UserIds { get; set; }
    }

    [DataContract]
    public class AWRequest<T> : AWRequest {

        [DataMember(Name = "items", EmitDefaultValue = false)]
        public List<T> Items { get; set; }
    }
}