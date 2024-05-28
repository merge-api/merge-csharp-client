using System.Runtime.Serialization;

#nullable enable

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
