using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Merge.Client.Core;

namespace Merge.Client.FileStorage;

[JsonConverter(typeof(EnumSerializer<LanguageEnum>))]
public enum LanguageEnum
{
    [EnumMember(Value = "en")]
    En,

    [EnumMember(Value = "de")]
    De,
}
