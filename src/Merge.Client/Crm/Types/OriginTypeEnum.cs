using System.Text.Json.Serialization;
using System;
using Merge.Client.Utilities;

namespace Merge.Client.Crm;

[JsonConverter(typeof(TolerantEnumConverter))]
public enum OriginTypeEnum
{
    [EnumMember(Value = "CUSTOM_OBJECT")]
    CustomObject,

    [EnumMember(Value = "COMMON_MODEL")]
    CommonModel,

    [EnumMember(Value = "REMOTE_ONLY_MODEL")]
    RemoteOnlyModel
}
