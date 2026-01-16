using System.Text.Json.Serialization;
using Merge.Client.Core;

namespace Merge.Client.Accounting;

[JsonConverter(typeof(StringEnumSerializer<TrackingCategoriesRetrieveRequestRemoteFields>))]
[Serializable]
public readonly record struct TrackingCategoriesRetrieveRequestRemoteFields : IStringEnum
{
    public static readonly TrackingCategoriesRetrieveRequestRemoteFields Status = new(
        Values.Status
    );

    public TrackingCategoriesRetrieveRequestRemoteFields(string value)
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
    public static TrackingCategoriesRetrieveRequestRemoteFields FromCustom(string value)
    {
        return new TrackingCategoriesRetrieveRequestRemoteFields(value);
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
        TrackingCategoriesRetrieveRequestRemoteFields value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        TrackingCategoriesRetrieveRequestRemoteFields value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(TrackingCategoriesRetrieveRequestRemoteFields value) =>
        value.Value;

    public static explicit operator TrackingCategoriesRetrieveRequestRemoteFields(string value) =>
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
