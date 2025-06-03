using System.Text.Json.Serialization;
using Merge.Core;

namespace Merge.Crm;

[JsonConverter(typeof(StringEnumSerializer<TaskStatusEnum>))]
public readonly record struct TaskStatusEnum : IStringEnum
{
    public static readonly TaskStatusEnum Open = new(Values.Open);

    public static readonly TaskStatusEnum Closed = new(Values.Closed);

    public TaskStatusEnum(string value)
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
    public static TaskStatusEnum FromCustom(string value)
    {
        return new TaskStatusEnum(value);
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

    public static bool operator ==(TaskStatusEnum value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(TaskStatusEnum value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(TaskStatusEnum value) => value.Value;

    public static explicit operator TaskStatusEnum(string value) => new(value);

    /// <summary>
    /// Constant strings for enum values
    /// </summary>
    public static class Values
    {
        public const string Open = "OPEN";

        public const string Closed = "CLOSED";
    }
}
