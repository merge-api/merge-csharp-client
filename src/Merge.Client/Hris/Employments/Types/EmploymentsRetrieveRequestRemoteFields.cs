using System.Text.Json.Serialization;
using Merge.Client.Core;

namespace Merge.Client.Hris;

[JsonConverter(typeof(StringEnumSerializer<EmploymentsRetrieveRequestRemoteFields>))]
public readonly record struct EmploymentsRetrieveRequestRemoteFields : IStringEnum
{
    public static readonly EmploymentsRetrieveRequestRemoteFields EmploymentType = new(
        Values.EmploymentType
    );

    public static readonly EmploymentsRetrieveRequestRemoteFields EmploymentTypeFlsaStatus = new(
        Values.EmploymentTypeFlsaStatus
    );

    public static readonly EmploymentsRetrieveRequestRemoteFields EmploymentTypeFlsaStatusPayFrequency =
        new(Values.EmploymentTypeFlsaStatusPayFrequency);

    public static readonly EmploymentsRetrieveRequestRemoteFields EmploymentTypeFlsaStatusPayFrequencyPayPeriod =
        new(Values.EmploymentTypeFlsaStatusPayFrequencyPayPeriod);

    public static readonly EmploymentsRetrieveRequestRemoteFields EmploymentTypeFlsaStatusPayPeriod =
        new(Values.EmploymentTypeFlsaStatusPayPeriod);

    public static readonly EmploymentsRetrieveRequestRemoteFields EmploymentTypePayFrequency = new(
        Values.EmploymentTypePayFrequency
    );

    public static readonly EmploymentsRetrieveRequestRemoteFields EmploymentTypePayFrequencyPayPeriod =
        new(Values.EmploymentTypePayFrequencyPayPeriod);

    public static readonly EmploymentsRetrieveRequestRemoteFields EmploymentTypePayPeriod = new(
        Values.EmploymentTypePayPeriod
    );

    public static readonly EmploymentsRetrieveRequestRemoteFields FlsaStatus = new(
        Values.FlsaStatus
    );

    public static readonly EmploymentsRetrieveRequestRemoteFields FlsaStatusPayFrequency = new(
        Values.FlsaStatusPayFrequency
    );

    public static readonly EmploymentsRetrieveRequestRemoteFields FlsaStatusPayFrequencyPayPeriod =
        new(Values.FlsaStatusPayFrequencyPayPeriod);

    public static readonly EmploymentsRetrieveRequestRemoteFields FlsaStatusPayPeriod = new(
        Values.FlsaStatusPayPeriod
    );

    public static readonly EmploymentsRetrieveRequestRemoteFields PayFrequency = new(
        Values.PayFrequency
    );

    public static readonly EmploymentsRetrieveRequestRemoteFields PayFrequencyPayPeriod = new(
        Values.PayFrequencyPayPeriod
    );

    public static readonly EmploymentsRetrieveRequestRemoteFields PayPeriod = new(Values.PayPeriod);

    public EmploymentsRetrieveRequestRemoteFields(string value)
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
    public static EmploymentsRetrieveRequestRemoteFields FromCustom(string value)
    {
        return new EmploymentsRetrieveRequestRemoteFields(value);
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

    public static bool operator ==(EmploymentsRetrieveRequestRemoteFields value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(EmploymentsRetrieveRequestRemoteFields value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(EmploymentsRetrieveRequestRemoteFields value) =>
        value.Value;

    public static explicit operator EmploymentsRetrieveRequestRemoteFields(string value) =>
        new(value);

    /// <summary>
    /// Constant strings for enum values
    /// </summary>
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
