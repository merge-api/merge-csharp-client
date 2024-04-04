using System.Text.Json.Serialization;
using System;
using Merge.Client.Utilities;

namespace Merge.Client.Ats;

[JsonConverter(typeof(TolerantEnumConverter))]
public enum AttachmentTypeEnum
{
    [EnumMember(Value = "RESUME")]
    Resume,

    [EnumMember(Value = "COVER_LETTER")]
    CoverLetter,

    [EnumMember(Value = "OFFER_LETTER")]
    OfferLetter,

    [EnumMember(Value = "OTHER")]
    Other
}
