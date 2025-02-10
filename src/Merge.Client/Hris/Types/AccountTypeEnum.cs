using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Merge.Client.Core;

namespace Merge.Client.Hris;

[JsonConverter(typeof(EnumSerializer<AccountTypeEnum>))]
public enum AccountTypeEnum
{
    [EnumMember(Value = "SAVINGS")]
    Savings,

    [EnumMember(Value = "CHECKING")]
    Checking,
}
