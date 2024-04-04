using System.Text.Json.Serialization;
using System;
using Merge.Client.Utilities;

namespace Merge.Client.Hris;

[JsonConverter(typeof(TolerantEnumConverter))]
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
