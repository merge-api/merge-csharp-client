using System.Runtime.Serialization;

namespace Merge.Client.Filestorage;

public enum FoldersListRequestExpand
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
