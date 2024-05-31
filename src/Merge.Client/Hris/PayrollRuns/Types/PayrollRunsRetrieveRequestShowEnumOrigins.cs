using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Merge.Client.Core;
using Merge.Client.Hris;

#nullable enable

namespace Merge.Client.Hris;

[JsonConverter(typeof(StringEnumSerializer<PayrollRunsRetrieveRequestShowEnumOrigins>))]
public enum PayrollRunsRetrieveRequestShowEnumOrigins
{
    [EnumMember(Value = "run_state")]
    RunState,

    [EnumMember(Value = "run_state,run_type")]
    RunStateRunType,

    [EnumMember(Value = "run_type")]
    RunType
}
