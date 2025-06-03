using System.Text.Json.Serialization;
using Merge.Core;

namespace Merge.Crm.Opportunities;

[JsonConverter(typeof(StringEnumSerializer<OpportunitiesRetrieveRequestExpandItem>))]
public readonly record struct OpportunitiesRetrieveRequestExpandItem : IStringEnum
{
    public static readonly OpportunitiesRetrieveRequestExpandItem Account = new(Values.Account);

    public static readonly OpportunitiesRetrieveRequestExpandItem Owner = new(Values.Owner);

    public static readonly OpportunitiesRetrieveRequestExpandItem Stage = new(Values.Stage);

    public OpportunitiesRetrieveRequestExpandItem(string value)
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
    public static OpportunitiesRetrieveRequestExpandItem FromCustom(string value)
    {
        return new OpportunitiesRetrieveRequestExpandItem(value);
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

    public static bool operator ==(OpportunitiesRetrieveRequestExpandItem value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(OpportunitiesRetrieveRequestExpandItem value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(OpportunitiesRetrieveRequestExpandItem value) =>
        value.Value;

    public static explicit operator OpportunitiesRetrieveRequestExpandItem(string value) =>
        new(value);

    /// <summary>
    /// Constant strings for enum values
    /// </summary>
    public static class Values
    {
        public const string Account = "account";

        public const string Owner = "owner";

        public const string Stage = "stage";
    }
}
