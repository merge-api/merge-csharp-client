using System.Text.Json.Serialization;
using Merge.Core;

namespace Merge.Crm;

[JsonConverter(typeof(StringEnumSerializer<SelectiveSyncConfigurationsUsageEnum>))]
public readonly record struct SelectiveSyncConfigurationsUsageEnum : IStringEnum
{
    public static readonly SelectiveSyncConfigurationsUsageEnum InNextSync = new(Values.InNextSync);

    public static readonly SelectiveSyncConfigurationsUsageEnum InLastSync = new(Values.InLastSync);

    public SelectiveSyncConfigurationsUsageEnum(string value)
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
    public static SelectiveSyncConfigurationsUsageEnum FromCustom(string value)
    {
        return new SelectiveSyncConfigurationsUsageEnum(value);
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

    public static bool operator ==(SelectiveSyncConfigurationsUsageEnum value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(SelectiveSyncConfigurationsUsageEnum value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(SelectiveSyncConfigurationsUsageEnum value) =>
        value.Value;

    public static explicit operator SelectiveSyncConfigurationsUsageEnum(string value) =>
        new(value);

    /// <summary>
    /// Constant strings for enum values
    /// </summary>
    public static class Values
    {
        public const string InNextSync = "IN_NEXT_SYNC";

        public const string InLastSync = "IN_LAST_SYNC";
    }
}
