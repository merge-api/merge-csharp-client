using System.Text.Json.Serialization;
using System;
using Merge.Client.Utilities;

namespace Merge.Client.Ats;

[JsonConverter(typeof(TolerantEnumConverter))]
public enum JobsScreeningQuestionsListRequestExpand
{
    [EnumMember(Value = "job")]
    Job,

    [EnumMember(Value = "options")]
    Options,

    [EnumMember(Value = "options,job")]
    OptionsJob
}
