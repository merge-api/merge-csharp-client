using System.Text.Json.Serialization;
using Merge.Client.Core;

namespace Merge.Client.Accounting;

[JsonConverter(typeof(StringEnumSerializer<AccountsListRequestShowEnumOrigins>))]
public readonly record struct AccountsListRequestShowEnumOrigins : IStringEnum
{
    public static readonly AccountsListRequestShowEnumOrigins Classification = new(
        Values.Classification
    );

    public static readonly AccountsListRequestShowEnumOrigins ClassificationStatus = new(
        Values.ClassificationStatus
    );

    public static readonly AccountsListRequestShowEnumOrigins Status = new(Values.Status);

    public AccountsListRequestShowEnumOrigins(string value)
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
    public static AccountsListRequestShowEnumOrigins FromCustom(string value)
    {
        return new AccountsListRequestShowEnumOrigins(value);
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

    public static bool operator ==(AccountsListRequestShowEnumOrigins value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(AccountsListRequestShowEnumOrigins value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(AccountsListRequestShowEnumOrigins value) => value.Value;

    public static explicit operator AccountsListRequestShowEnumOrigins(string value) => new(value);

    /// <summary>
    /// Constant strings for enum values
    /// </summary>
    public static class Values
    {
        public const string Classification = "classification";

        public const string ClassificationStatus = "classification,status";

        public const string Status = "status";
    }
}
