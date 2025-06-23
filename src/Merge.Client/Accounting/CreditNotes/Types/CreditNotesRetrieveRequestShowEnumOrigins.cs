using System.Text.Json.Serialization;
using Merge.Client.Core;

namespace Merge.Client.Accounting;

[JsonConverter(typeof(StringEnumSerializer<CreditNotesRetrieveRequestShowEnumOrigins>))]
public readonly record struct CreditNotesRetrieveRequestShowEnumOrigins : IStringEnum
{
    public static readonly CreditNotesRetrieveRequestShowEnumOrigins Status = new(Values.Status);

    public static readonly CreditNotesRetrieveRequestShowEnumOrigins StatusType = new(
        Values.StatusType
    );

    public static readonly CreditNotesRetrieveRequestShowEnumOrigins Type = new(Values.Type);

    public CreditNotesRetrieveRequestShowEnumOrigins(string value)
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
    public static CreditNotesRetrieveRequestShowEnumOrigins FromCustom(string value)
    {
        return new CreditNotesRetrieveRequestShowEnumOrigins(value);
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

    public static bool operator ==(
        CreditNotesRetrieveRequestShowEnumOrigins value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        CreditNotesRetrieveRequestShowEnumOrigins value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(CreditNotesRetrieveRequestShowEnumOrigins value) =>
        value.Value;

    public static explicit operator CreditNotesRetrieveRequestShowEnumOrigins(string value) =>
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
