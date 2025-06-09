using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Merge.Client.Core;

namespace Merge.Client.Ats;

[JsonConverter(typeof(EnumSerializer<ScorecardsRetrieveRequestExpandItem>))]
public enum ScorecardsRetrieveRequestExpandItem
{
    [EnumMember(Value = "application")]
    Application,

    [EnumMember(Value = "interview")]
    Interview,

    [EnumMember(Value = "interviewer")]
    Interviewer,
}
