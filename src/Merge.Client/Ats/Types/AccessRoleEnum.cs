using System.Text.Json.Serialization;
using Merge.Client.Core;

namespace Merge.Client.Ats;

[JsonConverter(typeof(StringEnumSerializer<AccessRoleEnum>))]
[Serializable]
public readonly record struct AccessRoleEnum : IStringEnum
{
    public static readonly AccessRoleEnum SuperAdmin = new(Values.SuperAdmin);

    public static readonly AccessRoleEnum Admin = new(Values.Admin);

    public static readonly AccessRoleEnum TeamMember = new(Values.TeamMember);

    public static readonly AccessRoleEnum LimitedTeamMember = new(Values.LimitedTeamMember);

    public static readonly AccessRoleEnum Interviewer = new(Values.Interviewer);

    public AccessRoleEnum(string value)
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
    public static AccessRoleEnum FromCustom(string value)
    {
        return new AccessRoleEnum(value);
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

    public static bool operator ==(AccessRoleEnum value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(AccessRoleEnum value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(AccessRoleEnum value) => value.Value;

    public static explicit operator AccessRoleEnum(string value) => new(value);

    /// <summary>
    /// Constant strings for enum values
    /// </summary>
    [Serializable]
    public static class Values
    {
        public const string SuperAdmin = "SUPER_ADMIN";

        public const string Admin = "ADMIN";

        public const string TeamMember = "TEAM_MEMBER";

        public const string LimitedTeamMember = "LIMITED_TEAM_MEMBER";

        public const string Interviewer = "INTERVIEWER";
    }
}
