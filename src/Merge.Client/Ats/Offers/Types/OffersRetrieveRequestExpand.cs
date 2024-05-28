using System.Runtime.Serialization;

#nullable enable

namespace Merge.Client.Ats;

public enum OffersRetrieveRequestExpand
{
    [EnumMember(Value = "application")]
    Application,

    [EnumMember(Value = "application,creator")]
    ApplicationCreator,

    [EnumMember(Value = "creator")]
    Creator
}
