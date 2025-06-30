using System.Text.Json.Serialization;
using Merge.Client.Core;

namespace Merge.Client.Ats;

[JsonConverter(typeof(StringEnumSerializer<ScreeningQuestionTypeEnum>))]
[Serializable]
public readonly record struct ScreeningQuestionTypeEnum : IStringEnum
{
    public static readonly ScreeningQuestionTypeEnum Date = new(Values.Date);

    public static readonly ScreeningQuestionTypeEnum File = new(Values.File);

    public static readonly ScreeningQuestionTypeEnum SingleSelect = new(Values.SingleSelect);

    public static readonly ScreeningQuestionTypeEnum MultiSelect = new(Values.MultiSelect);

    public static readonly ScreeningQuestionTypeEnum SingleLineText = new(Values.SingleLineText);

    public static readonly ScreeningQuestionTypeEnum MultiLineText = new(Values.MultiLineText);

    public static readonly ScreeningQuestionTypeEnum Numeric = new(Values.Numeric);

    public static readonly ScreeningQuestionTypeEnum Boolean = new(Values.Boolean);

    public ScreeningQuestionTypeEnum(string value)
    {
        Value = value;
    }

    /// <summary>
    /// The string value of the enum.
    /// </summary>
    public string Value { get; }

    /// <summary>
    /// Create a string enum with the given value.
    /// </summary>
    public static ScreeningQuestionTypeEnum FromCustom(string value)
    {
        return new ScreeningQuestionTypeEnum(value);
    }

    public bool Equals(string? other)
    {
        return Value.Equals(other);
    }

    /// <summary>
    /// Returns the string value of the enum.
    /// </summary>
    public override string ToString()
    {
        return Value;
    }

    public static bool operator ==(ScreeningQuestionTypeEnum value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(ScreeningQuestionTypeEnum value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(ScreeningQuestionTypeEnum value) => value.Value;

    public static explicit operator ScreeningQuestionTypeEnum(string value) => new(value);

    /// <summary>
    /// Constant strings for enum values
    /// </summary>
    [Serializable]
    public static class Values
    {
        public const string Date = "DATE";

        public const string File = "FILE";

        public const string SingleSelect = "SINGLE_SELECT";

        public const string MultiSelect = "MULTI_SELECT";

        public const string SingleLineText = "SINGLE_LINE_TEXT";

        public const string MultiLineText = "MULTI_LINE_TEXT";

        public const string Numeric = "NUMERIC";

        public const string Boolean = "BOOLEAN";
    }
}
