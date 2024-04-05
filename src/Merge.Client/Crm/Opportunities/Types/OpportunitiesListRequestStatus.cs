using System.Runtime.Serialization;

namespace Merge.Client.Crm;

public enum OpportunitiesListRequestStatus
{
    [EnumMember(Value = "LOST")]
    Lost,

    [EnumMember(Value = "OPEN")]
    Open,

    [EnumMember(Value = "WON")]
    Won
}
