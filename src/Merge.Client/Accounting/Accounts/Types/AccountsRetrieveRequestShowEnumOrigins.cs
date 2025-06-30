using System.Text.Json.Serialization;
using Merge.Client.Core;

namespace Merge.Client.Accounting;

[JsonConverter(typeof(StringEnumSerializer<AccountsRetrieveRequestShowEnumOrigins>))]
[Serializable]
public readonly record struct AccountsRetrieveRequestShowEnumOrigins : IStringEnum
{
    public static readonly AccountsRetrieveRequestShowEnumOrigins Classification = new(
        Values.Classification
    );

    public static readonly AccountsRetrieveRequestShowEnumOrigins ClassificationStatus = new(
        Values.ClassificationStatus
    );

    public static readonly AccountsRetrieveRequestShowEnumOrigins Status = new(Values.Status);

    public AccountsRetrieveRequestShowEnumOrigins(string value)
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
    public static AccountsRetrieveRequestShowEnumOrigins FromCustom(string value)
    {
        return new AccountsRetrieveRequestShowEnumOrigins(value);
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

    public static bool operator ==(AccountsRetrieveRequestShowEnumOrigins value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(AccountsRetrieveRequestShowEnumOrigins value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(AccountsRetrieveRequestShowEnumOrigins value) =>
        value.Value;

    public static explicit operator AccountsRetrieveRequestShowEnumOrigins(string value) =>
        new(value);

    /// <summary>
    /// Constant strings for enum values
    /// </summary>
    [Serializable]
    public static class Values
    {
        public const string Classification = "classification";

        public const string ClassificationStatus = "classification,status";

        public const string Status = "status";
    }
}
