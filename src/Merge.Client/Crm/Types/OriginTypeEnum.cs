using System.Text.Json.Serialization;
using Merge.Client.Core;

namespace Merge.Client.Crm;

[JsonConverter(typeof(StringEnumSerializer<OriginTypeEnum>))]
public readonly record struct OriginTypeEnum : IStringEnum
{
    public static readonly OriginTypeEnum CustomObject = new(Values.CustomObject);

    public static readonly OriginTypeEnum CommonModel = new(Values.CommonModel);

    public static readonly OriginTypeEnum RemoteOnlyModel = new(Values.RemoteOnlyModel);

    public OriginTypeEnum(string value)
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
    public static OriginTypeEnum FromCustom(string value)
    {
        return new OriginTypeEnum(value);
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

    public static bool operator ==(OriginTypeEnum value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(OriginTypeEnum value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(OriginTypeEnum value) => value.Value;

    public static explicit operator OriginTypeEnum(string value) => new(value);

    /// <summary>
    /// Constant strings for enum values
    /// </summary>
    public static class Values
    {
        public const string CustomObject = "CUSTOM_OBJECT";

        public const string CommonModel = "COMMON_MODEL";

        public const string RemoteOnlyModel = "REMOTE_ONLY_MODEL";
    }
}
