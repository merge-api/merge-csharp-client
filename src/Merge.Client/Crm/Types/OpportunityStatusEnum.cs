using System.Runtime.Serialization;

#nullable enable

namespace Merge.Client.Crm;

public enum OpportunityStatusEnum
{
    [EnumMember(Value = "OPEN")]
    Open,

    [EnumMember(Value = "WON")]
    Won,

    [EnumMember(Value = "LOST")]
    Lost
}
