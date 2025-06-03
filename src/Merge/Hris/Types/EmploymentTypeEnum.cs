using System.Text.Json.Serialization;
using Merge.Core;

namespace Merge.Hris;

[JsonConverter(typeof(StringEnumSerializer<EmploymentTypeEnum>))]
public readonly record struct EmploymentTypeEnum : IStringEnum
{
    public static readonly EmploymentTypeEnum FullTime = new(Values.FullTime);

    public static readonly EmploymentTypeEnum PartTime = new(Values.PartTime);

    public static readonly EmploymentTypeEnum Intern = new(Values.Intern);

    public static readonly EmploymentTypeEnum Contractor = new(Values.Contractor);

    public static readonly EmploymentTypeEnum Freelance = new(Values.Freelance);

    public EmploymentTypeEnum(string value)
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
    public static EmploymentTypeEnum FromCustom(string value)
    {
        return new EmploymentTypeEnum(value);
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

    public static bool operator ==(EmploymentTypeEnum value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(EmploymentTypeEnum value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(EmploymentTypeEnum value) => value.Value;

    public static explicit operator EmploymentTypeEnum(string value) => new(value);

    /// <summary>
    /// Constant strings for enum values
    /// </summary>
    public static class Values
    {
        public const string FullTime = "FULL_TIME";

        public const string PartTime = "PART_TIME";

        public const string Intern = "INTERN";

        public const string Contractor = "CONTRACTOR";

        public const string Freelance = "FREELANCE";
    }
}
