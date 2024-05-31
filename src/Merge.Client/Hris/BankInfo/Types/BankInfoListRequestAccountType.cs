using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Merge.Client.Core;
using Merge.Client.Hris;

#nullable enable

namespace Merge.Client.Hris;

[JsonConverter(typeof(StringEnumSerializer<BankInfoListRequestAccountType>))]
public enum BankInfoListRequestAccountType
{
    [EnumMember(Value = "CHECKING")]
    Checking,

    [EnumMember(Value = "SAVINGS")]
    Savings
}
