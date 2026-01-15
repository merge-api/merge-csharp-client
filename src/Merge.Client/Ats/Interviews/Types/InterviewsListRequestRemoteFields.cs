using System.Text.Json.Serialization;
using Merge.Client.Core;

namespace Merge.Client.Ats;

[JsonConverter(typeof(StringEnumSerializer<InterviewsListRequestRemoteFields>))]
[Serializable]
public readonly record struct InterviewsListRequestRemoteFields : IStringEnum
{
    public static readonly InterviewsListRequestRemoteFields Status = new(Values.Status);

    public InterviewsListRequestRemoteFields(string value)
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
    public static InterviewsListRequestRemoteFields FromCustom(string value)
    {
        return new InterviewsListRequestRemoteFields(value);
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

    public static bool operator ==(InterviewsListRequestRemoteFields value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(InterviewsListRequestRemoteFields value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(InterviewsListRequestRemoteFields value) => value.Value;

    public static explicit operator InterviewsListRequestRemoteFields(string value) => new(value);

    /// <summary>
    /// Constant strings for enum values
    /// </summary>
    [Serializable]
    public static class Values
    {
        public const string Status = "status";
    }
}
