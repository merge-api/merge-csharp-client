using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Merge.Client.Core;

namespace Merge.Client.Ats;

[JsonConverter(typeof(EnumSerializer<JobsScreeningQuestionsListRequestExpand>))]
public enum JobsScreeningQuestionsListRequestExpand
{
    [EnumMember(Value = "job")]
    Job,

    [EnumMember(Value = "options")]
    Options,

    [EnumMember(Value = "options,job")]
    OptionsJob,
}
