using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Merge.Client.Core;

namespace Merge.Client.Ats;

[JsonConverter(typeof(EnumSerializer<OffersRetrieveRequestExpandItem>))]
public enum OffersRetrieveRequestExpandItem
{
    [EnumMember(Value = "application")]
    Application,

    [EnumMember(Value = "creator")]
    Creator,
}
