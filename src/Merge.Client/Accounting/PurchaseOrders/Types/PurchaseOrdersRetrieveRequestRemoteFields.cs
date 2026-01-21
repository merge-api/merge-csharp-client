using System.Text.Json.Serialization;
using Merge.Client.Core;

namespace Merge.Client.Accounting;

[JsonConverter(typeof(StringEnumSerializer<PurchaseOrdersRetrieveRequestRemoteFields>))]
[Serializable]
public readonly record struct PurchaseOrdersRetrieveRequestRemoteFields : IStringEnum
{
    public static readonly PurchaseOrdersRetrieveRequestRemoteFields Status = new(Values.Status);

    public PurchaseOrdersRetrieveRequestRemoteFields(string value)
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
    public static PurchaseOrdersRetrieveRequestRemoteFields FromCustom(string value)
    {
        return new PurchaseOrdersRetrieveRequestRemoteFields(value);
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
        PurchaseOrdersRetrieveRequestRemoteFields value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        PurchaseOrdersRetrieveRequestRemoteFields value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(PurchaseOrdersRetrieveRequestRemoteFields value) =>
        value.Value;

    public static explicit operator PurchaseOrdersRetrieveRequestRemoteFields(string value) =>
        new(value);

    /// <summary>
    /// Constant strings for enum values
    /// </summary>
    [Serializable]
    public static class Values
    {
        public const string Status = "status";
    }
}
