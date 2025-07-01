using System.Text.Json.Serialization;
using Merge.Client.Core;

namespace Merge.Client.Crm;

[JsonConverter(typeof(StringEnumSerializer<OpportunitiesListRequestStatus>))]
[Serializable]
public readonly record struct OpportunitiesListRequestStatus : IStringEnum
{
    public static readonly OpportunitiesListRequestStatus Lost = new(Values.Lost);

    public static readonly OpportunitiesListRequestStatus Open = new(Values.Open);

    public static readonly OpportunitiesListRequestStatus Won = new(Values.Won);

    public OpportunitiesListRequestStatus(string value)
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
    public static OpportunitiesListRequestStatus FromCustom(string value)
    {
        return new OpportunitiesListRequestStatus(value);
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

    public static bool operator ==(OpportunitiesListRequestStatus value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(OpportunitiesListRequestStatus value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(OpportunitiesListRequestStatus value) => value.Value;

    public static explicit operator OpportunitiesListRequestStatus(string value) => new(value);

    /// <summary>
    /// Constant strings for enum values
    /// </summary>
    [Serializable]
    public static class Values
    {
        public const string Lost = "LOST";

        public const string Open = "OPEN";

        public const string Won = "WON";
    }
}
