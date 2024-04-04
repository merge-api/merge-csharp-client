using System.Text.Json.Serialization;
using System;
using Merge.Client.Utilities;

namespace Merge.Client.Hris;

[JsonConverter(typeof(TolerantEnumConverter))]
public enum BankInfoListRequestAccountType
{
    [EnumMember(Value = "CHECKING")]
    Checking,

    [EnumMember(Value = "SAVINGS")]
    Savings
}
