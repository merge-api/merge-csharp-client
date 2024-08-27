using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Merge.Client.Core;

#nullable enable

namespace Merge.Client.Ats;

[JsonConverter(typeof(StringEnumSerializer<JobsScreeningQuestionsListRequestExpand>))]
public enum JobsScreeningQuestionsListRequestExpand
{
    [EnumMember(Value = "job")]
    Job,

    [EnumMember(Value = "options")]
    Options,

    [EnumMember(Value = "options,job")]
    OptionsJob,
}
