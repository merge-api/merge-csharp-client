using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Merge.Client.Core;

namespace Merge.Client.Ticketing;

[JsonConverter(typeof(EnumSerializer<AccessLevelEnum>))]
public enum AccessLevelEnum
{
    [EnumMember(Value = "PRIVATE")]
    Private,

    [EnumMember(Value = "COMPANY")]
    Company,

    [EnumMember(Value = "PUBLIC")]
    Public,
}
