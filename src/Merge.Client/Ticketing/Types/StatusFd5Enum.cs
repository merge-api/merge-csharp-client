using System.Text.Json.Serialization;
using Merge.Client.Core;

namespace Merge.Client.Ticketing;

[JsonConverter(typeof(StringEnumSerializer<StatusFd5Enum>))]
public readonly record struct StatusFd5Enum : IStringEnum
{
    public static readonly StatusFd5Enum Syncing = new(Values.Syncing);

    public static readonly StatusFd5Enum Done = new(Values.Done);

    public static readonly StatusFd5Enum Failed = new(Values.Failed);

    public static readonly StatusFd5Enum Disabled = new(Values.Disabled);

    public static readonly StatusFd5Enum Paused = new(Values.Paused);

    public static readonly StatusFd5Enum PartiallySynced = new(Values.PartiallySynced);

    public StatusFd5Enum(string value)
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
    public static StatusFd5Enum FromCustom(string value)
    {
        return new StatusFd5Enum(value);
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

    public static bool operator ==(StatusFd5Enum value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(StatusFd5Enum value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(StatusFd5Enum value) => value.Value;

    public static explicit operator StatusFd5Enum(string value) => new(value);

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
