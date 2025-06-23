using System.Text.Json.Serialization;
using Merge.Client.Core;

namespace Merge.Client.Accounting;

[JsonConverter(typeof(StringEnumSerializer<CreditNotesListRequestShowEnumOrigins>))]
public readonly record struct CreditNotesListRequestShowEnumOrigins : IStringEnum
{
    public static readonly CreditNotesListRequestShowEnumOrigins Status = new(Values.Status);

    public static readonly CreditNotesListRequestShowEnumOrigins StatusType = new(
        Values.StatusType
    );

    public static readonly CreditNotesListRequestShowEnumOrigins Type = new(Values.Type);

    public CreditNotesListRequestShowEnumOrigins(string value)
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
    public static CreditNotesListRequestShowEnumOrigins FromCustom(string value)
    {
        return new CreditNotesListRequestShowEnumOrigins(value);
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

    public static bool operator ==(CreditNotesListRequestShowEnumOrigins value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(CreditNotesListRequestShowEnumOrigins value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(CreditNotesListRequestShowEnumOrigins value) =>
        value.Value;

    public static explicit operator CreditNotesListRequestShowEnumOrigins(string value) =>
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
