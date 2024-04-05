using System.Runtime.Serialization;

namespace Merge.Client.Hris;

public enum BankInfoListRequestOrderBy
{
    [EnumMember(Value = "-remote_created_at")]
    RemoteCreatedAtDescending,

    [EnumMember(Value = "remote_created_at")]
    RemoteCreatedAtAscending
}
