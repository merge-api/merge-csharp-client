using System.Runtime.Serialization;

#nullable enable

namespace Merge.Client.Ats;

public enum UrlTypeEnum
{
    [EnumMember(Value = "PERSONAL")]
    Personal,

    [EnumMember(Value = "COMPANY")]
    Company,

    [EnumMember(Value = "PORTFOLIO")]
    Portfolio,

    [EnumMember(Value = "BLOG")]
    Blog,

    [EnumMember(Value = "SOCIAL_MEDIA")]
    SocialMedia,

    [EnumMember(Value = "OTHER")]
    Other,

    [EnumMember(Value = "JOB_POSTING")]
    JobPosting
}
