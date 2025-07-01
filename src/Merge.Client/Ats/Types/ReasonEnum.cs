using System.Text.Json.Serialization;
using Merge.Client.Core;

namespace Merge.Client.Ats;

[JsonConverter(typeof(StringEnumSerializer<ReasonEnum>))]
[Serializable]
public readonly record struct ReasonEnum : IStringEnum
{
    public static readonly ReasonEnum GeneralCustomerRequest = new(Values.GeneralCustomerRequest);

    public static readonly ReasonEnum Gdpr = new(Values.Gdpr);

    public static readonly ReasonEnum Other = new(Values.Other);

    public ReasonEnum(string value)
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
    public static ReasonEnum FromCustom(string value)
    {
        return new ReasonEnum(value);
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

    public static bool operator ==(ReasonEnum value1, string value2) => value1.Value.Equals(value2);

    public static bool operator !=(ReasonEnum value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(ReasonEnum value) => value.Value;

    public static explicit operator ReasonEnum(string value) => new(value);

    /// <summary>
    /// Constant strings for enum values
    /// </summary>
    [Serializable]
    public static class Values
    {
        public const string GeneralCustomerRequest = "GENERAL_CUSTOMER_REQUEST";

        public const string Gdpr = "GDPR";

        public const string Other = "OTHER";
    }
}
