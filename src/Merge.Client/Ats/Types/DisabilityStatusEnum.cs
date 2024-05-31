using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Merge.Client.Ats;
using Merge.Client.Core;

#nullable enable

namespace Merge.Client.Ats;

[JsonConverter(typeof(StringEnumSerializer<DisabilityStatusEnum>))]
public enum DisabilityStatusEnum
{
    [EnumMember(Value = "YES_I_HAVE_A_DISABILITY_OR_PREVIOUSLY_HAD_A_DISABILITY")]
    YesIHaveADisabilityOrPreviouslyHadADisability,

    [EnumMember(Value = "NO_I_DONT_HAVE_A_DISABILITY")]
    NoIDontHaveADisability,

    [EnumMember(Value = "I_DONT_WISH_TO_ANSWER")]
    IDontWishToAnswer
}
