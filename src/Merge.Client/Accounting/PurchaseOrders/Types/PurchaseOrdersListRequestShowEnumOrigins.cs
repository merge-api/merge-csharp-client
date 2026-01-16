using System.Text.Json.Serialization;
using Merge.Client.Core;

namespace Merge.Client.Accounting;

[JsonConverter(typeof(StringEnumSerializer<PurchaseOrdersListRequestShowEnumOrigins>))]
[Serializable]
public readonly record struct PurchaseOrdersListRequestShowEnumOrigins : IStringEnum
{
    public static readonly PurchaseOrdersListRequestShowEnumOrigins Status = new(Values.Status);

    public PurchaseOrdersListRequestShowEnumOrigins(string value)
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
    public static PurchaseOrdersListRequestShowEnumOrigins FromCustom(string value)
    {
        return new PurchaseOrdersListRequestShowEnumOrigins(value);
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
        PurchaseOrdersListRequestShowEnumOrigins value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        PurchaseOrdersListRequestShowEnumOrigins value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(PurchaseOrdersListRequestShowEnumOrigins value) =>
        value.Value;

    public static explicit operator PurchaseOrdersListRequestShowEnumOrigins(string value) =>
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
