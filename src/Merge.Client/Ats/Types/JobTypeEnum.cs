using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Merge.Client.Core;

namespace Merge.Client.Ats;

[JsonConverter(typeof(EnumSerializer<JobTypeEnum>))]
public enum JobTypeEnum
{
    [EnumMember(Value = "POSTING")]
    Posting,

    [EnumMember(Value = "REQUISITION")]
    Requisition,

    [EnumMember(Value = "PROFILE")]
    Profile,
}
