using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Merge.Client.Core;

namespace Merge.Client.Hris;

[JsonConverter(typeof(EnumSerializer<EmployeesListRequestRemoteFields>))]
public enum EmployeesListRequestRemoteFields
{
    [EnumMember(Value = "employment_status")]
    EmploymentStatus,

    [EnumMember(Value = "employment_status,ethnicity")]
    EmploymentStatusEthnicity,

    [EnumMember(Value = "employment_status,ethnicity,gender")]
    EmploymentStatusEthnicityGender,

    [EnumMember(Value = "employment_status,ethnicity,gender,marital_status")]
    EmploymentStatusEthnicityGenderMaritalStatus,

    [EnumMember(Value = "employment_status,ethnicity,marital_status")]
    EmploymentStatusEthnicityMaritalStatus,

    [EnumMember(Value = "employment_status,gender")]
    EmploymentStatusGender,

    [EnumMember(Value = "employment_status,gender,marital_status")]
    EmploymentStatusGenderMaritalStatus,

    [EnumMember(Value = "employment_status,marital_status")]
    EmploymentStatusMaritalStatus,

    [EnumMember(Value = "ethnicity")]
    Ethnicity,

    [EnumMember(Value = "ethnicity,gender")]
    EthnicityGender,

    [EnumMember(Value = "ethnicity,gender,marital_status")]
    EthnicityGenderMaritalStatus,

    [EnumMember(Value = "ethnicity,marital_status")]
    EthnicityMaritalStatus,

    [EnumMember(Value = "gender")]
    Gender,

    [EnumMember(Value = "gender,marital_status")]
    GenderMaritalStatus,

    [EnumMember(Value = "marital_status")]
    MaritalStatus,
}
