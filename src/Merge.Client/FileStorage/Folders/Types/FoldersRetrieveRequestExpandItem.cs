using System.Text.Json.Serialization;
using Merge.Client.Core;

namespace Merge.Client.FileStorage;

[JsonConverter(typeof(StringEnumSerializer<FoldersRetrieveRequestExpandItem>))]
public readonly record struct FoldersRetrieveRequestExpandItem : IStringEnum
{
    public static readonly FoldersRetrieveRequestExpandItem Drive = new(Values.Drive);

    public static readonly FoldersRetrieveRequestExpandItem ParentFolder = new(Values.ParentFolder);

    public static readonly FoldersRetrieveRequestExpandItem Permissions = new(Values.Permissions);

    public FoldersRetrieveRequestExpandItem(string value)
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
    public static FoldersRetrieveRequestExpandItem FromCustom(string value)
    {
        return new FoldersRetrieveRequestExpandItem(value);
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

    public static bool operator ==(FoldersRetrieveRequestExpandItem value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(FoldersRetrieveRequestExpandItem value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(FoldersRetrieveRequestExpandItem value) => value.Value;

    public static explicit operator FoldersRetrieveRequestExpandItem(string value) => new(value);

    /// <summary>
    /// Constant strings for enum values
    /// </summary>
    public static class Values
    {
        public const string Drive = "drive";

        public const string ParentFolder = "parent_folder";

        public const string Permissions = "permissions";
    }
}
