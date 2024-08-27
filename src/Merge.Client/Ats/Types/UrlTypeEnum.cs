using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Merge.Client.Core;

#nullable enable

namespace Merge.Client.Ats;

[JsonConverter(typeof(StringEnumSerializer<UrlTypeEnum>))]
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
    JobPosting,
}
