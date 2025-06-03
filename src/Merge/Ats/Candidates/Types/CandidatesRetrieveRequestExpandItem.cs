using System.Text.Json.Serialization;
using Merge.Core;

namespace Merge.Ats.Candidates;

[JsonConverter(typeof(StringEnumSerializer<CandidatesRetrieveRequestExpandItem>))]
public readonly record struct CandidatesRetrieveRequestExpandItem : IStringEnum
{
    public static readonly CandidatesRetrieveRequestExpandItem Applications = new(
        Values.Applications
    );

    public static readonly CandidatesRetrieveRequestExpandItem Attachments = new(
        Values.Attachments
    );

    public CandidatesRetrieveRequestExpandItem(string value)
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
    public static CandidatesRetrieveRequestExpandItem FromCustom(string value)
    {
        return new CandidatesRetrieveRequestExpandItem(value);
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

    public static bool operator ==(CandidatesRetrieveRequestExpandItem value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(CandidatesRetrieveRequestExpandItem value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(CandidatesRetrieveRequestExpandItem value) =>
        value.Value;

    public static explicit operator CandidatesRetrieveRequestExpandItem(string value) => new(value);

    /// <summary>
    /// Constant strings for enum values
    /// </summary>
    public static class Values
    {
        public const string Applications = "applications";

        public const string Attachments = "attachments";
    }
}
