using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Merge.Client.Core;

namespace Merge.Client.Hris;

[JsonConverter(typeof(EnumSerializer<BankInfoListRequestAccountType>))]
public enum BankInfoListRequestAccountType
{
    [EnumMember(Value = "CHECKING")]
    Checking,

    [EnumMember(Value = "SAVINGS")]
    Savings,
}
