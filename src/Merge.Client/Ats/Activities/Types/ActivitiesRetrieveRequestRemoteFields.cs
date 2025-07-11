using System.Text.Json.Serialization;
using Merge.Client.Core;

namespace Merge.Client.Ats;

[JsonConverter(typeof(StringEnumSerializer<ActivitiesRetrieveRequestRemoteFields>))]
[Serializable]
public readonly record struct ActivitiesRetrieveRequestRemoteFields : IStringEnum
{
    public static readonly ActivitiesRetrieveRequestRemoteFields ActivityType = new(
        Values.ActivityType
    );

    public static readonly ActivitiesRetrieveRequestRemoteFields ActivityTypeVisibility = new(
        Values.ActivityTypeVisibility
    );

    public static readonly ActivitiesRetrieveRequestRemoteFields Visibility = new(
        Values.Visibility
    );

    public ActivitiesRetrieveRequestRemoteFields(string value)
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
    public static ActivitiesRetrieveRequestRemoteFields FromCustom(string value)
    {
        return new ActivitiesRetrieveRequestRemoteFields(value);
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

    public static bool operator ==(ActivitiesRetrieveRequestRemoteFields value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(ActivitiesRetrieveRequestRemoteFields value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(ActivitiesRetrieveRequestRemoteFields value) =>
        value.Value;

    public static explicit operator ActivitiesRetrieveRequestRemoteFields(string value) =>
        new(value);

    /// <summary>
    /// Constant strings for enum values
    /// </summary>
    [Serializable]
    public static class Values
    {
        public const string ActivityType = "activity_type";

        public const string ActivityTypeVisibility = "activity_type,visibility";

        public const string Visibility = "visibility";
    }
}
