using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Merge.Client.Ats;
using Merge.Client.Core;

#nullable enable

namespace Merge.Client.Ats;

[JsonConverter(typeof(StringEnumSerializer<OffersListRequestExpand>))]
public enum OffersListRequestExpand
{
    [EnumMember(Value = "application")]
    Application,

    [EnumMember(Value = "application,creator")]
    ApplicationCreator,

    [EnumMember(Value = "creator")]
    Creator
}
