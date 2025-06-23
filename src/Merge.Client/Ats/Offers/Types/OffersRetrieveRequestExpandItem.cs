using System.Text.Json.Serialization;
using Merge.Client.Core;

namespace Merge.Client.Ats;

[JsonConverter(typeof(StringEnumSerializer<OffersRetrieveRequestExpandItem>))]
public readonly record struct OffersRetrieveRequestExpandItem : IStringEnum
{
    public static readonly OffersRetrieveRequestExpandItem Application = new(Values.Application);

    public static readonly OffersRetrieveRequestExpandItem Creator = new(Values.Creator);

    public OffersRetrieveRequestExpandItem(string value)
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
    public static OffersRetrieveRequestExpandItem FromCustom(string value)
    {
        return new OffersRetrieveRequestExpandItem(value);
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

    public static bool operator ==(OffersRetrieveRequestExpandItem value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(OffersRetrieveRequestExpandItem value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(OffersRetrieveRequestExpandItem value) => value.Value;

    public static explicit operator OffersRetrieveRequestExpandItem(string value) => new(value);

    /// <summary>
    /// Constant strings for enum values
    /// </summary>
    public static class Values
    {
        public const string Application = "application";

        public const string Creator = "creator";
    }
}
