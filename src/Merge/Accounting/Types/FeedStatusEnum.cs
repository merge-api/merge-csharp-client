using System.Text.Json.Serialization;
using Merge.Core;

namespace Merge.Accounting;

[JsonConverter(typeof(StringEnumSerializer<FeedStatusEnum>))]
public readonly record struct FeedStatusEnum : IStringEnum
{
    public static readonly FeedStatusEnum Active = new(Values.Active);

    public static readonly FeedStatusEnum Inactive = new(Values.Inactive);

    public FeedStatusEnum(string value)
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
    public static FeedStatusEnum FromCustom(string value)
    {
        return new FeedStatusEnum(value);
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

    public static bool operator ==(FeedStatusEnum value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(FeedStatusEnum value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(FeedStatusEnum value) => value.Value;

    public static explicit operator FeedStatusEnum(string value) => new(value);

    /// <summary>
    /// Constant strings for enum values
    /// </summary>
    public static class Values
    {
        public const string Active = "ACTIVE";

        public const string Inactive = "INACTIVE";
    }
}
