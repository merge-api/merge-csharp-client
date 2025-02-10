using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Merge.Client.Core;

namespace Merge.Client.Hris;

[JsonConverter(typeof(EnumSerializer<EarningTypeEnum>))]
public enum EarningTypeEnum
{
    [EnumMember(Value = "SALARY")]
    Salary,

    [EnumMember(Value = "REIMBURSEMENT")]
    Reimbursement,

    [EnumMember(Value = "OVERTIME")]
    Overtime,

    [EnumMember(Value = "BONUS")]
    Bonus,
}
