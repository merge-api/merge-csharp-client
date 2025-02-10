using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Merge.Client.Core;

namespace Merge.Client.Hris;

[JsonConverter(typeof(EnumSerializer<FlsaStatusEnum>))]
public enum FlsaStatusEnum
{
    [EnumMember(Value = "EXEMPT")]
    Exempt,

    [EnumMember(Value = "SALARIED_NONEXEMPT")]
    SalariedNonexempt,

    [EnumMember(Value = "NONEXEMPT")]
    Nonexempt,

    [EnumMember(Value = "OWNER")]
    Owner,
}
