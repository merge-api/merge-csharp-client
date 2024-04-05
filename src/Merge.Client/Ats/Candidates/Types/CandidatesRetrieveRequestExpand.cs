using System.Runtime.Serialization;

namespace Merge.Client.Ats;

public enum CandidatesRetrieveRequestExpand
{
    [EnumMember(Value = "applications")]
    Applications,

    [EnumMember(Value = "applications,attachments")]
    ApplicationsAttachments,

    [EnumMember(Value = "attachments")]
    Attachments
}
