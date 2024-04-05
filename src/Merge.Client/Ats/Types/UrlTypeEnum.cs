using System.Text.Json.Serialization;
using System;
using Merge.Client.Utilities;

namespace Merge.Client.Ats;

[JsonConverter(typeof(TolerantEnumConverter))]
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
