﻿using System;
using System.Runtime.Serialization;

namespace AdvisoryWorldClient.Model {

    [DataContract]
    public class Proposal {

        [DataMember(Name = "name")]
        public string Name { get; set; }

        [DataMember(Name = "id")]
        public int Id { get; set; }

        [DataMember(Name = "userId")]
        public int UserId { get; set; }

        [DataMember(Name = "status")]
        public string Status { get; set; }

        [DataMember(Name = "type")]
        public string Type { get; set; }

        [DataMember(Name = "accounts")]
        public int Accounts { get; set; }

        [DataMember(Name = "value")]
        public int Value { get; set; } // TODO: Should this be decimal?

        [DataMember(Name = "dateCreated")]
        public DateTime DateCreated { get; set; }

        [DataMember(Name = "dateUpdated")]
        public DateTime DateUpdated { get; set; }
    }
}