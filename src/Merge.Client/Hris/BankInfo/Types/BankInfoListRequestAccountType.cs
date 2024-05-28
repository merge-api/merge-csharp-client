using System.Runtime.Serialization;

#nullable enable

namespace Merge.Client.Hris;

public enum BankInfoListRequestAccountType
{
    [EnumMember(Value = "CHECKING")]
    Checking,

    [EnumMember(Value = "SAVINGS")]
    Savings
}
