using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Merge.Client.Core;

namespace Merge.Client.Filestorage;

[JsonConverter(typeof(EnumSerializer<FilesRetrieveRequestExpand>))]
public enum FilesRetrieveRequestExpand
{
    [EnumMember(Value = "drive")]
    Drive,

    [EnumMember(Value = "folder")]
    Folder,

    [EnumMember(Value = "folder,drive")]
    FolderDrive,

    [EnumMember(Value = "permissions")]
    Permissions,

    [EnumMember(Value = "permissions,drive")]
    PermissionsDrive,

    [EnumMember(Value = "permissions,folder")]
    PermissionsFolder,

    [EnumMember(Value = "permissions,folder,drive")]
    PermissionsFolderDrive,
}
