using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Merge.Client.Core;

namespace Merge.Client.Ats;

[JsonConverter(typeof(EnumSerializer<CandidatesRetrieveRequestExpand>))]
public enum CandidatesRetrieveRequestExpand
{
    [EnumMember(Value = "applications")]
    Applications,

    [EnumMember(Value = "applications,attachments")]
    ApplicationsAttachments,

    [EnumMember(Value = "attachments")]
    Attachments,
}
