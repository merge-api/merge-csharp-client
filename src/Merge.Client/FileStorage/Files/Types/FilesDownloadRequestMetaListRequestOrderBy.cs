using System.Text.Json.Serialization;
using Merge.Client.Core;

namespace Merge.Client.FileStorage;

[JsonConverter(typeof(StringEnumSerializer<FilesDownloadRequestMetaListRequestOrderBy>))]
[Serializable]
public readonly record struct FilesDownloadRequestMetaListRequestOrderBy : IStringEnum
{
    public static readonly FilesDownloadRequestMetaListRequestOrderBy CreatedAtDescending = new(
        Values.CreatedAtDescending
    );

    public static readonly FilesDownloadRequestMetaListRequestOrderBy ModifiedAtDescending = new(
        Values.ModifiedAtDescending
    );

    public static readonly FilesDownloadRequestMetaListRequestOrderBy CreatedAtAscending = new(
        Values.CreatedAtAscending
    );

    public static readonly FilesDownloadRequestMetaListRequestOrderBy ModifiedAtAscending = new(
        Values.ModifiedAtAscending
    );

    public FilesDownloadRequestMetaListRequestOrderBy(string value)
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
    public static FilesDownloadRequestMetaListRequestOrderBy FromCustom(string value)
    {
        return new FilesDownloadRequestMetaListRequestOrderBy(value);
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

    public static bool operator ==(
        FilesDownloadRequestMetaListRequestOrderBy value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        FilesDownloadRequestMetaListRequestOrderBy value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(FilesDownloadRequestMetaListRequestOrderBy value) =>
        value.Value;

    public static explicit operator FilesDownloadRequestMetaListRequestOrderBy(string value) =>
        new(value);

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
