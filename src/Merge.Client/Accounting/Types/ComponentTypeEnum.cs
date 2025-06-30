using System.Text.Json.Serialization;
using Merge.Client.Core;

namespace Merge.Client.Accounting;

[JsonConverter(typeof(StringEnumSerializer<ComponentTypeEnum>))]
[Serializable]
public readonly record struct ComponentTypeEnum : IStringEnum
{
    public static readonly ComponentTypeEnum Sales = new(Values.Sales);

    public static readonly ComponentTypeEnum Purchase = new(Values.Purchase);

    public ComponentTypeEnum(string value)
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
    public static ComponentTypeEnum FromCustom(string value)
    {
        return new ComponentTypeEnum(value);
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

    public static bool operator ==(ComponentTypeEnum value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(ComponentTypeEnum value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(ComponentTypeEnum value) => value.Value;

    public static explicit operator ComponentTypeEnum(string value) => new(value);

    /// <summary>
    /// Constant strings for enum values
    /// </summary>
    [Serializable]
    public static class Values
    {
        public const string Sales = "SALES";

        public const string Purchase = "PURCHASE";
    }
}
