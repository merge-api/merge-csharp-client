using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Merge.Client.Core;

namespace Merge.Client.Ats;

[JsonConverter(typeof(EnumSerializer<JobsListRequestExpandItem>))]
public enum JobsListRequestExpandItem
{
    [EnumMember(Value = "departments")]
    Departments,

    [EnumMember(Value = "hiring_managers")]
    HiringManagers,

    [EnumMember(Value = "job_postings")]
    JobPostings,

    [EnumMember(Value = "offices")]
    Offices,

    [EnumMember(Value = "recruiters")]
    Recruiters,
}
