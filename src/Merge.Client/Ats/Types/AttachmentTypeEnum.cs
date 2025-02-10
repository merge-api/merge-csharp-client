using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Merge.Client.Core;

namespace Merge.Client.Ats;

[JsonConverter(typeof(EnumSerializer<AttachmentTypeEnum>))]
public enum AttachmentTypeEnum
{
    [EnumMember(Value = "RESUME")]
    Resume,

    [EnumMember(Value = "COVER_LETTER")]
    CoverLetter,

    [EnumMember(Value = "OFFER_LETTER")]
    OfferLetter,

    [EnumMember(Value = "OTHER")]
    Other,
}
