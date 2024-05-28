using System.Runtime.Serialization;

#nullable enable

namespace Merge.Client.Ats;

public enum JobsScreeningQuestionsListRequestExpand
{
    [EnumMember(Value = "job")]
    Job,

    [EnumMember(Value = "options")]
    Options,

    [EnumMember(Value = "options,job")]
    OptionsJob
}
