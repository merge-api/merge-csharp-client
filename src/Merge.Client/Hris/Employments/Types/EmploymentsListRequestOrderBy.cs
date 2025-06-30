using System.Text.Json.Serialization;
using Merge.Client.Core;

namespace Merge.Client.Hris;

[JsonConverter(typeof(StringEnumSerializer<EmploymentsListRequestOrderBy>))]
[Serializable]
public readonly record struct EmploymentsListRequestOrderBy : IStringEnum
{
    public static readonly EmploymentsListRequestOrderBy EffectiveDateDescending = new(
        Values.EffectiveDateDescending
    );

    public static readonly EmploymentsListRequestOrderBy EffectiveDateAscending = new(
        Values.EffectiveDateAscending
    );

    public EmploymentsListRequestOrderBy(string value)
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
    public static EmploymentsListRequestOrderBy FromCustom(string value)
    {
        return new EmploymentsListRequestOrderBy(value);
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

    public static bool operator ==(EmploymentsListRequestOrderBy value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(EmploymentsListRequestOrderBy value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(EmploymentsListRequestOrderBy value) => value.Value;

    public static explicit operator EmploymentsListRequestOrderBy(string value) => new(value);

    /// <summary>
    /// Constant strings for enum values
    /// </summary>
    [Serializable]
    public static class Values
    {
        public const string EffectiveDateDescending = "-effective_date";

        public const string EffectiveDateAscending = "effective_date";
    }
}
