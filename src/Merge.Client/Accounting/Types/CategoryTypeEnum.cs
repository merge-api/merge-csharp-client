using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Merge.Client.Core;

namespace Merge.Client.Accounting;

[JsonConverter(typeof(EnumSerializer<CategoryTypeEnum>))]
public enum CategoryTypeEnum
{
    [EnumMember(Value = "CLASS")]
    Class,

    [EnumMember(Value = "DEPARTMENT")]
    Department,
}
