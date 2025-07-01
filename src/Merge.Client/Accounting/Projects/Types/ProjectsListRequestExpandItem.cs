using System.Text.Json.Serialization;
using Merge.Client.Core;

namespace Merge.Client.Accounting;

[JsonConverter(typeof(StringEnumSerializer<ProjectsListRequestExpandItem>))]
[Serializable]
public readonly record struct ProjectsListRequestExpandItem : IStringEnum
{
    public static readonly ProjectsListRequestExpandItem Company = new(Values.Company);

    public static readonly ProjectsListRequestExpandItem Contact = new(Values.Contact);

    public ProjectsListRequestExpandItem(string value)
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
    public static ProjectsListRequestExpandItem FromCustom(string value)
    {
        return new ProjectsListRequestExpandItem(value);
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

    public static bool operator ==(ProjectsListRequestExpandItem value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(ProjectsListRequestExpandItem value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(ProjectsListRequestExpandItem value) => value.Value;

    public static explicit operator ProjectsListRequestExpandItem(string value) => new(value);

    /// <summary>
    /// Constant strings for enum values
    /// </summary>
    [Serializable]
    public static class Values
    {
        public const string Company = "company";

        public const string Contact = "contact";
    }
}
