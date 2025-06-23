using System.Text.Json.Serialization;
using Merge.Client.Core;

namespace Merge.Client.Hris;

[JsonConverter(typeof(StringEnumSerializer<GroupTypeEnum>))]
public readonly record struct GroupTypeEnum : IStringEnum
{
    public static readonly GroupTypeEnum Team = new(Values.Team);

    public static readonly GroupTypeEnum Department = new(Values.Department);

    public static readonly GroupTypeEnum CostCenter = new(Values.CostCenter);

    public static readonly GroupTypeEnum BusinessUnit = new(Values.BusinessUnit);

    public static readonly GroupTypeEnum Group = new(Values.Group);

    public GroupTypeEnum(string value)
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
    public static GroupTypeEnum FromCustom(string value)
    {
        return new GroupTypeEnum(value);
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

    public static bool operator ==(GroupTypeEnum value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(GroupTypeEnum value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(GroupTypeEnum value) => value.Value;

    public static explicit operator GroupTypeEnum(string value) => new(value);

    /// <summary>
    /// Constant strings for enum values
    /// </summary>
    public static class Values
    {
        public const string Team = "TEAM";

        public const string Department = "DEPARTMENT";

        public const string CostCenter = "COST_CENTER";

        public const string BusinessUnit = "BUSINESS_UNIT";

        public const string Group = "GROUP";
    }
}
