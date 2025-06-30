using System.Text.Json.Serialization;
using Merge.Client.Core;

namespace Merge.Client.Hris;

[JsonConverter(typeof(StringEnumSerializer<EmploymentsListRequestRemoteFields>))]
[Serializable]
public readonly record struct EmploymentsListRequestRemoteFields : IStringEnum
{
    public static readonly EmploymentsListRequestRemoteFields EmploymentType = new(
        Values.EmploymentType
    );

    public static readonly EmploymentsListRequestRemoteFields EmploymentTypeFlsaStatus = new(
        Values.EmploymentTypeFlsaStatus
    );

    public static readonly EmploymentsListRequestRemoteFields EmploymentTypeFlsaStatusPayFrequency =
        new(Values.EmploymentTypeFlsaStatusPayFrequency);

    public static readonly EmploymentsListRequestRemoteFields EmploymentTypeFlsaStatusPayFrequencyPayPeriod =
        new(Values.EmploymentTypeFlsaStatusPayFrequencyPayPeriod);

    public static readonly EmploymentsListRequestRemoteFields EmploymentTypeFlsaStatusPayPeriod =
        new(Values.EmploymentTypeFlsaStatusPayPeriod);

    public static readonly EmploymentsListRequestRemoteFields EmploymentTypePayFrequency = new(
        Values.EmploymentTypePayFrequency
    );

    public static readonly EmploymentsListRequestRemoteFields EmploymentTypePayFrequencyPayPeriod =
        new(Values.EmploymentTypePayFrequencyPayPeriod);

    public static readonly EmploymentsListRequestRemoteFields EmploymentTypePayPeriod = new(
        Values.EmploymentTypePayPeriod
    );

    public static readonly EmploymentsListRequestRemoteFields FlsaStatus = new(Values.FlsaStatus);

    public static readonly EmploymentsListRequestRemoteFields FlsaStatusPayFrequency = new(
        Values.FlsaStatusPayFrequency
    );

    public static readonly EmploymentsListRequestRemoteFields FlsaStatusPayFrequencyPayPeriod = new(
        Values.FlsaStatusPayFrequencyPayPeriod
    );

    public static readonly EmploymentsListRequestRemoteFields FlsaStatusPayPeriod = new(
        Values.FlsaStatusPayPeriod
    );

    public static readonly EmploymentsListRequestRemoteFields PayFrequency = new(
        Values.PayFrequency
    );

    public static readonly EmploymentsListRequestRemoteFields PayFrequencyPayPeriod = new(
        Values.PayFrequencyPayPeriod
    );

    public static readonly EmploymentsListRequestRemoteFields PayPeriod = new(Values.PayPeriod);

    public EmploymentsListRequestRemoteFields(string value)
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
    public static EmploymentsListRequestRemoteFields FromCustom(string value)
    {
        return new EmploymentsListRequestRemoteFields(value);
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

    public static bool operator ==(EmploymentsListRequestRemoteFields value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(EmploymentsListRequestRemoteFields value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(EmploymentsListRequestRemoteFields value) => value.Value;

    public static explicit operator EmploymentsListRequestRemoteFields(string value) => new(value);

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
