using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Merge.Client.Core;

namespace Merge.Client.Hris;

[JsonConverter(typeof(EnumSerializer<TimeOffListRequestShowEnumOrigins>))]
public enum TimeOffListRequestShowEnumOrigins
{
    [EnumMember(Value = "request_type")]
    RequestType,

    [EnumMember(Value = "request_type,status")]
    RequestTypeStatus,

    [EnumMember(Value = "request_type,status,units")]
    RequestTypeStatusUnits,

    [EnumMember(Value = "request_type,units")]
    RequestTypeUnits,

    [EnumMember(Value = "status")]
    Status,

    [EnumMember(Value = "status,units")]
    StatusUnits,

    [EnumMember(Value = "units")]
    Units,
}
