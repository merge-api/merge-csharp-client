using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Merge.Client.Core;

namespace Merge.Client.Hris;

[JsonConverter(typeof(EnumSerializer<RelationshipEnum>))]
public enum RelationshipEnum
{
    [EnumMember(Value = "CHILD")]
    Child,

    [EnumMember(Value = "SPOUSE")]
    Spouse,

    [EnumMember(Value = "DOMESTIC_PARTNER")]
    DomesticPartner,
}
