using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Merge.Client.Core;

#nullable enable

namespace Merge.Client.Hris;

[JsonConverter(typeof(StringEnumSerializer<GenderEnum>))]
public enum GenderEnum
{
    [EnumMember(Value = "MALE")]
    Male,

    [EnumMember(Value = "FEMALE")]
    Female,

    [EnumMember(Value = "NON-BINARY")]
    NonBinary,

    [EnumMember(Value = "OTHER")]
    Other,

    [EnumMember(Value = "PREFER_NOT_TO_DISCLOSE")]
    PreferNotToDisclose,
}
