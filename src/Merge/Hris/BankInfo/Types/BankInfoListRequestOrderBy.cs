using System.Text.Json.Serialization;
using Merge.Core;

namespace Merge.Hris.BankInfo;

[JsonConverter(typeof(StringEnumSerializer<BankInfoListRequestOrderBy>))]
public readonly record struct BankInfoListRequestOrderBy : IStringEnum
{
    public static readonly BankInfoListRequestOrderBy RemoteCreatedAtDescending = new(
        Values.RemoteCreatedAtDescending
    );

    public static readonly BankInfoListRequestOrderBy RemoteCreatedAtAscending = new(
        Values.RemoteCreatedAtAscending
    );

    public BankInfoListRequestOrderBy(string value)
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
    public static BankInfoListRequestOrderBy FromCustom(string value)
    {
        return new BankInfoListRequestOrderBy(value);
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

    public static bool operator ==(BankInfoListRequestOrderBy value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(BankInfoListRequestOrderBy value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(BankInfoListRequestOrderBy value) => value.Value;

    public static explicit operator BankInfoListRequestOrderBy(string value) => new(value);

    /// <summary>
    /// Constant strings for enum values
    /// </summary>
    public static class Values
    {
        public const string RemoteCreatedAtDescending = "-remote_created_at";

        public const string RemoteCreatedAtAscending = "remote_created_at";
    }
}
