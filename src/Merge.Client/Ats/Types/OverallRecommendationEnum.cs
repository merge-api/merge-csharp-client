using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Merge.Client.Core;

namespace Merge.Client.Ats;

[JsonConverter(typeof(EnumSerializer<OverallRecommendationEnum>))]
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
    NoDecision,
}
