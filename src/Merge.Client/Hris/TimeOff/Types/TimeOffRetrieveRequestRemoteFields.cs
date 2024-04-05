using System.Text.Json.Serialization;
using System;
using Merge.Client.Utilities;

namespace Merge.Client.Hris;

[JsonConverter(typeof(TolerantEnumConverter))]
public enum TimeOffRetrieveRequestRemoteFields
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
    Units
}
