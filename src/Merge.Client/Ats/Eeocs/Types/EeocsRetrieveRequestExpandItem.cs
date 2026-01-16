using System.Text.Json.Serialization;
using Merge.Client.Core;

namespace Merge.Client.Ats;

[JsonConverter(typeof(StringEnumSerializer<EeocsRetrieveRequestExpandItem>))]
[Serializable]
public readonly record struct EeocsRetrieveRequestExpandItem : IStringEnum
{
    public static readonly EeocsRetrieveRequestExpandItem Candidate = new(Values.Candidate);

    public EeocsRetrieveRequestExpandItem(string value)
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
    public static EeocsRetrieveRequestExpandItem FromCustom(string value)
    {
        return new EeocsRetrieveRequestExpandItem(value);
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

    public static bool operator ==(EeocsRetrieveRequestExpandItem value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(EeocsRetrieveRequestExpandItem value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(EeocsRetrieveRequestExpandItem value) => value.Value;

    public static explicit operator EeocsRetrieveRequestExpandItem(string value) => new(value);

    /// <summary>
    /// Constant strings for enum values
    /// </summary>
    [Serializable]
    public static class Values
    {
        public const string Candidate = "candidate";
    }
}
