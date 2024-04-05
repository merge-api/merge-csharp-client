using System.Runtime.Serialization;

namespace Merge.Client.Hris;

public enum AccountTypeEnum
{
    [EnumMember(Value = "SAVINGS")]
    Savings,

    [EnumMember(Value = "CHECKING")]
    Checking
}
