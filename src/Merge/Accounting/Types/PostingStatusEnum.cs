using System.Text.Json.Serialization;
using Merge.Core;

namespace Merge.Accounting;

[JsonConverter(typeof(StringEnumSerializer<PostingStatusEnum>))]
public readonly record struct PostingStatusEnum : IStringEnum
{
    public static readonly PostingStatusEnum Unposted = new(Values.Unposted);

    public static readonly PostingStatusEnum Posted = new(Values.Posted);

    public PostingStatusEnum(string value)
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
    public static PostingStatusEnum FromCustom(string value)
    {
        return new PostingStatusEnum(value);
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

    public static bool operator ==(PostingStatusEnum value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(PostingStatusEnum value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(PostingStatusEnum value) => value.Value;

    public static explicit operator PostingStatusEnum(string value) => new(value);

    /// <summary>
    /// Constant strings for enum values
    /// </summary>
    public static class Values
    {
        public const string Unposted = "UNPOSTED";

        public const string Posted = "POSTED";
    }
}
