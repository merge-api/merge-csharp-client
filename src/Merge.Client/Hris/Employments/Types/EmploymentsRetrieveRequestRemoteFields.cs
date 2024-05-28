using System.Runtime.Serialization;

#nullable enable

namespace Merge.Client.Hris;

public enum EmploymentsRetrieveRequestRemoteFields
{
    [EnumMember(Value = "employment_type")]
    EmploymentType,

    [EnumMember(Value = "employment_type,flsa_status")]
    EmploymentTypeFlsaStatus,

    [EnumMember(Value = "employment_type,flsa_status,pay_frequency")]
    EmploymentTypeFlsaStatusPayFrequency,

    [EnumMember(Value = "employment_type,flsa_status,pay_frequency,pay_period")]
    EmploymentTypeFlsaStatusPayFrequencyPayPeriod,

    [EnumMember(Value = "employment_type,flsa_status,pay_period")]
    EmploymentTypeFlsaStatusPayPeriod,

    [EnumMember(Value = "employment_type,pay_frequency")]
    EmploymentTypePayFrequency,

    [EnumMember(Value = "employment_type,pay_frequency,pay_period")]
    EmploymentTypePayFrequencyPayPeriod,

    [EnumMember(Value = "employment_type,pay_period")]
    EmploymentTypePayPeriod,

    [EnumMember(Value = "flsa_status")]
    FlsaStatus,

    [EnumMember(Value = "flsa_status,pay_frequency")]
    FlsaStatusPayFrequency,

    [EnumMember(Value = "flsa_status,pay_frequency,pay_period")]
    FlsaStatusPayFrequencyPayPeriod,

    [EnumMember(Value = "flsa_status,pay_period")]
    FlsaStatusPayPeriod,

    [EnumMember(Value = "pay_frequency")]
    PayFrequency,

    [EnumMember(Value = "pay_frequency,pay_period")]
    PayFrequencyPayPeriod,

    [EnumMember(Value = "pay_period")]
    PayPeriod
}
