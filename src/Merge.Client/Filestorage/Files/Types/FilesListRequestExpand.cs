using System.Text.Json.Serialization;
using System;
using Merge.Client.Utilities;

namespace Merge.Client.Filestorage;

[JsonConverter(typeof(TolerantEnumConverter))]
public enum FilesListRequestExpand
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
    PermissionsFolderDrive
}
