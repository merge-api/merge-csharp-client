using System.Text.Json.Serialization;
using Merge.Client.Core;

namespace Merge.Client.Hris;

[JsonConverter(typeof(StringEnumSerializer<LocationsListRequestRemoteFields>))]
[Serializable]
public readonly record struct LocationsListRequestRemoteFields : IStringEnum
{
    public static readonly LocationsListRequestRemoteFields Country = new(Values.Country);

    public static readonly LocationsListRequestRemoteFields CountryLocationType = new(
        Values.CountryLocationType
    );

    public static readonly LocationsListRequestRemoteFields LocationType = new(Values.LocationType);

    public LocationsListRequestRemoteFields(string value)
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
    public static LocationsListRequestRemoteFields FromCustom(string value)
    {
        return new LocationsListRequestRemoteFields(value);
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

    public static bool operator ==(LocationsListRequestRemoteFields value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(LocationsListRequestRemoteFields value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(LocationsListRequestRemoteFields value) => value.Value;

    public static explicit operator LocationsListRequestRemoteFields(string value) => new(value);

    /// <summary>
    /// Constant strings for enum values
    /// </summary>
    [Serializable]
    public static class Values
    {
        public const string Country = "country";

        public const string CountryLocationType = "country,location_type";

        public const string LocationType = "location_type";
    }
}
