using System.Runtime.Serialization;

namespace Merge.Client.Ats;

public enum JobsRetrieveRequestExpand
{
    [EnumMember(Value = "departments")]
    Departments,

    [EnumMember(Value = "departments,hiring_managers")]
    DepartmentsHiringManagers,

    [EnumMember(Value = "departments,hiring_managers,recruiters")]
    DepartmentsHiringManagersRecruiters,

    [EnumMember(Value = "departments,offices")]
    DepartmentsOffices,

    [EnumMember(Value = "departments,offices,hiring_managers")]
    DepartmentsOfficesHiringManagers,

    [EnumMember(Value = "departments,offices,hiring_managers,recruiters")]
    DepartmentsOfficesHiringManagersRecruiters,

    [EnumMember(Value = "departments,offices,recruiters")]
    DepartmentsOfficesRecruiters,

    [EnumMember(Value = "departments,recruiters")]
    DepartmentsRecruiters,

    [EnumMember(Value = "hiring_managers")]
    HiringManagers,

    [EnumMember(Value = "hiring_managers,recruiters")]
    HiringManagersRecruiters,

    [EnumMember(Value = "offices")]
    Offices,

    [EnumMember(Value = "offices,hiring_managers")]
    OfficesHiringManagers,

    [EnumMember(Value = "offices,hiring_managers,recruiters")]
    OfficesHiringManagersRecruiters,

    [EnumMember(Value = "offices,recruiters")]
    OfficesRecruiters,

    [EnumMember(Value = "recruiters")]
    Recruiters
}
