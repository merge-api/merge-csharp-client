using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Merge.Client.Core;

#nullable enable

namespace Merge.Client.Ats;

[JsonConverter(typeof(StringEnumSerializer<JobTypeEnum>))]
public enum JobTypeEnum
{
    [EnumMember(Value = "POSTING")]
    Posting,

    [EnumMember(Value = "REQUISITION")]
    Requisition,

    [EnumMember(Value = "PROFILE")]
    Profile
}
