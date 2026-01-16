using System.Text.Json.Serialization;
using Merge.Client.Core;

namespace Merge.Client.Ticketing;

[JsonConverter(typeof(StringEnumSerializer<TicketsListRequestStatus>))]
[Serializable]
public readonly record struct TicketsListRequestStatus : IStringEnum
{
    public static readonly TicketsListRequestStatus Empty = new(Values.Empty);

    public static readonly TicketsListRequestStatus Closed = new(Values.Closed);

    public static readonly TicketsListRequestStatus InProgress = new(Values.InProgress);

    public static readonly TicketsListRequestStatus OnHold = new(Values.OnHold);

    public static readonly TicketsListRequestStatus Open = new(Values.Open);

    public TicketsListRequestStatus(string value)
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
    public static TicketsListRequestStatus FromCustom(string value)
    {
        return new TicketsListRequestStatus(value);
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

    public static bool operator ==(TicketsListRequestStatus value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(TicketsListRequestStatus value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(TicketsListRequestStatus value) => value.Value;

    public static explicit operator TicketsListRequestStatus(string value) => new(value);

    /// <summary>
    /// Constant strings for enum values
    /// </summary>
    [Serializable]
    public static class Values
    {
        public const string Empty = "";

        public const string Closed = "CLOSED";

        public const string InProgress = "IN_PROGRESS";

        public const string OnHold = "ON_HOLD";

        public const string Open = "OPEN";
    }
}
