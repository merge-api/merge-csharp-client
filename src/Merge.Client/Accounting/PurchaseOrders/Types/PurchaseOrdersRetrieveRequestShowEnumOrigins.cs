using System.Text.Json.Serialization;
using Merge.Client.Core;

namespace Merge.Client.Accounting;

[JsonConverter(typeof(StringEnumSerializer<PurchaseOrdersRetrieveRequestShowEnumOrigins>))]
[Serializable]
public readonly record struct PurchaseOrdersRetrieveRequestShowEnumOrigins : IStringEnum
{
    public static readonly PurchaseOrdersRetrieveRequestShowEnumOrigins Status = new(Values.Status);

    public PurchaseOrdersRetrieveRequestShowEnumOrigins(string value)
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
    public static PurchaseOrdersRetrieveRequestShowEnumOrigins FromCustom(string value)
    {
        return new PurchaseOrdersRetrieveRequestShowEnumOrigins(value);
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
        PurchaseOrdersRetrieveRequestShowEnumOrigins value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        PurchaseOrdersRetrieveRequestShowEnumOrigins value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(PurchaseOrdersRetrieveRequestShowEnumOrigins value) =>
        value.Value;

    public static explicit operator PurchaseOrdersRetrieveRequestShowEnumOrigins(string value) =>
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
