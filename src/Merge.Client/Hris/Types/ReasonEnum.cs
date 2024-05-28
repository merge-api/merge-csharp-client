using System.Runtime.Serialization;

#nullable enable

namespace Merge.Client.Hris;

public enum ReasonEnum
{
    [EnumMember(Value = "GENERAL_CUSTOMER_REQUEST")]
    GeneralCustomerRequest,

    [EnumMember(Value = "GDPR")]
    Gdpr,

    [EnumMember(Value = "OTHER")]
    Other
}
