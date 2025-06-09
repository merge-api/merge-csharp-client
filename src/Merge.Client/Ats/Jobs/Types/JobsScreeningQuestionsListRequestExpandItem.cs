using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Merge.Client.Core;

namespace Merge.Client.Ats;

[JsonConverter(typeof(EnumSerializer<JobsScreeningQuestionsListRequestExpandItem>))]
public enum JobsScreeningQuestionsListRequestExpandItem
{
    [EnumMember(Value = "job")]
    Job,

    [EnumMember(Value = "options")]
    Options,
}
