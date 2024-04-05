using System.Runtime.Serialization;

namespace Merge.Client.Crm;

public enum OriginTypeEnum
{
    [EnumMember(Value = "CUSTOM_OBJECT")]
    CustomObject,

    [EnumMember(Value = "COMMON_MODEL")]
    CommonModel,

    [EnumMember(Value = "REMOTE_ONLY_MODEL")]
    RemoteOnlyModel
}
