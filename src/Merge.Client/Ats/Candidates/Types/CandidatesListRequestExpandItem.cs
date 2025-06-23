using System.Text.Json.Serialization;
using Merge.Client.Core;

namespace Merge.Client.Ats;

[JsonConverter(typeof(StringEnumSerializer<CandidatesListRequestExpandItem>))]
public readonly record struct CandidatesListRequestExpandItem : IStringEnum
{
    public static readonly CandidatesListRequestExpandItem Applications = new(Values.Applications);

    public static readonly CandidatesListRequestExpandItem Attachments = new(Values.Attachments);

    public CandidatesListRequestExpandItem(string value)
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
    public static CandidatesListRequestExpandItem FromCustom(string value)
    {
        return new CandidatesListRequestExpandItem(value);
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

    public static bool operator ==(CandidatesListRequestExpandItem value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(CandidatesListRequestExpandItem value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(CandidatesListRequestExpandItem value) => value.Value;

    public static explicit operator CandidatesListRequestExpandItem(string value) => new(value);

    /// <summary>
    /// Constant strings for enum values
    /// </summary>
    public static class Values
    {
        public const string Applications = "applications";

        public const string Attachments = "attachments";
    }
}
