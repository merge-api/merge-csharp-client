using System.Text.Json.Serialization;
using Merge.Core;

namespace Merge.Hris.Locations;

[JsonConverter(typeof(StringEnumSerializer<LocationsRetrieveRequestShowEnumOrigins>))]
public readonly record struct LocationsRetrieveRequestShowEnumOrigins : IStringEnum
{
    public static readonly LocationsRetrieveRequestShowEnumOrigins Country = new(Values.Country);

    public static readonly LocationsRetrieveRequestShowEnumOrigins CountryLocationType = new(
        Values.CountryLocationType
    );

    public static readonly LocationsRetrieveRequestShowEnumOrigins LocationType = new(
        Values.LocationType
    );

    public LocationsRetrieveRequestShowEnumOrigins(string value)
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
    public static LocationsRetrieveRequestShowEnumOrigins FromCustom(string value)
    {
        return new LocationsRetrieveRequestShowEnumOrigins(value);
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

    public static bool operator ==(LocationsRetrieveRequestShowEnumOrigins value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(LocationsRetrieveRequestShowEnumOrigins value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(LocationsRetrieveRequestShowEnumOrigins value) =>
        value.Value;

    public static explicit operator LocationsRetrieveRequestShowEnumOrigins(string value) =>
        new(value);

    /// <summary>
    /// Constant strings for enum values
    /// </summary>
    public static class Values
    {
        public const string Country = "country";

        public const string CountryLocationType = "country,location_type";

        public const string LocationType = "location_type";
    }
}
