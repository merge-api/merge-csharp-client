using System.Runtime.Serialization;

namespace Merge.Client.Hris;

public enum PayrollRunsListRequestShowEnumOrigins
{
    [EnumMember(Value = "run_state")]
    RunState,

    [EnumMember(Value = "run_state,run_type")]
    RunStateRunType,

    [EnumMember(Value = "run_type")]
    RunType
}
