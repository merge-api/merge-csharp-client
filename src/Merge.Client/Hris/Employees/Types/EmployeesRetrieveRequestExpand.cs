using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Merge.Client.Core;
using Merge.Client.Hris;

#nullable enable

namespace Merge.Client.Hris;

[JsonConverter(typeof(StringEnumSerializer<EmployeesRetrieveRequestExpand>))]
public enum EmployeesRetrieveRequestExpand
{
    [EnumMember(Value = "company")]
    Company,

    [EnumMember(Value = "company,pay_group")]
    CompanyPayGroup,

    [EnumMember(Value = "employments")]
    Employments,

    [EnumMember(Value = "employments,company")]
    EmploymentsCompany,

    [EnumMember(Value = "employments,company,pay_group")]
    EmploymentsCompanyPayGroup,

    [EnumMember(Value = "employments,groups")]
    EmploymentsGroups,

    [EnumMember(Value = "employments,groups,company")]
    EmploymentsGroupsCompany,

    [EnumMember(Value = "employments,groups,company,pay_group")]
    EmploymentsGroupsCompanyPayGroup,

    [EnumMember(Value = "employments,groups,home_location")]
    EmploymentsGroupsHomeLocation,

    [EnumMember(Value = "employments,groups,home_location,company")]
    EmploymentsGroupsHomeLocationCompany,

    [EnumMember(Value = "employments,groups,home_location,company,pay_group")]
    EmploymentsGroupsHomeLocationCompanyPayGroup,

    [EnumMember(Value = "employments,groups,home_location,manager")]
    EmploymentsGroupsHomeLocationManager,

    [EnumMember(Value = "employments,groups,home_location,manager,company")]
    EmploymentsGroupsHomeLocationManagerCompany,

    [EnumMember(Value = "employments,groups,home_location,manager,company,pay_group")]
    EmploymentsGroupsHomeLocationManagerCompanyPayGroup,

    [EnumMember(Value = "employments,groups,home_location,manager,pay_group")]
    EmploymentsGroupsHomeLocationManagerPayGroup,

    [EnumMember(Value = "employments,groups,home_location,manager,team")]
    EmploymentsGroupsHomeLocationManagerTeam,

    [EnumMember(Value = "employments,groups,home_location,manager,team,company")]
    EmploymentsGroupsHomeLocationManagerTeamCompany,

    [EnumMember(Value = "employments,groups,home_location,manager,team,company,pay_group")]
    EmploymentsGroupsHomeLocationManagerTeamCompanyPayGroup,

    [EnumMember(Value = "employments,groups,home_location,manager,team,pay_group")]
    EmploymentsGroupsHomeLocationManagerTeamPayGroup,

    [EnumMember(Value = "employments,groups,home_location,pay_group")]
    EmploymentsGroupsHomeLocationPayGroup,

    [EnumMember(Value = "employments,groups,home_location,team")]
    EmploymentsGroupsHomeLocationTeam,

    [EnumMember(Value = "employments,groups,home_location,team,company")]
    EmploymentsGroupsHomeLocationTeamCompany,

    [EnumMember(Value = "employments,groups,home_location,team,company,pay_group")]
    EmploymentsGroupsHomeLocationTeamCompanyPayGroup,

    [EnumMember(Value = "employments,groups,home_location,team,pay_group")]
    EmploymentsGroupsHomeLocationTeamPayGroup,

    [EnumMember(Value = "employments,groups,home_location,work_location")]
    EmploymentsGroupsHomeLocationWorkLocation,

    [EnumMember(Value = "employments,groups,home_location,work_location,company")]
    EmploymentsGroupsHomeLocationWorkLocationCompany,

    [EnumMember(Value = "employments,groups,home_location,work_location,company,pay_group")]
    EmploymentsGroupsHomeLocationWorkLocationCompanyPayGroup,

    [EnumMember(Value = "employments,groups,home_location,work_location,manager")]
    EmploymentsGroupsHomeLocationWorkLocationManager,

    [EnumMember(Value = "employments,groups,home_location,work_location,manager,company")]
    EmploymentsGroupsHomeLocationWorkLocationManagerCompany,

    [EnumMember(Value = "employments,groups,home_location,work_location,manager,company,pay_group")]
    EmploymentsGroupsHomeLocationWorkLocationManagerCompanyPayGroup,

    [EnumMember(Value = "employments,groups,home_location,work_location,manager,pay_group")]
    EmploymentsGroupsHomeLocationWorkLocationManagerPayGroup,

    [EnumMember(Value = "employments,groups,home_location,work_location,manager,team")]
    EmploymentsGroupsHomeLocationWorkLocationManagerTeam,

    [EnumMember(Value = "employments,groups,home_location,work_location,manager,team,company")]
    EmploymentsGroupsHomeLocationWorkLocationManagerTeamCompany,

    [EnumMember(
        Value = "employments,groups,home_location,work_location,manager,team,company,pay_group"
    )]
    EmploymentsGroupsHomeLocationWorkLocationManagerTeamCompanyPayGroup,

    [EnumMember(Value = "employments,groups,home_location,work_location,manager,team,pay_group")]
    EmploymentsGroupsHomeLocationWorkLocationManagerTeamPayGroup,

    [EnumMember(Value = "employments,groups,home_location,work_location,pay_group")]
    EmploymentsGroupsHomeLocationWorkLocationPayGroup,

    [EnumMember(Value = "employments,groups,home_location,work_location,team")]
    EmploymentsGroupsHomeLocationWorkLocationTeam,

    [EnumMember(Value = "employments,groups,home_location,work_location,team,company")]
    EmploymentsGroupsHomeLocationWorkLocationTeamCompany,

    [EnumMember(Value = "employments,groups,home_location,work_location,team,company,pay_group")]
    EmploymentsGroupsHomeLocationWorkLocationTeamCompanyPayGroup,

    [EnumMember(Value = "employments,groups,home_location,work_location,team,pay_group")]
    EmploymentsGroupsHomeLocationWorkLocationTeamPayGroup,

    [EnumMember(Value = "employments,groups,manager")]
    EmploymentsGroupsManager,

    [EnumMember(Value = "employments,groups,manager,company")]
    EmploymentsGroupsManagerCompany,

    [EnumMember(Value = "employments,groups,manager,company,pay_group")]
    EmploymentsGroupsManagerCompanyPayGroup,

    [EnumMember(Value = "employments,groups,manager,pay_group")]
    EmploymentsGroupsManagerPayGroup,

    [EnumMember(Value = "employments,groups,manager,team")]
    EmploymentsGroupsManagerTeam,

    [EnumMember(Value = "employments,groups,manager,team,company")]
    EmploymentsGroupsManagerTeamCompany,

    [EnumMember(Value = "employments,groups,manager,team,company,pay_group")]
    EmploymentsGroupsManagerTeamCompanyPayGroup,

    [EnumMember(Value = "employments,groups,manager,team,pay_group")]
    EmploymentsGroupsManagerTeamPayGroup,

    [EnumMember(Value = "employments,groups,pay_group")]
    EmploymentsGroupsPayGroup,

    [EnumMember(Value = "employments,groups,team")]
    EmploymentsGroupsTeam,

    [EnumMember(Value = "employments,groups,team,company")]
    EmploymentsGroupsTeamCompany,

    [EnumMember(Value = "employments,groups,team,company,pay_group")]
    EmploymentsGroupsTeamCompanyPayGroup,

    [EnumMember(Value = "employments,groups,team,pay_group")]
    EmploymentsGroupsTeamPayGroup,

    [EnumMember(Value = "employments,groups,work_location")]
    EmploymentsGroupsWorkLocation,

    [EnumMember(Value = "employments,groups,work_location,company")]
    EmploymentsGroupsWorkLocationCompany,

    [EnumMember(Value = "employments,groups,work_location,company,pay_group")]
    EmploymentsGroupsWorkLocationCompanyPayGroup,

    [EnumMember(Value = "employments,groups,work_location,manager")]
    EmploymentsGroupsWorkLocationManager,

    [EnumMember(Value = "employments,groups,work_location,manager,company")]
    EmploymentsGroupsWorkLocationManagerCompany,

    [EnumMember(Value = "employments,groups,work_location,manager,company,pay_group")]
    EmploymentsGroupsWorkLocationManagerCompanyPayGroup,

    [EnumMember(Value = "employments,groups,work_location,manager,pay_group")]
    EmploymentsGroupsWorkLocationManagerPayGroup,

    [EnumMember(Value = "employments,groups,work_location,manager,team")]
    EmploymentsGroupsWorkLocationManagerTeam,

    [EnumMember(Value = "employments,groups,work_location,manager,team,company")]
    EmploymentsGroupsWorkLocationManagerTeamCompany,

    [EnumMember(Value = "employments,groups,work_location,manager,team,company,pay_group")]
    EmploymentsGroupsWorkLocationManagerTeamCompanyPayGroup,

    [EnumMember(Value = "employments,groups,work_location,manager,team,pay_group")]
    EmploymentsGroupsWorkLocationManagerTeamPayGroup,

    [EnumMember(Value = "employments,groups,work_location,pay_group")]
    EmploymentsGroupsWorkLocationPayGroup,

    [EnumMember(Value = "employments,groups,work_location,team")]
    EmploymentsGroupsWorkLocationTeam,

    [EnumMember(Value = "employments,groups,work_location,team,company")]
    EmploymentsGroupsWorkLocationTeamCompany,

    [EnumMember(Value = "employments,groups,work_location,team,company,pay_group")]
    EmploymentsGroupsWorkLocationTeamCompanyPayGroup,

    [EnumMember(Value = "employments,groups,work_location,team,pay_group")]
    EmploymentsGroupsWorkLocationTeamPayGroup,

    [EnumMember(Value = "employments,home_location")]
    EmploymentsHomeLocation,

    [EnumMember(Value = "employments,home_location,company")]
    EmploymentsHomeLocationCompany,

    [EnumMember(Value = "employments,home_location,company,pay_group")]
    EmploymentsHomeLocationCompanyPayGroup,

    [EnumMember(Value = "employments,home_location,manager")]
    EmploymentsHomeLocationManager,

    [EnumMember(Value = "employments,home_location,manager,company")]
    EmploymentsHomeLocationManagerCompany,

    [EnumMember(Value = "employments,home_location,manager,company,pay_group")]
    EmploymentsHomeLocationManagerCompanyPayGroup,

    [EnumMember(Value = "employments,home_location,manager,pay_group")]
    EmploymentsHomeLocationManagerPayGroup,

    [EnumMember(Value = "employments,home_location,manager,team")]
    EmploymentsHomeLocationManagerTeam,

    [EnumMember(Value = "employments,home_location,manager,team,company")]
    EmploymentsHomeLocationManagerTeamCompany,

    [EnumMember(Value = "employments,home_location,manager,team,company,pay_group")]
    EmploymentsHomeLocationManagerTeamCompanyPayGroup,

    [EnumMember(Value = "employments,home_location,manager,team,pay_group")]
    EmploymentsHomeLocationManagerTeamPayGroup,

    [EnumMember(Value = "employments,home_location,pay_group")]
    EmploymentsHomeLocationPayGroup,

    [EnumMember(Value = "employments,home_location,team")]
    EmploymentsHomeLocationTeam,

    [EnumMember(Value = "employments,home_location,team,company")]
    EmploymentsHomeLocationTeamCompany,

    [EnumMember(Value = "employments,home_location,team,company,pay_group")]
    EmploymentsHomeLocationTeamCompanyPayGroup,

    [EnumMember(Value = "employments,home_location,team,pay_group")]
    EmploymentsHomeLocationTeamPayGroup,

    [EnumMember(Value = "employments,home_location,work_location")]
    EmploymentsHomeLocationWorkLocation,

    [EnumMember(Value = "employments,home_location,work_location,company")]
    EmploymentsHomeLocationWorkLocationCompany,

    [EnumMember(Value = "employments,home_location,work_location,company,pay_group")]
    EmploymentsHomeLocationWorkLocationCompanyPayGroup,

    [EnumMember(Value = "employments,home_location,work_location,manager")]
    EmploymentsHomeLocationWorkLocationManager,

    [EnumMember(Value = "employments,home_location,work_location,manager,company")]
    EmploymentsHomeLocationWorkLocationManagerCompany,

    [EnumMember(Value = "employments,home_location,work_location,manager,company,pay_group")]
    EmploymentsHomeLocationWorkLocationManagerCompanyPayGroup,

    [EnumMember(Value = "employments,home_location,work_location,manager,pay_group")]
    EmploymentsHomeLocationWorkLocationManagerPayGroup,

    [EnumMember(Value = "employments,home_location,work_location,manager,team")]
    EmploymentsHomeLocationWorkLocationManagerTeam,

    [EnumMember(Value = "employments,home_location,work_location,manager,team,company")]
    EmploymentsHomeLocationWorkLocationManagerTeamCompany,

    [EnumMember(Value = "employments,home_location,work_location,manager,team,company,pay_group")]
    EmploymentsHomeLocationWorkLocationManagerTeamCompanyPayGroup,

    [EnumMember(Value = "employments,home_location,work_location,manager,team,pay_group")]
    EmploymentsHomeLocationWorkLocationManagerTeamPayGroup,

    [EnumMember(Value = "employments,home_location,work_location,pay_group")]
    EmploymentsHomeLocationWorkLocationPayGroup,

    [EnumMember(Value = "employments,home_location,work_location,team")]
    EmploymentsHomeLocationWorkLocationTeam,

    [EnumMember(Value = "employments,home_location,work_location,team,company")]
    EmploymentsHomeLocationWorkLocationTeamCompany,

    [EnumMember(Value = "employments,home_location,work_location,team,company,pay_group")]
    EmploymentsHomeLocationWorkLocationTeamCompanyPayGroup,

    [EnumMember(Value = "employments,home_location,work_location,team,pay_group")]
    EmploymentsHomeLocationWorkLocationTeamPayGroup,

    [EnumMember(Value = "employments,manager")]
    EmploymentsManager,

    [EnumMember(Value = "employments,manager,company")]
    EmploymentsManagerCompany,

    [EnumMember(Value = "employments,manager,company,pay_group")]
    EmploymentsManagerCompanyPayGroup,

    [EnumMember(Value = "employments,manager,pay_group")]
    EmploymentsManagerPayGroup,

    [EnumMember(Value = "employments,manager,team")]
    EmploymentsManagerTeam,

    [EnumMember(Value = "employments,manager,team,company")]
    EmploymentsManagerTeamCompany,

    [EnumMember(Value = "employments,manager,team,company,pay_group")]
    EmploymentsManagerTeamCompanyPayGroup,

    [EnumMember(Value = "employments,manager,team,pay_group")]
    EmploymentsManagerTeamPayGroup,

    [EnumMember(Value = "employments,pay_group")]
    EmploymentsPayGroup,

    [EnumMember(Value = "employments,team")]
    EmploymentsTeam,

    [EnumMember(Value = "employments,team,company")]
    EmploymentsTeamCompany,

    [EnumMember(Value = "employments,team,company,pay_group")]
    EmploymentsTeamCompanyPayGroup,

    [EnumMember(Value = "employments,team,pay_group")]
    EmploymentsTeamPayGroup,

    [EnumMember(Value = "employments,work_location")]
    EmploymentsWorkLocation,

    [EnumMember(Value = "employments,work_location,company")]
    EmploymentsWorkLocationCompany,

    [EnumMember(Value = "employments,work_location,company,pay_group")]
    EmploymentsWorkLocationCompanyPayGroup,

    [EnumMember(Value = "employments,work_location,manager")]
    EmploymentsWorkLocationManager,

    [EnumMember(Value = "employments,work_location,manager,company")]
    EmploymentsWorkLocationManagerCompany,

    [EnumMember(Value = "employments,work_location,manager,company,pay_group")]
    EmploymentsWorkLocationManagerCompanyPayGroup,

    [EnumMember(Value = "employments,work_location,manager,pay_group")]
    EmploymentsWorkLocationManagerPayGroup,

    [EnumMember(Value = "employments,work_location,manager,team")]
    EmploymentsWorkLocationManagerTeam,

    [EnumMember(Value = "employments,work_location,manager,team,company")]
    EmploymentsWorkLocationManagerTeamCompany,

    [EnumMember(Value = "employments,work_location,manager,team,company,pay_group")]
    EmploymentsWorkLocationManagerTeamCompanyPayGroup,

    [EnumMember(Value = "employments,work_location,manager,team,pay_group")]
    EmploymentsWorkLocationManagerTeamPayGroup,

    [EnumMember(Value = "employments,work_location,pay_group")]
    EmploymentsWorkLocationPayGroup,

    [EnumMember(Value = "employments,work_location,team")]
    EmploymentsWorkLocationTeam,

    [EnumMember(Value = "employments,work_location,team,company")]
    EmploymentsWorkLocationTeamCompany,

    [EnumMember(Value = "employments,work_location,team,company,pay_group")]
    EmploymentsWorkLocationTeamCompanyPayGroup,

    [EnumMember(Value = "employments,work_location,team,pay_group")]
    EmploymentsWorkLocationTeamPayGroup,

    [EnumMember(Value = "groups")]
    Groups,

    [EnumMember(Value = "groups,company")]
    GroupsCompany,

    [EnumMember(Value = "groups,company,pay_group")]
    GroupsCompanyPayGroup,

    [EnumMember(Value = "groups,home_location")]
    GroupsHomeLocation,

    [EnumMember(Value = "groups,home_location,company")]
    GroupsHomeLocationCompany,

    [EnumMember(Value = "groups,home_location,company,pay_group")]
    GroupsHomeLocationCompanyPayGroup,

    [EnumMember(Value = "groups,home_location,manager")]
    GroupsHomeLocationManager,

    [EnumMember(Value = "groups,home_location,manager,company")]
    GroupsHomeLocationManagerCompany,

    [EnumMember(Value = "groups,home_location,manager,company,pay_group")]
    GroupsHomeLocationManagerCompanyPayGroup,

    [EnumMember(Value = "groups,home_location,manager,pay_group")]
    GroupsHomeLocationManagerPayGroup,

    [EnumMember(Value = "groups,home_location,manager,team")]
    GroupsHomeLocationManagerTeam,

    [EnumMember(Value = "groups,home_location,manager,team,company")]
    GroupsHomeLocationManagerTeamCompany,

    [EnumMember(Value = "groups,home_location,manager,team,company,pay_group")]
    GroupsHomeLocationManagerTeamCompanyPayGroup,

    [EnumMember(Value = "groups,home_location,manager,team,pay_group")]
    GroupsHomeLocationManagerTeamPayGroup,

    [EnumMember(Value = "groups,home_location,pay_group")]
    GroupsHomeLocationPayGroup,

    [EnumMember(Value = "groups,home_location,team")]
    GroupsHomeLocationTeam,

    [EnumMember(Value = "groups,home_location,team,company")]
    GroupsHomeLocationTeamCompany,

    [EnumMember(Value = "groups,home_location,team,company,pay_group")]
    GroupsHomeLocationTeamCompanyPayGroup,

    [EnumMember(Value = "groups,home_location,team,pay_group")]
    GroupsHomeLocationTeamPayGroup,

    [EnumMember(Value = "groups,home_location,work_location")]
    GroupsHomeLocationWorkLocation,

    [EnumMember(Value = "groups,home_location,work_location,company")]
    GroupsHomeLocationWorkLocationCompany,

    [EnumMember(Value = "groups,home_location,work_location,company,pay_group")]
    GroupsHomeLocationWorkLocationCompanyPayGroup,

    [EnumMember(Value = "groups,home_location,work_location,manager")]
    GroupsHomeLocationWorkLocationManager,

    [EnumMember(Value = "groups,home_location,work_location,manager,company")]
    GroupsHomeLocationWorkLocationManagerCompany,

    [EnumMember(Value = "groups,home_location,work_location,manager,company,pay_group")]
    GroupsHomeLocationWorkLocationManagerCompanyPayGroup,

    [EnumMember(Value = "groups,home_location,work_location,manager,pay_group")]
    GroupsHomeLocationWorkLocationManagerPayGroup,

    [EnumMember(Value = "groups,home_location,work_location,manager,team")]
    GroupsHomeLocationWorkLocationManagerTeam,

    [EnumMember(Value = "groups,home_location,work_location,manager,team,company")]
    GroupsHomeLocationWorkLocationManagerTeamCompany,

    [EnumMember(Value = "groups,home_location,work_location,manager,team,company,pay_group")]
    GroupsHomeLocationWorkLocationManagerTeamCompanyPayGroup,

    [EnumMember(Value = "groups,home_location,work_location,manager,team,pay_group")]
    GroupsHomeLocationWorkLocationManagerTeamPayGroup,

    [EnumMember(Value = "groups,home_location,work_location,pay_group")]
    GroupsHomeLocationWorkLocationPayGroup,

    [EnumMember(Value = "groups,home_location,work_location,team")]
    GroupsHomeLocationWorkLocationTeam,

    [EnumMember(Value = "groups,home_location,work_location,team,company")]
    GroupsHomeLocationWorkLocationTeamCompany,

    [EnumMember(Value = "groups,home_location,work_location,team,company,pay_group")]
    GroupsHomeLocationWorkLocationTeamCompanyPayGroup,

    [EnumMember(Value = "groups,home_location,work_location,team,pay_group")]
    GroupsHomeLocationWorkLocationTeamPayGroup,

    [EnumMember(Value = "groups,manager")]
    GroupsManager,

    [EnumMember(Value = "groups,manager,company")]
    GroupsManagerCompany,

    [EnumMember(Value = "groups,manager,company,pay_group")]
    GroupsManagerCompanyPayGroup,

    [EnumMember(Value = "groups,manager,pay_group")]
    GroupsManagerPayGroup,

    [EnumMember(Value = "groups,manager,team")]
    GroupsManagerTeam,

    [EnumMember(Value = "groups,manager,team,company")]
    GroupsManagerTeamCompany,

    [EnumMember(Value = "groups,manager,team,company,pay_group")]
    GroupsManagerTeamCompanyPayGroup,

    [EnumMember(Value = "groups,manager,team,pay_group")]
    GroupsManagerTeamPayGroup,

    [EnumMember(Value = "groups,pay_group")]
    GroupsPayGroup,

    [EnumMember(Value = "groups,team")]
    GroupsTeam,

    [EnumMember(Value = "groups,team,company")]
    GroupsTeamCompany,

    [EnumMember(Value = "groups,team,company,pay_group")]
    GroupsTeamCompanyPayGroup,

    [EnumMember(Value = "groups,team,pay_group")]
    GroupsTeamPayGroup,

    [EnumMember(Value = "groups,work_location")]
    GroupsWorkLocation,

    [EnumMember(Value = "groups,work_location,company")]
    GroupsWorkLocationCompany,

    [EnumMember(Value = "groups,work_location,company,pay_group")]
    GroupsWorkLocationCompanyPayGroup,

    [EnumMember(Value = "groups,work_location,manager")]
    GroupsWorkLocationManager,

    [EnumMember(Value = "groups,work_location,manager,company")]
    GroupsWorkLocationManagerCompany,

    [EnumMember(Value = "groups,work_location,manager,company,pay_group")]
    GroupsWorkLocationManagerCompanyPayGroup,

    [EnumMember(Value = "groups,work_location,manager,pay_group")]
    GroupsWorkLocationManagerPayGroup,

    [EnumMember(Value = "groups,work_location,manager,team")]
    GroupsWorkLocationManagerTeam,

    [EnumMember(Value = "groups,work_location,manager,team,company")]
    GroupsWorkLocationManagerTeamCompany,

    [EnumMember(Value = "groups,work_location,manager,team,company,pay_group")]
    GroupsWorkLocationManagerTeamCompanyPayGroup,

    [EnumMember(Value = "groups,work_location,manager,team,pay_group")]
    GroupsWorkLocationManagerTeamPayGroup,

    [EnumMember(Value = "groups,work_location,pay_group")]
    GroupsWorkLocationPayGroup,

    [EnumMember(Value = "groups,work_location,team")]
    GroupsWorkLocationTeam,

    [EnumMember(Value = "groups,work_location,team,company")]
    GroupsWorkLocationTeamCompany,

    [EnumMember(Value = "groups,work_location,team,company,pay_group")]
    GroupsWorkLocationTeamCompanyPayGroup,

    [EnumMember(Value = "groups,work_location,team,pay_group")]
    GroupsWorkLocationTeamPayGroup,

    [EnumMember(Value = "home_location")]
    HomeLocation,

    [EnumMember(Value = "home_location,company")]
    HomeLocationCompany,

    [EnumMember(Value = "home_location,company,pay_group")]
    HomeLocationCompanyPayGroup,

    [EnumMember(Value = "home_location,manager")]
    HomeLocationManager,

    [EnumMember(Value = "home_location,manager,company")]
    HomeLocationManagerCompany,

    [EnumMember(Value = "home_location,manager,company,pay_group")]
    HomeLocationManagerCompanyPayGroup,

    [EnumMember(Value = "home_location,manager,pay_group")]
    HomeLocationManagerPayGroup,

    [EnumMember(Value = "home_location,manager,team")]
    HomeLocationManagerTeam,

    [EnumMember(Value = "home_location,manager,team,company")]
    HomeLocationManagerTeamCompany,

    [EnumMember(Value = "home_location,manager,team,company,pay_group")]
    HomeLocationManagerTeamCompanyPayGroup,

    [EnumMember(Value = "home_location,manager,team,pay_group")]
    HomeLocationManagerTeamPayGroup,

    [EnumMember(Value = "home_location,pay_group")]
    HomeLocationPayGroup,

    [EnumMember(Value = "home_location,team")]
    HomeLocationTeam,

    [EnumMember(Value = "home_location,team,company")]
    HomeLocationTeamCompany,

    [EnumMember(Value = "home_location,team,company,pay_group")]
    HomeLocationTeamCompanyPayGroup,

    [EnumMember(Value = "home_location,team,pay_group")]
    HomeLocationTeamPayGroup,

    [EnumMember(Value = "home_location,work_location")]
    HomeLocationWorkLocation,

    [EnumMember(Value = "home_location,work_location,company")]
    HomeLocationWorkLocationCompany,

    [EnumMember(Value = "home_location,work_location,company,pay_group")]
    HomeLocationWorkLocationCompanyPayGroup,

    [EnumMember(Value = "home_location,work_location,manager")]
    HomeLocationWorkLocationManager,

    [EnumMember(Value = "home_location,work_location,manager,company")]
    HomeLocationWorkLocationManagerCompany,

    [EnumMember(Value = "home_location,work_location,manager,company,pay_group")]
    HomeLocationWorkLocationManagerCompanyPayGroup,

    [EnumMember(Value = "home_location,work_location,manager,pay_group")]
    HomeLocationWorkLocationManagerPayGroup,

    [EnumMember(Value = "home_location,work_location,manager,team")]
    HomeLocationWorkLocationManagerTeam,

    [EnumMember(Value = "home_location,work_location,manager,team,company")]
    HomeLocationWorkLocationManagerTeamCompany,

    [EnumMember(Value = "home_location,work_location,manager,team,company,pay_group")]
    HomeLocationWorkLocationManagerTeamCompanyPayGroup,

    [EnumMember(Value = "home_location,work_location,manager,team,pay_group")]
    HomeLocationWorkLocationManagerTeamPayGroup,

    [EnumMember(Value = "home_location,work_location,pay_group")]
    HomeLocationWorkLocationPayGroup,

    [EnumMember(Value = "home_location,work_location,team")]
    HomeLocationWorkLocationTeam,

    [EnumMember(Value = "home_location,work_location,team,company")]
    HomeLocationWorkLocationTeamCompany,

    [EnumMember(Value = "home_location,work_location,team,company,pay_group")]
    HomeLocationWorkLocationTeamCompanyPayGroup,

    [EnumMember(Value = "home_location,work_location,team,pay_group")]
    HomeLocationWorkLocationTeamPayGroup,

    [EnumMember(Value = "manager")]
    Manager,

    [EnumMember(Value = "manager,company")]
    ManagerCompany,

    [EnumMember(Value = "manager,company,pay_group")]
    ManagerCompanyPayGroup,

    [EnumMember(Value = "manager,pay_group")]
    ManagerPayGroup,

    [EnumMember(Value = "manager,team")]
    ManagerTeam,

    [EnumMember(Value = "manager,team,company")]
    ManagerTeamCompany,

    [EnumMember(Value = "manager,team,company,pay_group")]
    ManagerTeamCompanyPayGroup,

    [EnumMember(Value = "manager,team,pay_group")]
    ManagerTeamPayGroup,

    [EnumMember(Value = "pay_group")]
    PayGroup,

    [EnumMember(Value = "team")]
    Team,

    [EnumMember(Value = "team,company")]
    TeamCompany,

    [EnumMember(Value = "team,company,pay_group")]
    TeamCompanyPayGroup,

    [EnumMember(Value = "team,pay_group")]
    TeamPayGroup,

    [EnumMember(Value = "work_location")]
    WorkLocation,

    [EnumMember(Value = "work_location,company")]
    WorkLocationCompany,

    [EnumMember(Value = "work_location,company,pay_group")]
    WorkLocationCompanyPayGroup,

    [EnumMember(Value = "work_location,manager")]
    WorkLocationManager,

    [EnumMember(Value = "work_location,manager,company")]
    WorkLocationManagerCompany,

    [EnumMember(Value = "work_location,manager,company,pay_group")]
    WorkLocationManagerCompanyPayGroup,

    [EnumMember(Value = "work_location,manager,pay_group")]
    WorkLocationManagerPayGroup,

    [EnumMember(Value = "work_location,manager,team")]
    WorkLocationManagerTeam,

    [EnumMember(Value = "work_location,manager,team,company")]
    WorkLocationManagerTeamCompany,

    [EnumMember(Value = "work_location,manager,team,company,pay_group")]
    WorkLocationManagerTeamCompanyPayGroup,

    [EnumMember(Value = "work_location,manager,team,pay_group")]
    WorkLocationManagerTeamPayGroup,

    [EnumMember(Value = "work_location,pay_group")]
    WorkLocationPayGroup,

    [EnumMember(Value = "work_location,team")]
    WorkLocationTeam,

    [EnumMember(Value = "work_location,team,company")]
    WorkLocationTeamCompany,

    [EnumMember(Value = "work_location,team,company,pay_group")]
    WorkLocationTeamCompanyPayGroup,

    [EnumMember(Value = "work_location,team,pay_group")]
    WorkLocationTeamPayGroup
}
