using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Merge.Client.Core;

#nullable enable

namespace Merge.Client.Crm;

[JsonConverter(typeof(StringEnumSerializer<OriginTypeEnum>))]
public enum OriginTypeEnum
{
    [EnumMember(Value = "CUSTOM_OBJECT")]
    CustomObject,

    [EnumMember(Value = "COMMON_MODEL")]
    CommonModel,

    [EnumMember(Value = "REMOTE_ONLY_MODEL")]
    RemoteOnlyModel
}
