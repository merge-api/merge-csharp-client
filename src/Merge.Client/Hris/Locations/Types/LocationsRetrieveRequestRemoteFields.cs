using System.Text.Json.Serialization;
using Merge.Client.Core;

namespace Merge.Client.Hris;

[JsonConverter(typeof(StringEnumSerializer<LocationsRetrieveRequestRemoteFields>))]
public readonly record struct LocationsRetrieveRequestRemoteFields : IStringEnum
{
    public static readonly LocationsRetrieveRequestRemoteFields Country = new(Values.Country);

    public static readonly LocationsRetrieveRequestRemoteFields CountryLocationType = new(
        Values.CountryLocationType
    );

    public static readonly LocationsRetrieveRequestRemoteFields LocationType = new(
        Values.LocationType
    );

    public LocationsRetrieveRequestRemoteFields(string value)
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
    public static LocationsRetrieveRequestRemoteFields FromCustom(string value)
    {
        return new LocationsRetrieveRequestRemoteFields(value);
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

    public static bool operator ==(LocationsRetrieveRequestRemoteFields value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(LocationsRetrieveRequestRemoteFields value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(LocationsRetrieveRequestRemoteFields value) =>
        value.Value;

    public static explicit operator LocationsRetrieveRequestRemoteFields(string value) =>
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
