using System.Text.Json.Serialization;
using Merge.Client.Core;

namespace Merge.Client.Ticketing;

[JsonConverter(typeof(StringEnumSerializer<MethodEnum>))]
public readonly record struct MethodEnum : IStringEnum
{
    public static readonly MethodEnum Get = new(Values.Get);

    public static readonly MethodEnum Options = new(Values.Options);

    public static readonly MethodEnum Head = new(Values.Head);

    public static readonly MethodEnum Post = new(Values.Post);

    public static readonly MethodEnum Put = new(Values.Put);

    public static readonly MethodEnum Patch = new(Values.Patch);

    public static readonly MethodEnum Delete = new(Values.Delete);

    public MethodEnum(string value)
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
    public static MethodEnum FromCustom(string value)
    {
        return new MethodEnum(value);
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

    public static bool operator ==(MethodEnum value1, string value2) => value1.Value.Equals(value2);

    public static bool operator !=(MethodEnum value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(MethodEnum value) => value.Value;

    public static explicit operator MethodEnum(string value) => new(value);

    /// <summary>
    /// Constant strings for enum values
    /// </summary>
    public static class Values
    {
        public const string Get = "GET";

        public const string Options = "OPTIONS";

        public const string Head = "HEAD";

        public const string Post = "POST";

        public const string Put = "PUT";

        public const string Patch = "PATCH";

        public const string Delete = "DELETE";
    }
}
