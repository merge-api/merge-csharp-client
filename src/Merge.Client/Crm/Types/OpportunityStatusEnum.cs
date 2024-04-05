using System.Runtime.Serialization;

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
