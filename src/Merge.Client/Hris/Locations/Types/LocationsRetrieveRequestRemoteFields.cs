using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Merge.Client.Core;

#nullable enable

namespace Merge.Client.Hris;

[JsonConverter(typeof(StringEnumSerializer<LocationsRetrieveRequestRemoteFields>))]
public enum LocationsRetrieveRequestRemoteFields
{
    [EnumMember(Value = "country")]
    Country,

    [EnumMember(Value = "country,location_type")]
    CountryLocationType,

    [EnumMember(Value = "location_type")]
    LocationType,
}
