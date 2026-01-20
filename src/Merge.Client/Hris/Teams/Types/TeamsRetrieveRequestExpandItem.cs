using System.Text.Json.Serialization;
using Merge.Client.Core;

namespace Merge.Client.Hris;

[JsonConverter(typeof(StringEnumSerializer<TeamsRetrieveRequestExpandItem>))]
[Serializable]
public readonly record struct TeamsRetrieveRequestExpandItem : IStringEnum
{
    public static readonly TeamsRetrieveRequestExpandItem ParentTeam = new(Values.ParentTeam);

    public TeamsRetrieveRequestExpandItem(string value)
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
    public static TeamsRetrieveRequestExpandItem FromCustom(string value)
    {
        return new TeamsRetrieveRequestExpandItem(value);
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

    public static bool operator ==(TeamsRetrieveRequestExpandItem value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(TeamsRetrieveRequestExpandItem value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(TeamsRetrieveRequestExpandItem value) => value.Value;

    public static explicit operator TeamsRetrieveRequestExpandItem(string value) => new(value);

    /// <summary>
    /// Constant strings for enum values
    /// </summary>
    [Serializable]
    public static class Values
    {
        public const string ParentTeam = "parent_team";
    }
}
