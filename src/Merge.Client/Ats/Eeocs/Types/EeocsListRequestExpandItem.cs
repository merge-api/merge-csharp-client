using System.Text.Json.Serialization;
using Merge.Client.Core;

namespace Merge.Client.Ats;

[JsonConverter(typeof(StringEnumSerializer<EeocsListRequestExpandItem>))]
[Serializable]
public readonly record struct EeocsListRequestExpandItem : IStringEnum
{
    public static readonly EeocsListRequestExpandItem Candidate = new(Values.Candidate);

    public EeocsListRequestExpandItem(string value)
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
    public static EeocsListRequestExpandItem FromCustom(string value)
    {
        return new EeocsListRequestExpandItem(value);
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

    public static bool operator ==(EeocsListRequestExpandItem value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(EeocsListRequestExpandItem value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(EeocsListRequestExpandItem value) => value.Value;

    public static explicit operator EeocsListRequestExpandItem(string value) => new(value);

    /// <summary>
    /// Constant strings for enum values
    /// </summary>
    [Serializable]
    public static class Values
    {
        public const string Candidate = "candidate";
    }
}
