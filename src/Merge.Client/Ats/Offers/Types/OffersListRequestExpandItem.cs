using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Merge.Client.Core;

namespace Merge.Client.Ats;

[JsonConverter(typeof(EnumSerializer<OffersListRequestExpandItem>))]
public enum OffersListRequestExpandItem
{
    [EnumMember(Value = "application")]
    Application,

    [EnumMember(Value = "creator")]
    Creator,
}
