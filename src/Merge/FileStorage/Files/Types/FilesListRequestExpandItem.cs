using System.Text.Json.Serialization;
using Merge.Core;

namespace Merge.FileStorage.Files;

[JsonConverter(typeof(StringEnumSerializer<FilesListRequestExpandItem>))]
public readonly record struct FilesListRequestExpandItem : IStringEnum
{
    public static readonly FilesListRequestExpandItem Drive = new(Values.Drive);

    public static readonly FilesListRequestExpandItem Folder = new(Values.Folder);

    public static readonly FilesListRequestExpandItem Permissions = new(Values.Permissions);

    public FilesListRequestExpandItem(string value)
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
    public static FilesListRequestExpandItem FromCustom(string value)
    {
        return new FilesListRequestExpandItem(value);
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

    public static bool operator ==(FilesListRequestExpandItem value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(FilesListRequestExpandItem value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(FilesListRequestExpandItem value) => value.Value;

    public static explicit operator FilesListRequestExpandItem(string value) => new(value);

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
