using System.Runtime.Serialization;

namespace AdvisoryWorldClient.Model {

    [DataContract(Name = "sort")]
    public class Sort {

        [DataMember(Name = "name")]
        public string Name { get; set; }

        [DataMember(Name = "order")]
        public string Order { get; set; }
    }
}