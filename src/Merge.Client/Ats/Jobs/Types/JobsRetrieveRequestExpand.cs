using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Merge.Client.Ats;
using Merge.Client.Core;

#nullable enable

namespace Merge.Client.Ats;

[JsonConverter(typeof(StringEnumSerializer<JobsRetrieveRequestExpand>))]
public enum JobsRetrieveRequestExpand
{
    [EnumMember(Value = "departments")]
    Departments,

    [EnumMember(Value = "departments,hiring_managers")]
    DepartmentsHiringManagers,

    [EnumMember(Value = "departments,hiring_managers,job_postings")]
    DepartmentsHiringManagersJobPostings,

    [EnumMember(Value = "departments,hiring_managers,job_postings,recruiters")]
    DepartmentsHiringManagersJobPostingsRecruiters,

    [EnumMember(Value = "departments,hiring_managers,recruiters")]
    DepartmentsHiringManagersRecruiters,

    [EnumMember(Value = "departments,job_postings")]
    DepartmentsJobPostings,

    [EnumMember(Value = "departments,job_postings,recruiters")]
    DepartmentsJobPostingsRecruiters,

    [EnumMember(Value = "departments,offices")]
    DepartmentsOffices,

    [EnumMember(Value = "departments,offices,hiring_managers")]
    DepartmentsOfficesHiringManagers,

    [EnumMember(Value = "departments,offices,hiring_managers,job_postings")]
    DepartmentsOfficesHiringManagersJobPostings,

    [EnumMember(Value = "departments,offices,hiring_managers,job_postings,recruiters")]
    DepartmentsOfficesHiringManagersJobPostingsRecruiters,

    [EnumMember(Value = "departments,offices,hiring_managers,recruiters")]
    DepartmentsOfficesHiringManagersRecruiters,

    [EnumMember(Value = "departments,offices,job_postings")]
    DepartmentsOfficesJobPostings,

    [EnumMember(Value = "departments,offices,job_postings,recruiters")]
    DepartmentsOfficesJobPostingsRecruiters,

    [EnumMember(Value = "departments,offices,recruiters")]
    DepartmentsOfficesRecruiters,

    [EnumMember(Value = "departments,recruiters")]
    DepartmentsRecruiters,

    [EnumMember(Value = "hiring_managers")]
    HiringManagers,

    [EnumMember(Value = "hiring_managers,job_postings")]
    HiringManagersJobPostings,

    [EnumMember(Value = "hiring_managers,job_postings,recruiters")]
    HiringManagersJobPostingsRecruiters,

    [EnumMember(Value = "hiring_managers,recruiters")]
    HiringManagersRecruiters,

    [EnumMember(Value = "job_postings")]
    JobPostings,

    [EnumMember(Value = "job_postings,recruiters")]
    JobPostingsRecruiters,

    [EnumMember(Value = "offices")]
    Offices,

    [EnumMember(Value = "offices,hiring_managers")]
    OfficesHiringManagers,

    [EnumMember(Value = "offices,hiring_managers,job_postings")]
    OfficesHiringManagersJobPostings,

    [EnumMember(Value = "offices,hiring_managers,job_postings,recruiters")]
    OfficesHiringManagersJobPostingsRecruiters,

    [EnumMember(Value = "offices,hiring_managers,recruiters")]
    OfficesHiringManagersRecruiters,

    [EnumMember(Value = "offices,job_postings")]
    OfficesJobPostings,

    [EnumMember(Value = "offices,job_postings,recruiters")]
    OfficesJobPostingsRecruiters,

    [EnumMember(Value = "offices,recruiters")]
    OfficesRecruiters,

    [EnumMember(Value = "recruiters")]
    Recruiters
}
