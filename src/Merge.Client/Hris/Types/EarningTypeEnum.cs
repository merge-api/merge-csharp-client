using System.Runtime.Serialization;

#nullable enable

namespace Merge.Client.Hris;

public enum EarningTypeEnum
{
    [EnumMember(Value = "SALARY")]
    Salary,

    [EnumMember(Value = "REIMBURSEMENT")]
    Reimbursement,

    [EnumMember(Value = "OVERTIME")]
    Overtime,

    [EnumMember(Value = "BONUS")]
    Bonus
}
