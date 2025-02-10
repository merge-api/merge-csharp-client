using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Merge.Client.Core;

namespace Merge.Client.Ats;

[JsonConverter(typeof(EnumSerializer<EnabledActionsEnum>))]
public enum EnabledActionsEnum
{
    [EnumMember(Value = "READ")]
    Read,

    [EnumMember(Value = "WRITE")]
    Write,
}
