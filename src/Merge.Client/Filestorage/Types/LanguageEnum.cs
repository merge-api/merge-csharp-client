using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Merge.Client.Core;

#nullable enable

namespace Merge.Client.Filestorage;

[JsonConverter(typeof(StringEnumSerializer<LanguageEnum>))]
public enum LanguageEnum
{
    [EnumMember(Value = "en")]
    En,

    [EnumMember(Value = "de")]
    De,
}
