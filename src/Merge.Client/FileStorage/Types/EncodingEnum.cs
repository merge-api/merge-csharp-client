using System.Text.Json.Serialization;
using Merge.Client.Core;

namespace Merge.Client.FileStorage;

[JsonConverter(typeof(StringEnumSerializer<EncodingEnum>))]
public readonly record struct EncodingEnum : IStringEnum
{
    public static readonly EncodingEnum Raw = new(Values.Raw);

    public static readonly EncodingEnum Base64 = new(Values.Base64);

    public static readonly EncodingEnum GzipBase64 = new(Values.GzipBase64);

    public EncodingEnum(string value)
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
    public static EncodingEnum FromCustom(string value)
    {
        return new EncodingEnum(value);
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

    public static bool operator ==(EncodingEnum value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(EncodingEnum value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(EncodingEnum value) => value.Value;

    public static explicit operator EncodingEnum(string value) => new(value);

    /// <summary>
    /// Constant strings for enum values
    /// </summary>
    public static class Values
    {
        public const string Raw = "RAW";

        public const string Base64 = "BASE64";

        public const string GzipBase64 = "GZIP_BASE64";
    }
}
