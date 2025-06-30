using System.Text.Json.Serialization;
using Merge.Client.Core;

namespace Merge.Client.Accounting;

[JsonConverter(typeof(StringEnumSerializer<ProjectsRetrieveRequestExpandItem>))]
[Serializable]
public readonly record struct ProjectsRetrieveRequestExpandItem : IStringEnum
{
    public static readonly ProjectsRetrieveRequestExpandItem Company = new(Values.Company);

    public static readonly ProjectsRetrieveRequestExpandItem Contact = new(Values.Contact);

    public ProjectsRetrieveRequestExpandItem(string value)
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
    public static ProjectsRetrieveRequestExpandItem FromCustom(string value)
    {
        return new ProjectsRetrieveRequestExpandItem(value);
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

    public static bool operator ==(ProjectsRetrieveRequestExpandItem value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(ProjectsRetrieveRequestExpandItem value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(ProjectsRetrieveRequestExpandItem value) => value.Value;

    public static explicit operator ProjectsRetrieveRequestExpandItem(string value) => new(value);

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
