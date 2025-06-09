using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Merge.Client.Core;

namespace Merge.Client.FileStorage;

[JsonConverter(typeof(EnumSerializer<FoldersListRequestExpandItem>))]
public enum FoldersListRequestExpandItem
{
    [EnumMember(Value = "drive")]
    Drive,

    [EnumMember(Value = "parent_folder")]
    ParentFolder,

    [EnumMember(Value = "permissions")]
    Permissions,
}
