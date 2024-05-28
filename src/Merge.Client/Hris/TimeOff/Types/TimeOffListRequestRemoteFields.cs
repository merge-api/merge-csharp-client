using System.Runtime.Serialization;

#nullable enable

namespace Merge.Client.Hris;

public enum TimeOffListRequestRemoteFields
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
