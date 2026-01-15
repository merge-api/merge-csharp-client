using System.Text.Json.Serialization;
using Merge.Client.Core;

namespace Merge.Client.Accounting;

[JsonConverter(typeof(StringEnumSerializer<InvoicesListRequestShowEnumOrigins>))]
[Serializable]
public readonly record struct InvoicesListRequestShowEnumOrigins : IStringEnum
{
    public static readonly InvoicesListRequestShowEnumOrigins Type = new(Values.Type);

    public InvoicesListRequestShowEnumOrigins(string value)
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
    public static InvoicesListRequestShowEnumOrigins FromCustom(string value)
    {
        return new InvoicesListRequestShowEnumOrigins(value);
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

    public static bool operator ==(InvoicesListRequestShowEnumOrigins value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(InvoicesListRequestShowEnumOrigins value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(InvoicesListRequestShowEnumOrigins value) => value.Value;

    public static explicit operator InvoicesListRequestShowEnumOrigins(string value) => new(value);

    /// <summary>
    /// Constant strings for enum values
    /// </summary>
    [Serializable]
    public static class Values
    {
        public const string Type = "type";
    }
}
