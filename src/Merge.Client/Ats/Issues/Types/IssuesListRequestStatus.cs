using System.Text.Json.Serialization;
using Merge.Client.Core;

namespace Merge.Client.Ats;

[JsonConverter(typeof(StringEnumSerializer<IssuesListRequestStatus>))]
public readonly record struct IssuesListRequestStatus : IStringEnum
{
    public static readonly IssuesListRequestStatus Ongoing = new(Values.Ongoing);

    public static readonly IssuesListRequestStatus Resolved = new(Values.Resolved);

    public IssuesListRequestStatus(string value)
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
    public static IssuesListRequestStatus FromCustom(string value)
    {
        return new IssuesListRequestStatus(value);
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

    public static bool operator ==(IssuesListRequestStatus value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(IssuesListRequestStatus value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(IssuesListRequestStatus value) => value.Value;

    public static explicit operator IssuesListRequestStatus(string value) => new(value);

    /// <summary>
    /// Constant strings for enum values
    /// </summary>
    public static class Values
    {
        public const string Ongoing = "ONGOING";

        public const string Resolved = "RESOLVED";
    }
}
