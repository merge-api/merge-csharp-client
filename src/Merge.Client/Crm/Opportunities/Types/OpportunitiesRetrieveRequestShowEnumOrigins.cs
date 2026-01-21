using System.Text.Json.Serialization;
using Merge.Client.Core;

namespace Merge.Client.Crm;

[JsonConverter(typeof(StringEnumSerializer<OpportunitiesRetrieveRequestShowEnumOrigins>))]
[Serializable]
public readonly record struct OpportunitiesRetrieveRequestShowEnumOrigins : IStringEnum
{
    public static readonly OpportunitiesRetrieveRequestShowEnumOrigins Status = new(Values.Status);

    public OpportunitiesRetrieveRequestShowEnumOrigins(string value)
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
    public static OpportunitiesRetrieveRequestShowEnumOrigins FromCustom(string value)
    {
        return new OpportunitiesRetrieveRequestShowEnumOrigins(value);
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

    public static bool operator ==(
        OpportunitiesRetrieveRequestShowEnumOrigins value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        OpportunitiesRetrieveRequestShowEnumOrigins value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(OpportunitiesRetrieveRequestShowEnumOrigins value) =>
        value.Value;

    public static explicit operator OpportunitiesRetrieveRequestShowEnumOrigins(string value) =>
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
