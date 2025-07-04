using System.Text.Json.Serialization;
using Merge.Client.Core;

namespace Merge.Client.Accounting;

[JsonConverter(typeof(StringEnumSerializer<AccountStatusEnum>))]
[Serializable]
public readonly record struct AccountStatusEnum : IStringEnum
{
    public static readonly AccountStatusEnum Active = new(Values.Active);

    public static readonly AccountStatusEnum Pending = new(Values.Pending);

    public static readonly AccountStatusEnum Inactive = new(Values.Inactive);

    public AccountStatusEnum(string value)
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
    public static AccountStatusEnum FromCustom(string value)
    {
        return new AccountStatusEnum(value);
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

    public static bool operator ==(AccountStatusEnum value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(AccountStatusEnum value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(AccountStatusEnum value) => value.Value;

    public static explicit operator AccountStatusEnum(string value) => new(value);

    /// <summary>
    /// Constant strings for enum values
    /// </summary>
    [Serializable]
    public static class Values
    {
        public const string Active = "ACTIVE";

        public const string Pending = "PENDING";

        public const string Inactive = "INACTIVE";
    }
}
