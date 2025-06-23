using System.Text.Json.Serialization;
using Merge.Client.Core;

namespace Merge.Client.FileStorage;

[JsonConverter(typeof(StringEnumSerializer<FilesRetrieveRequestExpandItem>))]
public readonly record struct FilesRetrieveRequestExpandItem : IStringEnum
{
    public static readonly FilesRetrieveRequestExpandItem Drive = new(Values.Drive);

    public static readonly FilesRetrieveRequestExpandItem Folder = new(Values.Folder);

    public static readonly FilesRetrieveRequestExpandItem Permissions = new(Values.Permissions);

    public FilesRetrieveRequestExpandItem(string value)
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
    public static FilesRetrieveRequestExpandItem FromCustom(string value)
    {
        return new FilesRetrieveRequestExpandItem(value);
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

    public static bool operator ==(FilesRetrieveRequestExpandItem value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(FilesRetrieveRequestExpandItem value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(FilesRetrieveRequestExpandItem value) => value.Value;

    public static explicit operator FilesRetrieveRequestExpandItem(string value) => new(value);

    /// <summary>
    /// Constant strings for enum values
    /// </summary>
    public static class Values
    {
        public const string Drive = "drive";

        public const string Folder = "folder";

        public const string Permissions = "permissions";
    }
}
