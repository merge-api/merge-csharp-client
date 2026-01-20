using System.Text.Json.Serialization;
using Merge.Client.Core;

namespace Merge.Client.Crm;

[JsonConverter(typeof(StringEnumSerializer<OpportunitiesListRequestRemoteFields>))]
[Serializable]
public readonly record struct OpportunitiesListRequestRemoteFields : IStringEnum
{
    public static readonly OpportunitiesListRequestRemoteFields Status = new(Values.Status);

    public OpportunitiesListRequestRemoteFields(string value)
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
    public static OpportunitiesListRequestRemoteFields FromCustom(string value)
    {
        return new OpportunitiesListRequestRemoteFields(value);
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

    public static bool operator ==(OpportunitiesListRequestRemoteFields value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(OpportunitiesListRequestRemoteFields value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(OpportunitiesListRequestRemoteFields value) =>
        value.Value;

    public static explicit operator OpportunitiesListRequestRemoteFields(string value) =>
        new(value);

    /// <summary>
    /// Constant strings for enum values
    /// </summary>
    [Serializable]
    public static class Values
    {
        public const string Status = "status";
    }
}
