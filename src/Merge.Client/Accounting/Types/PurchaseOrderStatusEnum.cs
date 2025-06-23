using System.Text.Json.Serialization;
using Merge.Client.Core;

namespace Merge.Client.Accounting;

[JsonConverter(typeof(StringEnumSerializer<PurchaseOrderStatusEnum>))]
public readonly record struct PurchaseOrderStatusEnum : IStringEnum
{
    public static readonly PurchaseOrderStatusEnum Draft = new(Values.Draft);

    public static readonly PurchaseOrderStatusEnum Submitted = new(Values.Submitted);

    public static readonly PurchaseOrderStatusEnum Authorized = new(Values.Authorized);

    public static readonly PurchaseOrderStatusEnum Billed = new(Values.Billed);

    public static readonly PurchaseOrderStatusEnum Deleted = new(Values.Deleted);

    public PurchaseOrderStatusEnum(string value)
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
    public static PurchaseOrderStatusEnum FromCustom(string value)
    {
        return new PurchaseOrderStatusEnum(value);
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

    public static bool operator ==(PurchaseOrderStatusEnum value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(PurchaseOrderStatusEnum value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(PurchaseOrderStatusEnum value) => value.Value;

    public static explicit operator PurchaseOrderStatusEnum(string value) => new(value);

    /// <summary>
    /// Constant strings for enum values
    /// </summary>
    public static class Values
    {
        public const string Draft = "DRAFT";

        public const string Submitted = "SUBMITTED";

        public const string Authorized = "AUTHORIZED";

        public const string Billed = "BILLED";

        public const string Deleted = "DELETED";
    }
}
