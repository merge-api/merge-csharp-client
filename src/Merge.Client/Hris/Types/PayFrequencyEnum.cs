using System.Runtime.Serialization;

namespace Merge.Client.Hris;

public enum PayFrequencyEnum
{
    [EnumMember(Value = "WEEKLY")]
    Weekly,

    [EnumMember(Value = "BIWEEKLY")]
    Biweekly,

    [EnumMember(Value = "MONTHLY")]
    Monthly,

    [EnumMember(Value = "QUARTERLY")]
    Quarterly,

    [EnumMember(Value = "SEMIANNUALLY")]
    Semiannually,

    [EnumMember(Value = "ANNUALLY")]
    Annually,

    [EnumMember(Value = "THIRTEEN-MONTHLY")]
    ThirteenMonthly,

    [EnumMember(Value = "PRO_RATA")]
    ProRata,

    [EnumMember(Value = "SEMIMONTHLY")]
    Semimonthly
}
