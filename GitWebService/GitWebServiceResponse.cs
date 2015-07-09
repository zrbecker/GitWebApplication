using System.Runtime.Serialization;

namespace GitWebService
{
    [DataContract]
    public class GitWebServiceResponse
    {
        [DataMember]
        public GitWebServiceStatus Status;

        [DataMember]
        public string ErrorMessage;
    }
}