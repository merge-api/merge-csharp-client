using System.Runtime.Serialization;

namespace Merge.Client.Hris;

public enum BankInfoListRequestAccountType
{
    [EnumMember(Value = "CHECKING")]
    Checking,

    [EnumMember(Value = "SAVINGS")]
    Savings
}
