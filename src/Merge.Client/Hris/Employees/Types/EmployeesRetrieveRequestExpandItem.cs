using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Merge.Client.Core;

namespace Merge.Client.Hris;

[JsonConverter(typeof(EnumSerializer<EmployeesRetrieveRequestExpandItem>))]
public enum EmployeesRetrieveRequestExpandItem
{
    [EnumMember(Value = "company")]
    Company,

    [EnumMember(Value = "employments")]
    Employments,

    [EnumMember(Value = "groups")]
    Groups,

    [EnumMember(Value = "home_location")]
    HomeLocation,

    [EnumMember(Value = "manager")]
    Manager,

    [EnumMember(Value = "pay_group")]
    PayGroup,

    [EnumMember(Value = "team")]
    Team,

    [EnumMember(Value = "work_location")]
    WorkLocation,
}
