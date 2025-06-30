using System.Text.Json.Serialization;
using Merge.Client.Core;

namespace Merge.Client.FileStorage;

[JsonConverter(typeof(StringEnumSerializer<FilesListRequestOrderBy>))]
[Serializable]
public readonly record struct FilesListRequestOrderBy : IStringEnum
{
    public static readonly FilesListRequestOrderBy CreatedAtDescending = new(
        Values.CreatedAtDescending
    );

    public static readonly FilesListRequestOrderBy ModifiedAtDescending = new(
        Values.ModifiedAtDescending
    );

    public static readonly FilesListRequestOrderBy CreatedAtAscending = new(
        Values.CreatedAtAscending
    );

    public static readonly FilesListRequestOrderBy ModifiedAtAscending = new(
        Values.ModifiedAtAscending
    );

    public FilesListRequestOrderBy(string value)
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
    public static FilesListRequestOrderBy FromCustom(string value)
    {
        return new FilesListRequestOrderBy(value);
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

    public static bool operator ==(FilesListRequestOrderBy value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(FilesListRequestOrderBy value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(FilesListRequestOrderBy value) => value.Value;

    public static explicit operator FilesListRequestOrderBy(string value) => new(value);

    /// <summary>
    /// Constant strings for enum values
    /// </summary>
    [Serializable]
    public static class Values
    {
        public const string CreatedAtDescending = "-created_at";

        public const string ModifiedAtDescending = "-modified_at";

        public const string CreatedAtAscending = "created_at";

        public const string ModifiedAtAscending = "modified_at";
    }
}
