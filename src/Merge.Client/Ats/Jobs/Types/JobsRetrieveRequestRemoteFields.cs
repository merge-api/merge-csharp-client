using System.Text.Json.Serialization;
using Merge.Client.Core;

namespace Merge.Client.Ats;

[JsonConverter(typeof(StringEnumSerializer<JobsRetrieveRequestRemoteFields>))]
[Serializable]
public readonly record struct JobsRetrieveRequestRemoteFields : IStringEnum
{
    public static readonly JobsRetrieveRequestRemoteFields Status = new(Values.Status);

    public JobsRetrieveRequestRemoteFields(string value)
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
    public static JobsRetrieveRequestRemoteFields FromCustom(string value)
    {
        return new JobsRetrieveRequestRemoteFields(value);
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

    public static bool operator ==(JobsRetrieveRequestRemoteFields value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(JobsRetrieveRequestRemoteFields value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(JobsRetrieveRequestRemoteFields value) => value.Value;

    public static explicit operator JobsRetrieveRequestRemoteFields(string value) => new(value);

    /// <summary>
    /// Constant strings for enum values
    /// </summary>
    [Serializable]
    public static class Values
    {
        public const string Status = "status";
    }
}
