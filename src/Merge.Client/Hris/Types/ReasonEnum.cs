using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Merge.Client.Core;

namespace Merge.Client.Hris;

[JsonConverter(typeof(EnumSerializer<ReasonEnum>))]
public enum ReasonEnum
{
    [EnumMember(Value = "GENERAL_CUSTOMER_REQUEST")]
    GeneralCustomerRequest,

    [EnumMember(Value = "GDPR")]
    Gdpr,

    [EnumMember(Value = "OTHER")]
    Other,
}
