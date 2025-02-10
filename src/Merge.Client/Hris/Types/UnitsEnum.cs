using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Merge.Client.Core;

namespace Merge.Client.Hris;

[JsonConverter(typeof(EnumSerializer<UnitsEnum>))]
public enum UnitsEnum
{
    [EnumMember(Value = "HOURS")]
    Hours,

    [EnumMember(Value = "DAYS")]
    Days,
}
