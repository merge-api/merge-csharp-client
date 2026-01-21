using System.Text.Json.Serialization;
using Merge.Client.Core;

namespace Merge.Client.Accounting;

[JsonConverter(typeof(StringEnumSerializer<TrackingCategoriesListRequestRemoteFields>))]
[Serializable]
public readonly record struct TrackingCategoriesListRequestRemoteFields : IStringEnum
{
    public static readonly TrackingCategoriesListRequestRemoteFields Status = new(Values.Status);

    public TrackingCategoriesListRequestRemoteFields(string value)
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
    public static TrackingCategoriesListRequestRemoteFields FromCustom(string value)
    {
        return new TrackingCategoriesListRequestRemoteFields(value);
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
        TrackingCategoriesListRequestRemoteFields value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        TrackingCategoriesListRequestRemoteFields value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(TrackingCategoriesListRequestRemoteFields value) =>
        value.Value;

    public static explicit operator TrackingCategoriesListRequestRemoteFields(string value) =>
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
