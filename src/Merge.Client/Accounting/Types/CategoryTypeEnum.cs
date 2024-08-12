using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Merge.Client.Core;

#nullable enable

namespace Merge.Client.Accounting;

[JsonConverter(typeof(StringEnumSerializer<CategoryTypeEnum>))]
public enum CategoryTypeEnum
{
    [EnumMember(Value = "CLASS")]
    Class,

    [EnumMember(Value = "DEPARTMENT")]
    Department
}
