using System.Text.Json.Serialization;
using Merge.Client.Core;

namespace Merge.Client.Ats;

[JsonConverter(typeof(StringEnumSerializer<UrlTypeEnum>))]
[Serializable]
public readonly record struct UrlTypeEnum : IStringEnum
{
    public static readonly UrlTypeEnum Personal = new(Values.Personal);

    public static readonly UrlTypeEnum Company = new(Values.Company);

    public static readonly UrlTypeEnum Portfolio = new(Values.Portfolio);

    public static readonly UrlTypeEnum Blog = new(Values.Blog);

    public static readonly UrlTypeEnum SocialMedia = new(Values.SocialMedia);

    public static readonly UrlTypeEnum Other = new(Values.Other);

    public static readonly UrlTypeEnum JobPosting = new(Values.JobPosting);

    public UrlTypeEnum(string value)
    {
        Value = value;
    }

    /// <summary>
    /// The string value of the enum.
    /// </summary>
    public string Value { get; }

    /// <summary>
    /// Create a string enum with the given value.
    /// </summary>
    public static UrlTypeEnum FromCustom(string value)
    {
        return new UrlTypeEnum(value);
    }

    public bool Equals(string? other)
    {
        return Value.Equals(other);
    }

    /// <summary>
    /// Returns the string value of the enum.
    /// </summary>
    public override string ToString()
    {
        return Value;
    }

    public static bool operator ==(UrlTypeEnum value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(UrlTypeEnum value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(UrlTypeEnum value) => value.Value;

    public static explicit operator UrlTypeEnum(string value) => new(value);

    /// <summary>
    /// Constant strings for enum values
    /// </summary>
    [Serializable]
    public static class Values
    {
        public const string Personal = "PERSONAL";

        public const string Company = "COMPANY";

        public const string Portfolio = "PORTFOLIO";

        public const string Blog = "BLOG";

        public const string SocialMedia = "SOCIAL_MEDIA";

        public const string Other = "OTHER";

        public const string JobPosting = "JOB_POSTING";
    }
}
