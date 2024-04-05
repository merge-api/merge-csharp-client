using System.Runtime.Serialization;

namespace Merge.Client.Hris;

public enum RelationshipEnum
{
    [EnumMember(Value = "CHILD")]
    Child,

    [EnumMember(Value = "SPOUSE")]
    Spouse,

    [EnumMember(Value = "DOMESTIC_PARTNER")]
    DomesticPartner
}
