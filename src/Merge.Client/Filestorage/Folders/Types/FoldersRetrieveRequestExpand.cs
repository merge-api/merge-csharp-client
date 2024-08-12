using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Merge.Client.Core;

#nullable enable

namespace Merge.Client.Filestorage;

[JsonConverter(typeof(StringEnumSerializer<FoldersRetrieveRequestExpand>))]
public enum FoldersRetrieveRequestExpand
{
    [EnumMember(Value = "drive")]
    Drive,

    [EnumMember(Value = "parent_folder")]
    ParentFolder,

    [EnumMember(Value = "parent_folder,drive")]
    ParentFolderDrive,

    [EnumMember(Value = "permissions")]
    Permissions,

    [EnumMember(Value = "permissions,drive")]
    PermissionsDrive,

    [EnumMember(Value = "permissions,parent_folder")]
    PermissionsParentFolder,

    [EnumMember(Value = "permissions,parent_folder,drive")]
    PermissionsParentFolderDrive
}
