using System.Text.Json.Serialization;
using Merge.Core;

namespace Merge.Ticketing;

[JsonConverter(typeof(StringEnumSerializer<IssueStatusEnum>))]
public readonly record struct IssueStatusEnum : IStringEnum
{
    public static readonly IssueStatusEnum Ongoing = new(Values.Ongoing);

    public static readonly IssueStatusEnum Resolved = new(Values.Resolved);

    public IssueStatusEnum(string value)
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
    public static IssueStatusEnum FromCustom(string value)
    {
        return new IssueStatusEnum(value);
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

    public static bool operator ==(IssueStatusEnum value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(IssueStatusEnum value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(IssueStatusEnum value) => value.Value;

    public static explicit operator IssueStatusEnum(string value) => new(value);

    /// <summary>
    /// Constant strings for enum values
    /// </summary>
    public static class Values
    {
        public const string Ongoing = "ONGOING";

        public const string Resolved = "RESOLVED";
    }
}
