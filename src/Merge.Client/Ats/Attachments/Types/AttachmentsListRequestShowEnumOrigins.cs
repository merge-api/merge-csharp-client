using System.Text.Json.Serialization;
using Merge.Client.Core;

namespace Merge.Client.Ats;

[JsonConverter(typeof(StringEnumSerializer<AttachmentsListRequestShowEnumOrigins>))]
[Serializable]
public readonly record struct AttachmentsListRequestShowEnumOrigins : IStringEnum
{
    public static readonly AttachmentsListRequestShowEnumOrigins AttachmentType = new(
        Values.AttachmentType
    );

    public AttachmentsListRequestShowEnumOrigins(string value)
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
    public static AttachmentsListRequestShowEnumOrigins FromCustom(string value)
    {
        return new AttachmentsListRequestShowEnumOrigins(value);
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

    public static bool operator ==(AttachmentsListRequestShowEnumOrigins value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(AttachmentsListRequestShowEnumOrigins value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(AttachmentsListRequestShowEnumOrigins value) =>
        value.Value;

    public static explicit operator AttachmentsListRequestShowEnumOrigins(string value) =>
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
