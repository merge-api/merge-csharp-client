using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Merge.Client.Core;

#nullable enable

namespace Merge.Client.Hris;

[JsonConverter(typeof(StringEnumSerializer<AccountTypeEnum>))]
public enum AccountTypeEnum
{
    [EnumMember(Value = "SAVINGS")]
    Savings,

    [EnumMember(Value = "CHECKING")]
    Checking
}
