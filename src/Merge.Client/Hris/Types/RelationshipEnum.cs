using System.Text.Json.Serialization;
using System;
using Merge.Client.Utilities;

namespace Merge.Client.Hris;

[JsonConverter(typeof(TolerantEnumConverter))]
public enum RelationshipEnum
{
    [EnumMember(Value = "CHILD")]
    Child,

    [EnumMember(Value = "SPOUSE")]
    Spouse,

    [EnumMember(Value = "DOMESTIC_PARTNER")]
    DomesticPartner
}
