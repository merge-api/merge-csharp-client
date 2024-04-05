using System.Runtime.Serialization;

namespace Merge.Client.Ats;

public enum VeteranStatusEnum
{
    [EnumMember(Value = "I_AM_NOT_A_PROTECTED_VETERAN")]
    IAmNotAProtectedVeteran,

    [EnumMember(Value = "I_IDENTIFY_AS_ONE_OR_MORE_OF_THE_CLASSIFICATIONS_OF_A_PROTECTED_VETERAN")]
    IIdentifyAsOneOrMoreOfTheClassificationsOfAProtectedVeteran,

    [EnumMember(Value = "I_DONT_WISH_TO_ANSWER")]
    IDontWishToAnswer
}
