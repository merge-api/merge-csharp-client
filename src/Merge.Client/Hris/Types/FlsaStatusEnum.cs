using System.Runtime.Serialization;

#nullable enable

namespace Merge.Client.Hris;

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
