using System.Text.Json.Serialization;
using Merge.Client.Core;

namespace Merge.Client.Hris;

[JsonConverter(typeof(StringEnumSerializer<LocationsListRequestLocationType>))]
[Serializable]
public readonly record struct LocationsListRequestLocationType : IStringEnum
{
    public static readonly LocationsListRequestLocationType Home = new(Values.Home);

    public static readonly LocationsListRequestLocationType Work = new(Values.Work);

    public LocationsListRequestLocationType(string value)
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
    public static LocationsListRequestLocationType FromCustom(string value)
    {
        return new LocationsListRequestLocationType(value);
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

    public static bool operator ==(LocationsListRequestLocationType value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(LocationsListRequestLocationType value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(LocationsListRequestLocationType value) => value.Value;

    public static explicit operator LocationsListRequestLocationType(string value) => new(value);

    /// <summary>
    /// Constant strings for enum values
    /// </summary>
    [Serializable]
    public static class Values
    {
        public const string Home = "HOME";

        public const string Work = "WORK";
    }
}
