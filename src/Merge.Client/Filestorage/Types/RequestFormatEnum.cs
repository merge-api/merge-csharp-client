using System.Runtime.Serialization;

#nullable enable

namespace Merge.Client.Filestorage;

public enum RequestFormatEnum
{
    [EnumMember(Value = "JSON")]
    Json,

    [EnumMember(Value = "XML")]
    Xml,

    [EnumMember(Value = "MULTIPART")]
    Multipart
}
