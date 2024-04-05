using System.Text.Json.Serialization;
using System;
using Merge.Client.Utilities;

namespace Merge.Client.Accounting;

[JsonConverter(typeof(TolerantEnumConverter))]
public enum CategoryTypeEnum
{
    [EnumMember(Value = "CLASS")]
    Class,

    [EnumMember(Value = "DEPARTMENT")]
    Department
}
