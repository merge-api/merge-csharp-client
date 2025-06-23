using System.Text.Json.Serialization;
using Merge.Client.Core;

namespace Merge.Client.FileStorage;

[JsonConverter(typeof(StringEnumSerializer<FoldersListRequestExpandItem>))]
public readonly record struct FoldersListRequestExpandItem : IStringEnum
{
    public static readonly FoldersListRequestExpandItem Drive = new(Values.Drive);

    public static readonly FoldersListRequestExpandItem ParentFolder = new(Values.ParentFolder);

    public static readonly FoldersListRequestExpandItem Permissions = new(Values.Permissions);

    public FoldersListRequestExpandItem(string value)
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
    public static FoldersListRequestExpandItem FromCustom(string value)
    {
        return new FoldersListRequestExpandItem(value);
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

    public static bool operator ==(FoldersListRequestExpandItem value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(FoldersListRequestExpandItem value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(FoldersListRequestExpandItem value) => value.Value;

    public static explicit operator FoldersListRequestExpandItem(string value) => new(value);

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
