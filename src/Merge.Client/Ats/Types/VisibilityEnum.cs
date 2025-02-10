using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Merge.Client.Core;

namespace Merge.Client.Ats;

[JsonConverter(typeof(EnumSerializer<VisibilityEnum>))]
public enum VisibilityEnum
{
    [EnumMember(Value = "ADMIN_ONLY")]
    AdminOnly,

    [EnumMember(Value = "PUBLIC")]
    Public,

    [EnumMember(Value = "PRIVATE")]
    Private,
}
