using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Merge.Client.Core;
using Merge.Client.Crm;

#nullable enable

namespace Merge.Client.Crm;

[JsonConverter(typeof(StringEnumSerializer<ReasonEnum>))]
public enum ReasonEnum
{
    [EnumMember(Value = "GENERAL_CUSTOMER_REQUEST")]
    GeneralCustomerRequest,

    [EnumMember(Value = "GDPR")]
    Gdpr,

    [EnumMember(Value = "OTHER")]
    Other
}
