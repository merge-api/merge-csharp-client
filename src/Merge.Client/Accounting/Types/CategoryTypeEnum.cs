using System.Runtime.Serialization;

#nullable enable

namespace Merge.Client.Accounting;

public enum CategoryTypeEnum
{
    [EnumMember(Value = "CLASS")]
    Class,

    [EnumMember(Value = "DEPARTMENT")]
    Department
}
