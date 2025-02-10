using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Merge.Client.Core;

namespace Merge.Client.Ats;

[JsonConverter(typeof(EnumSerializer<OffersRetrieveRequestExpand>))]
public enum OffersRetrieveRequestExpand
{
    [EnumMember(Value = "application")]
    Application,

    [EnumMember(Value = "application,creator")]
    ApplicationCreator,

    [EnumMember(Value = "creator")]
    Creator,
}
