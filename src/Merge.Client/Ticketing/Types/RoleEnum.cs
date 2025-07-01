using System.Text.Json.Serialization;
using Merge.Client.Core;

namespace Merge.Client.Ticketing;

[JsonConverter(typeof(StringEnumSerializer<RoleEnum>))]
[Serializable]
public readonly record struct RoleEnum : IStringEnum
{
    public static readonly RoleEnum Admin = new(Values.Admin);

    public static readonly RoleEnum Developer = new(Values.Developer);

    public static readonly RoleEnum Member = new(Values.Member);

    public static readonly RoleEnum Api = new(Values.Api);

    public static readonly RoleEnum System = new(Values.System);

    public static readonly RoleEnum MergeTeam = new(Values.MergeTeam);

    public RoleEnum(string value)
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
    public static RoleEnum FromCustom(string value)
    {
        return new RoleEnum(value);
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

    public static bool operator ==(RoleEnum value1, string value2) => value1.Value.Equals(value2);

    public static bool operator !=(RoleEnum value1, string value2) => !value1.Value.Equals(value2);

    public static explicit operator string(RoleEnum value) => value.Value;

    public static explicit operator RoleEnum(string value) => new(value);

    /// <summary>
    /// Constant strings for enum values
    /// </summary>
    [Serializable]
    public static class Values
    {
        public const string Admin = "ADMIN";

        public const string Developer = "DEVELOPER";

        public const string Member = "MEMBER";

        public const string Api = "API";

        public const string System = "SYSTEM";

        public const string MergeTeam = "MERGE_TEAM";
    }
}
