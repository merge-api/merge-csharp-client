using System.Text.Json.Serialization;
using Merge.Client.Core;

namespace Merge.Client.Crm;

[JsonConverter(typeof(StringEnumSerializer<AccountDetailsAndActionsStatusEnum>))]
[Serializable]
public readonly record struct AccountDetailsAndActionsStatusEnum : IStringEnum
{
    public static readonly AccountDetailsAndActionsStatusEnum Complete = new(Values.Complete);

    public static readonly AccountDetailsAndActionsStatusEnum Incomplete = new(Values.Incomplete);

    public static readonly AccountDetailsAndActionsStatusEnum RelinkNeeded = new(
        Values.RelinkNeeded
    );

    public static readonly AccountDetailsAndActionsStatusEnum Idle = new(Values.Idle);

    public AccountDetailsAndActionsStatusEnum(string value)
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
    public static AccountDetailsAndActionsStatusEnum FromCustom(string value)
    {
        return new AccountDetailsAndActionsStatusEnum(value);
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

    public static bool operator ==(AccountDetailsAndActionsStatusEnum value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(AccountDetailsAndActionsStatusEnum value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(AccountDetailsAndActionsStatusEnum value) => value.Value;

    public static explicit operator AccountDetailsAndActionsStatusEnum(string value) => new(value);

    /// <summary>
    /// Constant strings for enum values
    /// </summary>
    [Serializable]
    public static class Values
    {
        public const string Complete = "COMPLETE";

        public const string Incomplete = "INCOMPLETE";

        public const string RelinkNeeded = "RELINK_NEEDED";

        public const string Idle = "IDLE";
    }
}
