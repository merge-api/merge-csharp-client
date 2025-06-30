using System.Text.Json.Serialization;
using Merge.Client.Core;

namespace Merge.Client.Hris;

[JsonConverter(typeof(StringEnumSerializer<RunStateEnum>))]
[Serializable]
public readonly record struct RunStateEnum : IStringEnum
{
    public static readonly RunStateEnum Paid = new(Values.Paid);

    public static readonly RunStateEnum Draft = new(Values.Draft);

    public static readonly RunStateEnum Approved = new(Values.Approved);

    public static readonly RunStateEnum Failed = new(Values.Failed);

    public static readonly RunStateEnum Closed = new(Values.Closed);

    public RunStateEnum(string value)
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
    public static RunStateEnum FromCustom(string value)
    {
        return new RunStateEnum(value);
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

    public static bool operator ==(RunStateEnum value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(RunStateEnum value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(RunStateEnum value) => value.Value;

    public static explicit operator RunStateEnum(string value) => new(value);

    /// <summary>
    /// Constant strings for enum values
    /// </summary>
    [Serializable]
    public static class Values
    {
        public const string Paid = "PAID";

        public const string Draft = "DRAFT";

        public const string Approved = "APPROVED";

        public const string Failed = "FAILED";

        public const string Closed = "CLOSED";
    }
}
