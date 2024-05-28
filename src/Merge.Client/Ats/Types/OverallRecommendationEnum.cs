using System.Runtime.Serialization;

#nullable enable

namespace Merge.Client.Ats;

public enum OverallRecommendationEnum
{
    [EnumMember(Value = "DEFINITELY_NO")]
    DefinitelyNo,

    [EnumMember(Value = "NO")]
    No,

    [EnumMember(Value = "YES")]
    Yes,

    [EnumMember(Value = "STRONG_YES")]
    StrongYes,

    [EnumMember(Value = "NO_DECISION")]
    NoDecision
}
