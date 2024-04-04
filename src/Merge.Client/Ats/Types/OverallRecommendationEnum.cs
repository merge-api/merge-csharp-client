using System.Text.Json.Serialization;
using System;
using Merge.Client.Utilities;

namespace Merge.Client.Ats;

[JsonConverter(typeof(TolerantEnumConverter))]
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
