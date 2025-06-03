using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Merge.Client.Core;

namespace Merge.Client.Ats;

[JsonConverter(typeof(EnumSerializer<ScorecardsListRequestExpandItem>))]
public enum ScorecardsListRequestExpandItem
{
    [EnumMember(Value = "application")]
    Application,

    [EnumMember(Value = "interview")]
    Interview,

    [EnumMember(Value = "interviewer")]
    Interviewer,
}
