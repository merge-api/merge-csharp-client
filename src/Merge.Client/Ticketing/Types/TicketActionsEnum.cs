using System.Text.Json.Serialization;
using Merge.Client.Core;

namespace Merge.Client.Ticketing;

[JsonConverter(typeof(StringEnumSerializer<TicketActionsEnum>))]
public readonly record struct TicketActionsEnum : IStringEnum
{
    public static readonly TicketActionsEnum View = new(Values.View);

    public static readonly TicketActionsEnum Create = new(Values.Create);

    public static readonly TicketActionsEnum Edit = new(Values.Edit);

    public static readonly TicketActionsEnum Delete = new(Values.Delete);

    public static readonly TicketActionsEnum Close = new(Values.Close);

    public static readonly TicketActionsEnum Assign = new(Values.Assign);

    public TicketActionsEnum(string value)
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
    public static TicketActionsEnum FromCustom(string value)
    {
        return new TicketActionsEnum(value);
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

    public static bool operator ==(TicketActionsEnum value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(TicketActionsEnum value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(TicketActionsEnum value) => value.Value;

    public static explicit operator TicketActionsEnum(string value) => new(value);

    /// <summary>
    /// Constant strings for enum values
    /// </summary>
    public static class Values
    {
        public const string View = "VIEW";

        public const string Create = "CREATE";

        public const string Edit = "EDIT";

        public const string Delete = "DELETE";

        public const string Close = "CLOSE";

        public const string Assign = "ASSIGN";
    }
}
