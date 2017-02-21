using System.Runtime.Serialization;

namespace FTJFundChoice.AdvisoryWorldClient.Model {

    [DataContract(Name = "paging")]
    public class Paging {

        [DataMember(Name = "item")]
        public int Items { get; set; }

        [DataMember(Name = "itemsOnPage")]
        public int ItemsOnPage { get; set; }

        [DataMember(Name = "page")]
        public int Page { get; set; }
    }
}