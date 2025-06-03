using System.Text.Json.Serialization;
using Merge.Core;

namespace Merge.Crm;

[JsonConverter(typeof(StringEnumSerializer<ActivityTypeEnum>))]
public readonly record struct ActivityTypeEnum : IStringEnum
{
    public static readonly ActivityTypeEnum Call = new(Values.Call);

    public static readonly ActivityTypeEnum Meeting = new(Values.Meeting);

    public static readonly ActivityTypeEnum Email = new(Values.Email);

    public ActivityTypeEnum(string value)
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
    public static ActivityTypeEnum FromCustom(string value)
    {
        return new ActivityTypeEnum(value);
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

    public static bool operator ==(ActivityTypeEnum value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(ActivityTypeEnum value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(ActivityTypeEnum value) => value.Value;

    public static explicit operator ActivityTypeEnum(string value) => new(value);

    /// <summary>
    /// Constant strings for enum values
    /// </summary>
    public static class Values
    {
        public const string Call = "CALL";

        public const string Meeting = "MEETING";

        public const string Email = "EMAIL";
    }
}
