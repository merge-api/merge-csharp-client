using System.Text.Json.Serialization;
using Merge.Client.Core;

namespace Merge.Client.Accounting;

[JsonConverter(typeof(StringEnumSerializer<InvoicesRetrieveRequestRemoteFields>))]
[Serializable]
public readonly record struct InvoicesRetrieveRequestRemoteFields : IStringEnum
{
    public static readonly InvoicesRetrieveRequestRemoteFields Type = new(Values.Type);

    public InvoicesRetrieveRequestRemoteFields(string value)
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
    public static InvoicesRetrieveRequestRemoteFields FromCustom(string value)
    {
        return new InvoicesRetrieveRequestRemoteFields(value);
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

    public static bool operator ==(InvoicesRetrieveRequestRemoteFields value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(InvoicesRetrieveRequestRemoteFields value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(InvoicesRetrieveRequestRemoteFields value) =>
        value.Value;

    public static explicit operator InvoicesRetrieveRequestRemoteFields(string value) => new(value);

    /// <summary>
    /// Constant strings for enum values
    /// </summary>
    [Serializable]
    public static class Values
    {
        public const string Type = "type";
    }
}
