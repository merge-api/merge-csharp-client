using System.Text.Json.Serialization;
using System;
using Merge.Client.Utilities;

namespace Merge.Client.Hris;

[JsonConverter(typeof(TolerantEnumConverter))]
public enum FlsaStatusEnum
{
    [EnumMember(Value = "EXEMPT")]
    Exempt,

    [EnumMember(Value = "SALARIED_NONEXEMPT")]
    SalariedNonexempt,

    [EnumMember(Value = "NONEXEMPT")]
    Nonexempt,

    [EnumMember(Value = "OWNER")]
    Owner
}
