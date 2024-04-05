using System.Runtime.Serialization;

namespace Merge.Client.Ats;

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
