using System.Text.Json.Serialization;
using Merge.Client.Core;

namespace Merge.Client.Accounting;

[JsonConverter(typeof(StringEnumSerializer<CreditNotesRetrieveRequestRemoteFields>))]
public readonly record struct CreditNotesRetrieveRequestRemoteFields : IStringEnum
{
    public static readonly CreditNotesRetrieveRequestRemoteFields Status = new(Values.Status);

    public static readonly CreditNotesRetrieveRequestRemoteFields StatusType = new(
        Values.StatusType
    );

    public static readonly CreditNotesRetrieveRequestRemoteFields Type = new(Values.Type);

    public CreditNotesRetrieveRequestRemoteFields(string value)
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
    public static CreditNotesRetrieveRequestRemoteFields FromCustom(string value)
    {
        return new CreditNotesRetrieveRequestRemoteFields(value);
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

    public static bool operator ==(CreditNotesRetrieveRequestRemoteFields value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(CreditNotesRetrieveRequestRemoteFields value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(CreditNotesRetrieveRequestRemoteFields value) =>
        value.Value;

    public static explicit operator CreditNotesRetrieveRequestRemoteFields(string value) =>
        new(value);

    /// <summary>
    /// Constant strings for enum values
    /// </summary>
    public static class Values
    {
        public const string Status = "status";

        public const string StatusType = "status,type";

        public const string Type = "type";
    }
}
