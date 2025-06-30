using System.Text.Json.Serialization;
using Merge.Client.Core;

namespace Merge.Client.Hris;

[JsonConverter(typeof(StringEnumSerializer<EmploymentsListRequestShowEnumOrigins>))]
[Serializable]
public readonly record struct EmploymentsListRequestShowEnumOrigins : IStringEnum
{
    public static readonly EmploymentsListRequestShowEnumOrigins EmploymentType = new(
        Values.EmploymentType
    );

    public static readonly EmploymentsListRequestShowEnumOrigins EmploymentTypeFlsaStatus = new(
        Values.EmploymentTypeFlsaStatus
    );

    public static readonly EmploymentsListRequestShowEnumOrigins EmploymentTypeFlsaStatusPayFrequency =
        new(Values.EmploymentTypeFlsaStatusPayFrequency);

    public static readonly EmploymentsListRequestShowEnumOrigins EmploymentTypeFlsaStatusPayFrequencyPayPeriod =
        new(Values.EmploymentTypeFlsaStatusPayFrequencyPayPeriod);

    public static readonly EmploymentsListRequestShowEnumOrigins EmploymentTypeFlsaStatusPayPeriod =
        new(Values.EmploymentTypeFlsaStatusPayPeriod);

    public static readonly EmploymentsListRequestShowEnumOrigins EmploymentTypePayFrequency = new(
        Values.EmploymentTypePayFrequency
    );

    public static readonly EmploymentsListRequestShowEnumOrigins EmploymentTypePayFrequencyPayPeriod =
        new(Values.EmploymentTypePayFrequencyPayPeriod);

    public static readonly EmploymentsListRequestShowEnumOrigins EmploymentTypePayPeriod = new(
        Values.EmploymentTypePayPeriod
    );

    public static readonly EmploymentsListRequestShowEnumOrigins FlsaStatus = new(
        Values.FlsaStatus
    );

    public static readonly EmploymentsListRequestShowEnumOrigins FlsaStatusPayFrequency = new(
        Values.FlsaStatusPayFrequency
    );

    public static readonly EmploymentsListRequestShowEnumOrigins FlsaStatusPayFrequencyPayPeriod =
        new(Values.FlsaStatusPayFrequencyPayPeriod);

    public static readonly EmploymentsListRequestShowEnumOrigins FlsaStatusPayPeriod = new(
        Values.FlsaStatusPayPeriod
    );

    public static readonly EmploymentsListRequestShowEnumOrigins PayFrequency = new(
        Values.PayFrequency
    );

    public static readonly EmploymentsListRequestShowEnumOrigins PayFrequencyPayPeriod = new(
        Values.PayFrequencyPayPeriod
    );

    public static readonly EmploymentsListRequestShowEnumOrigins PayPeriod = new(Values.PayPeriod);

    public EmploymentsListRequestShowEnumOrigins(string value)
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
    public static EmploymentsListRequestShowEnumOrigins FromCustom(string value)
    {
        return new EmploymentsListRequestShowEnumOrigins(value);
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

    public static bool operator ==(EmploymentsListRequestShowEnumOrigins value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(EmploymentsListRequestShowEnumOrigins value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(EmploymentsListRequestShowEnumOrigins value) =>
        value.Value;

    public static explicit operator EmploymentsListRequestShowEnumOrigins(string value) =>
        new(value);

    /// <summary>
    /// Constant strings for enum values
    /// </summary>
    [Serializable]
    public static class Values
    {
        public const string EmploymentType = "employment_type";

        public const string EmploymentTypeFlsaStatus = "employment_type,flsa_status";

        public const string EmploymentTypeFlsaStatusPayFrequency =
            "employment_type,flsa_status,pay_frequency";

        public const string EmploymentTypeFlsaStatusPayFrequencyPayPeriod =
            "employment_type,flsa_status,pay_frequency,pay_period";

        public const string EmploymentTypeFlsaStatusPayPeriod =
            "employment_type,flsa_status,pay_period";

        public const string EmploymentTypePayFrequency = "employment_type,pay_frequency";

        public const string EmploymentTypePayFrequencyPayPeriod =
            "employment_type,pay_frequency,pay_period";

        public const string EmploymentTypePayPeriod = "employment_type,pay_period";

        public const string FlsaStatus = "flsa_status";

        public const string FlsaStatusPayFrequency = "flsa_status,pay_frequency";

        public const string FlsaStatusPayFrequencyPayPeriod =
            "flsa_status,pay_frequency,pay_period";

        public const string FlsaStatusPayPeriod = "flsa_status,pay_period";

        public const string PayFrequency = "pay_frequency";

        public const string PayFrequencyPayPeriod = "pay_frequency,pay_period";

        public const string PayPeriod = "pay_period";
    }
}
