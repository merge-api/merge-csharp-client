using System.Text.Json.Serialization;
using Merge.Client.Core;

namespace Merge.Client.Hris;

[JsonConverter(typeof(StringEnumSerializer<TeamsListRequestExpandItem>))]
[Serializable]
public readonly record struct TeamsListRequestExpandItem : IStringEnum
{
    public static readonly TeamsListRequestExpandItem ParentTeam = new(Values.ParentTeam);

    public TeamsListRequestExpandItem(string value)
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
    public static TeamsListRequestExpandItem FromCustom(string value)
    {
        return new TeamsListRequestExpandItem(value);
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

    public static bool operator ==(TeamsListRequestExpandItem value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(TeamsListRequestExpandItem value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(TeamsListRequestExpandItem value) => value.Value;

    public static explicit operator TeamsListRequestExpandItem(string value) => new(value);

    /// <summary>
    /// Constant strings for enum values
    /// </summary>
    [Serializable]
    public static class Values
    {
        public const string ParentTeam = "parent_team";
    }
}
