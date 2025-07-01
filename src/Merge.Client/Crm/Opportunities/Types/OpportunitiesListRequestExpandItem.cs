using System.Text.Json.Serialization;
using Merge.Client.Core;

namespace Merge.Client.Crm;

[JsonConverter(typeof(StringEnumSerializer<OpportunitiesListRequestExpandItem>))]
[Serializable]
public readonly record struct OpportunitiesListRequestExpandItem : IStringEnum
{
    public static readonly OpportunitiesListRequestExpandItem Account = new(Values.Account);

    public static readonly OpportunitiesListRequestExpandItem Owner = new(Values.Owner);

    public static readonly OpportunitiesListRequestExpandItem Stage = new(Values.Stage);

    public OpportunitiesListRequestExpandItem(string value)
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
    public static OpportunitiesListRequestExpandItem FromCustom(string value)
    {
        return new OpportunitiesListRequestExpandItem(value);
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

    public static bool operator ==(OpportunitiesListRequestExpandItem value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(OpportunitiesListRequestExpandItem value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(OpportunitiesListRequestExpandItem value) => value.Value;

    public static explicit operator OpportunitiesListRequestExpandItem(string value) => new(value);

    /// <summary>
    /// Constant strings for enum values
    /// </summary>
    [Serializable]
    public static class Values
    {
        public const string Account = "account";

        public const string Owner = "owner";

        public const string Stage = "stage";
    }
}
