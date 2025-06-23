using System.Text.Json.Serialization;
using Merge.Client.Core;

namespace Merge.Client.Ats;

[JsonConverter(typeof(StringEnumSerializer<ScheduledInterviewStatusEnum>))]
public readonly record struct ScheduledInterviewStatusEnum : IStringEnum
{
    public static readonly ScheduledInterviewStatusEnum Scheduled = new(Values.Scheduled);

    public static readonly ScheduledInterviewStatusEnum AwaitingFeedback = new(
        Values.AwaitingFeedback
    );

    public static readonly ScheduledInterviewStatusEnum Complete = new(Values.Complete);

    public ScheduledInterviewStatusEnum(string value)
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
    public static ScheduledInterviewStatusEnum FromCustom(string value)
    {
        return new ScheduledInterviewStatusEnum(value);
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

    public static bool operator ==(ScheduledInterviewStatusEnum value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(ScheduledInterviewStatusEnum value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(ScheduledInterviewStatusEnum value) => value.Value;

    public static explicit operator ScheduledInterviewStatusEnum(string value) => new(value);

    /// <summary>
    /// Constant strings for enum values
    /// </summary>
    public static class Values
    {
        public const string Scheduled = "SCHEDULED";

        public const string AwaitingFeedback = "AWAITING_FEEDBACK";

        public const string Complete = "COMPLETE";
    }
}
