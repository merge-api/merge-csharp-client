using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Merge.Client.Core;

namespace Merge.Client.Ats;

[JsonConverter(typeof(EnumSerializer<CandidatesListRequestExpandItem>))]
public enum CandidatesListRequestExpandItem
{
    [EnumMember(Value = "applications")]
    Applications,

    [EnumMember(Value = "attachments")]
    Attachments,
}
