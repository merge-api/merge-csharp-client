using System.Text.Json.Serialization;
using Merge.Client.Core;

namespace Merge.Client.Accounting;

[JsonConverter(typeof(StringEnumSerializer<LastSyncResultEnum>))]
public readonly record struct LastSyncResultEnum : IStringEnum
{
    public static readonly LastSyncResultEnum Syncing = new(Values.Syncing);

    public static readonly LastSyncResultEnum Done = new(Values.Done);

    public static readonly LastSyncResultEnum Failed = new(Values.Failed);

    public static readonly LastSyncResultEnum Disabled = new(Values.Disabled);

    public static readonly LastSyncResultEnum Paused = new(Values.Paused);

    public static readonly LastSyncResultEnum PartiallySynced = new(Values.PartiallySynced);

    public LastSyncResultEnum(string value)
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
    public static LastSyncResultEnum FromCustom(string value)
    {
        return new LastSyncResultEnum(value);
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

    public static bool operator ==(LastSyncResultEnum value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(LastSyncResultEnum value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(LastSyncResultEnum value) => value.Value;

    public static explicit operator LastSyncResultEnum(string value) => new(value);

    /// <summary>
    /// Constant strings for enum values
    /// </summary>
    public static class Values
    {
        public const string Syncing = "SYNCING";

        public const string Done = "DONE";

        public const string Failed = "FAILED";

        public const string Disabled = "DISABLED";

        public const string Paused = "PAUSED";

        public const string PartiallySynced = "PARTIALLY_SYNCED";
    }
}
