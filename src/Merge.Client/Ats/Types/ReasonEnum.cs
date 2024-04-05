using System.Runtime.Serialization;

namespace Merge.Client.Ats;

public enum ReasonEnum
{
    [EnumMember(Value = "GENERAL_CUSTOMER_REQUEST")]
    GeneralCustomerRequest,

    [EnumMember(Value = "GDPR")]
    Gdpr,

    [EnumMember(Value = "OTHER")]
    Other
}
