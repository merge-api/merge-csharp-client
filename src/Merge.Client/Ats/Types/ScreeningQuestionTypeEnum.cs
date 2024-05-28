using System.Runtime.Serialization;

#nullable enable

namespace Merge.Client.Ats;

public enum ScreeningQuestionTypeEnum
{
    [EnumMember(Value = "DATE")]
    Date,

    [EnumMember(Value = "FILE")]
    File,

    [EnumMember(Value = "SINGLE_SELECT")]
    SingleSelect,

    [EnumMember(Value = "MULTI_SELECT")]
    MultiSelect,

    [EnumMember(Value = "SINGLE_LINE_TEXT")]
    SingleLineText,

    [EnumMember(Value = "MULTI_LINE_TEXT")]
    MultiLineText,

    [EnumMember(Value = "NUMERIC")]
    Numeric,

    [EnumMember(Value = "BOOLEAN")]
    Boolean
}
