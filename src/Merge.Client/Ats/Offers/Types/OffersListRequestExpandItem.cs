using System.Text.Json.Serialization;
using Merge.Client.Core;

namespace Merge.Client.Ats;

[JsonConverter(typeof(StringEnumSerializer<OffersListRequestExpandItem>))]
[Serializable]
public readonly record struct OffersListRequestExpandItem : IStringEnum
{
    public static readonly OffersListRequestExpandItem Application = new(Values.Application);

    public static readonly OffersListRequestExpandItem Creator = new(Values.Creator);

    public OffersListRequestExpandItem(string value)
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
    public static OffersListRequestExpandItem FromCustom(string value)
    {
        return new OffersListRequestExpandItem(value);
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

    public static bool operator ==(OffersListRequestExpandItem value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(OffersListRequestExpandItem value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(OffersListRequestExpandItem value) => value.Value;

    public static explicit operator OffersListRequestExpandItem(string value) => new(value);

    /// <summary>
    /// Constant strings for enum values
    /// </summary>
    [Serializable]
    public static class Values
    {
        public const string Application = "application";

        public const string Creator = "creator";
    }
}
