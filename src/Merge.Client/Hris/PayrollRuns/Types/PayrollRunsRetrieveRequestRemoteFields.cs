using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Merge.Client.Core;

#nullable enable

namespace Merge.Client.Hris;

[JsonConverter(typeof(StringEnumSerializer<PayrollRunsRetrieveRequestRemoteFields>))]
public enum PayrollRunsRetrieveRequestRemoteFields
{
    [EnumMember(Value = "run_state")]
    RunState,

    [EnumMember(Value = "run_state,run_type")]
    RunStateRunType,

    [EnumMember(Value = "run_type")]
    RunType
}
