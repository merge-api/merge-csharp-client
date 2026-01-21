using System.Text.Json.Serialization;
using Merge.Client.Core;

namespace Merge.Client.Accounting;

[JsonConverter(typeof(StringEnumSerializer<AccountsListRequestStatus>))]
[Serializable]
public readonly record struct AccountsListRequestStatus : IStringEnum
{
    public static readonly AccountsListRequestStatus Empty = new(Values.Empty);

    public static readonly AccountsListRequestStatus Active = new(Values.Active);

    public static readonly AccountsListRequestStatus Inactive = new(Values.Inactive);

    public static readonly AccountsListRequestStatus Pending = new(Values.Pending);

    public AccountsListRequestStatus(string value)
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
    public static AccountsListRequestStatus FromCustom(string value)
    {
        return new AccountsListRequestStatus(value);
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

    public static bool operator ==(AccountsListRequestStatus value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(AccountsListRequestStatus value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(AccountsListRequestStatus value) => value.Value;

    public static explicit operator AccountsListRequestStatus(string value) => new(value);

    /// <summary>
    /// Constant strings for enum values
    /// </summary>
    [Serializable]
    public static class Values
    {
        public const string Empty = "";

        public const string Active = "ACTIVE";

        public const string Inactive = "INACTIVE";

        public const string Pending = "PENDING";
    }
}
