using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Merge.Client.Core;

#nullable enable

namespace Merge.Client.Hris;

[JsonConverter(typeof(StringEnumSerializer<UnitsEnum>))]
public enum UnitsEnum
{
    [EnumMember(Value = "HOURS")]
    Hours,

    [EnumMember(Value = "DAYS")]
    Days,
}
