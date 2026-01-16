using System.Text.Json.Serialization;
using Merge.Client.Core;

namespace Merge.Client.Ticketing;

[JsonConverter(typeof(StringEnumSerializer<AttachmentsRetrieveRequestExpandItem>))]
[Serializable]
public readonly record struct AttachmentsRetrieveRequestExpandItem : IStringEnum
{
    public static readonly AttachmentsRetrieveRequestExpandItem Ticket = new(Values.Ticket);

    public AttachmentsRetrieveRequestExpandItem(string value)
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
    public static AttachmentsRetrieveRequestExpandItem FromCustom(string value)
    {
        return new AttachmentsRetrieveRequestExpandItem(value);
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

    public static bool operator ==(AttachmentsRetrieveRequestExpandItem value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(AttachmentsRetrieveRequestExpandItem value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(AttachmentsRetrieveRequestExpandItem value) =>
        value.Value;

    public static explicit operator AttachmentsRetrieveRequestExpandItem(string value) =>
        new(value);

    /// <summary>
    /// Constant strings for enum values
    /// </summary>
    [Serializable]
    public static class Values
    {
        public const string Ticket = "ticket";
    }
}
