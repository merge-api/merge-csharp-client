using System.Runtime.Serialization;

#nullable enable

namespace Merge.Client.Ticketing;

public enum AccessLevelEnum
{
    [EnumMember(Value = "PRIVATE")]
    Private,

    [EnumMember(Value = "COMPANY")]
    Company,

    [EnumMember(Value = "PUBLIC")]
    Public
}
