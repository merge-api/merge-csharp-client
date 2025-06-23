using System.Text.Json.Serialization;
using Merge.Client.Core;

namespace Merge.Client.Accounting;

[JsonConverter(typeof(StringEnumSerializer<AsyncPostTaskStatusEnum>))]
public readonly record struct AsyncPostTaskStatusEnum : IStringEnum
{
    public static readonly AsyncPostTaskStatusEnum Queued = new(Values.Queued);

    public static readonly AsyncPostTaskStatusEnum InProgress = new(Values.InProgress);

    public static readonly AsyncPostTaskStatusEnum Completed = new(Values.Completed);

    public static readonly AsyncPostTaskStatusEnum Failure = new(Values.Failure);

    public AsyncPostTaskStatusEnum(string value)
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
    public static AsyncPostTaskStatusEnum FromCustom(string value)
    {
        return new AsyncPostTaskStatusEnum(value);
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

    public static bool operator ==(AsyncPostTaskStatusEnum value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(AsyncPostTaskStatusEnum value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(AsyncPostTaskStatusEnum value) => value.Value;

    public static explicit operator AsyncPostTaskStatusEnum(string value) => new(value);

    /// <summary>
    /// Constant strings for enum values
    /// </summary>
    public static class Values
    {
        public const string Queued = "QUEUED";

        public const string InProgress = "IN_PROGRESS";

        public const string Completed = "COMPLETED";

        public const string Failure = "FAILURE";
    }
}
