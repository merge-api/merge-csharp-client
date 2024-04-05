using System.Runtime.Serialization;

namespace Merge.Client.Hris;

public enum MaritalStatusEnum
{
    [EnumMember(Value = "SINGLE")]
    Single,

    [EnumMember(Value = "MARRIED_FILING_JOINTLY")]
    MarriedFilingJointly,

    [EnumMember(Value = "MARRIED_FILING_SEPARATELY")]
    MarriedFilingSeparately,

    [EnumMember(Value = "HEAD_OF_HOUSEHOLD")]
    HeadOfHousehold,

    [EnumMember(Value = "QUALIFYING_WIDOW_OR_WIDOWER_WITH_DEPENDENT_CHILD")]
    QualifyingWidowOrWidowerWithDependentChild
}
