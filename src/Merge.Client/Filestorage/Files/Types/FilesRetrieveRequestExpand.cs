using System.Runtime.Serialization;

namespace Merge.Client.Filestorage;

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
    PermissionsFolderDrive
}
