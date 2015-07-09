
using System.Runtime.Serialization;

namespace GitWebService
{
    [DataContract]
    public enum GitWebServiceStatus
    {
        [EnumMember]
        Success,

        [EnumMember]
        InvalidRequest,

        [EnumMember]
        ServerError
    }
}