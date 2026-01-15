using System.Text.Json.Serialization;
using Merge.Client.Core;

namespace Merge.Client.Ats;

[JsonConverter(typeof(StringEnumSerializer<AttachmentsRetrieveRequestRemoteFields>))]
[Serializable]
public readonly record struct AttachmentsRetrieveRequestRemoteFields : IStringEnum
{
    public static readonly AttachmentsRetrieveRequestRemoteFields AttachmentType = new(
        Values.AttachmentType
    );

    public AttachmentsRetrieveRequestRemoteFields(string value)
    {
        Value = value;
    }

    /// <summary>
    /// The string value of the enum.
    /// </summary>
    public string Value { get; }

    /// <summary>
    /// Create a string enum with the given value.
    /// </summary>
    public static AttachmentsRetrieveRequestRemoteFields FromCustom(string value)
    {
        return new AttachmentsRetrieveRequestRemoteFields(value);
    }

    public bool Equals(string? other)
    {
        return Value.Equals(other);
    }

    /// <summary>
    /// Returns the string value of the enum.
    /// </summary>
    public override string ToString()
    {
        return Value;
    }

    public static bool operator ==(AttachmentsRetrieveRequestRemoteFields value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(AttachmentsRetrieveRequestRemoteFields value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(AttachmentsRetrieveRequestRemoteFields value) =>
        value.Value;

    public static explicit operator AttachmentsRetrieveRequestRemoteFields(string value) =>
        new(value);

    /// <summary>
    /// Constant strings for enum values
    /// </summary>
    [Serializable]
    public static class Values
    {
        public const string AttachmentType = "attachment_type";
    }
}
