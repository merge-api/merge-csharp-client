using System.Text.Json.Serialization;
using Merge.Client.Core;

namespace Merge.Client.Accounting;

[JsonConverter(typeof(StringEnumSerializer<InvoicesListRequestRemoteFields>))]
[Serializable]
public readonly record struct InvoicesListRequestRemoteFields : IStringEnum
{
    public static readonly InvoicesListRequestRemoteFields Type = new(Values.Type);

    public InvoicesListRequestRemoteFields(string value)
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
    public static InvoicesListRequestRemoteFields FromCustom(string value)
    {
        return new InvoicesListRequestRemoteFields(value);
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

    public static bool operator ==(InvoicesListRequestRemoteFields value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(InvoicesListRequestRemoteFields value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(InvoicesListRequestRemoteFields value) => value.Value;

    public static explicit operator InvoicesListRequestRemoteFields(string value) => new(value);

    /// <summary>
    /// Constant strings for enum values
    /// </summary>
    [Serializable]
    public static class Values
    {
        public const string Type = "type";
    }
}
