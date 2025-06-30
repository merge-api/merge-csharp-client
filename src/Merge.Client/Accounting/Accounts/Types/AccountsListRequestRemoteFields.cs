using System.Text.Json.Serialization;
using Merge.Client.Core;

namespace Merge.Client.Accounting;

[JsonConverter(typeof(StringEnumSerializer<AccountsListRequestRemoteFields>))]
[Serializable]
public readonly record struct AccountsListRequestRemoteFields : IStringEnum
{
    public static readonly AccountsListRequestRemoteFields Classification = new(
        Values.Classification
    );

    public static readonly AccountsListRequestRemoteFields ClassificationStatus = new(
        Values.ClassificationStatus
    );

    public static readonly AccountsListRequestRemoteFields Status = new(Values.Status);

    public AccountsListRequestRemoteFields(string value)
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
    public static AccountsListRequestRemoteFields FromCustom(string value)
    {
        return new AccountsListRequestRemoteFields(value);
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

    public static bool operator ==(AccountsListRequestRemoteFields value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(AccountsListRequestRemoteFields value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(AccountsListRequestRemoteFields value) => value.Value;

    public static explicit operator AccountsListRequestRemoteFields(string value) => new(value);

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
