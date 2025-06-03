using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Merge.Client.Core;

namespace Merge.Client.Ats;

[JsonConverter(typeof(EnumSerializer<CandidatesRetrieveRequestExpandItem>))]
public enum CandidatesRetrieveRequestExpandItem
{
    [EnumMember(Value = "applications")]
    Applications,

    [EnumMember(Value = "attachments")]
    Attachments,
}
