using System.Text.Json.Serialization;
using Merge.Client.Core;

namespace Merge.Client.Ats;

[JsonConverter(typeof(StringEnumSerializer<InterviewsRetrieveRequestShowEnumOrigins>))]
[Serializable]
public readonly record struct InterviewsRetrieveRequestShowEnumOrigins : IStringEnum
{
    public static readonly InterviewsRetrieveRequestShowEnumOrigins Status = new(Values.Status);

    public InterviewsRetrieveRequestShowEnumOrigins(string value)
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
    public static InterviewsRetrieveRequestShowEnumOrigins FromCustom(string value)
    {
        return new InterviewsRetrieveRequestShowEnumOrigins(value);
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

    public static bool operator ==(
        InterviewsRetrieveRequestShowEnumOrigins value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        InterviewsRetrieveRequestShowEnumOrigins value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(InterviewsRetrieveRequestShowEnumOrigins value) =>
        value.Value;

    public static explicit operator InterviewsRetrieveRequestShowEnumOrigins(string value) =>
        new(value);

    /// <summary>
    /// Constant strings for enum values
    /// </summary>
    [Serializable]
    public static class Values
    {
        public const string Status = "status";
    }
}
