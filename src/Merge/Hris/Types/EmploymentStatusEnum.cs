using System.Text.Json.Serialization;
using Merge.Core;

namespace Merge.Hris;

[JsonConverter(typeof(StringEnumSerializer<EmploymentStatusEnum>))]
public readonly record struct EmploymentStatusEnum : IStringEnum
{
    public static readonly EmploymentStatusEnum Active = new(Values.Active);

    public static readonly EmploymentStatusEnum Pending = new(Values.Pending);

    public static readonly EmploymentStatusEnum Inactive = new(Values.Inactive);

    public EmploymentStatusEnum(string value)
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
    public static EmploymentStatusEnum FromCustom(string value)
    {
        return new EmploymentStatusEnum(value);
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

    public static bool operator ==(EmploymentStatusEnum value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(EmploymentStatusEnum value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(EmploymentStatusEnum value) => value.Value;

    public static explicit operator EmploymentStatusEnum(string value) => new(value);

    /// <summary>
    /// Constant strings for enum values
    /// </summary>
    public static class Values
    {
        public const string Active = "ACTIVE";

        public const string Pending = "PENDING";

        public const string Inactive = "INACTIVE";
    }
}
