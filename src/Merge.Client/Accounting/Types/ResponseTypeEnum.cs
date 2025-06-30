using System.Text.Json.Serialization;
using Merge.Client.Core;

namespace Merge.Client.Accounting;

[JsonConverter(typeof(StringEnumSerializer<ResponseTypeEnum>))]
[Serializable]
public readonly record struct ResponseTypeEnum : IStringEnum
{
    public static readonly ResponseTypeEnum Json = new(Values.Json);

    public static readonly ResponseTypeEnum Base64Gzip = new(Values.Base64Gzip);

    public ResponseTypeEnum(string value)
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
    public static ResponseTypeEnum FromCustom(string value)
    {
        return new ResponseTypeEnum(value);
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

    public static bool operator ==(ResponseTypeEnum value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(ResponseTypeEnum value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(ResponseTypeEnum value) => value.Value;

    public static explicit operator ResponseTypeEnum(string value) => new(value);

    /// <summary>
    /// Constant strings for enum values
    /// </summary>
    [Serializable]
    public static class Values
    {
        public const string Json = "JSON";

        public const string Base64Gzip = "BASE64_GZIP";
    }
}
