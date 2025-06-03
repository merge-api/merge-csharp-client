using System.Text.Json.Serialization;
using Merge.Core;

namespace Merge.Hris;

[JsonConverter(typeof(StringEnumSerializer<RequestFormatEnum>))]
public readonly record struct RequestFormatEnum : IStringEnum
{
    public static readonly RequestFormatEnum Json = new(Values.Json);

    public static readonly RequestFormatEnum Xml = new(Values.Xml);

    public static readonly RequestFormatEnum Multipart = new(Values.Multipart);

    public RequestFormatEnum(string value)
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
    public static RequestFormatEnum FromCustom(string value)
    {
        return new RequestFormatEnum(value);
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

    public static bool operator ==(RequestFormatEnum value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(RequestFormatEnum value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(RequestFormatEnum value) => value.Value;

    public static explicit operator RequestFormatEnum(string value) => new(value);

    /// <summary>
    /// Constant strings for enum values
    /// </summary>
    public static class Values
    {
        public const string Json = "JSON";

        public const string Xml = "XML";

        public const string Multipart = "MULTIPART";
    }
}
