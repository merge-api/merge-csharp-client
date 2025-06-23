using System.Text.Json.Serialization;
using Merge.Client.Core;

namespace Merge.Client.Crm;

[JsonConverter(typeof(StringEnumSerializer<EngagementsListRequestExpandItem>))]
public readonly record struct EngagementsListRequestExpandItem : IStringEnum
{
    public static readonly EngagementsListRequestExpandItem Account = new(Values.Account);

    public static readonly EngagementsListRequestExpandItem Contacts = new(Values.Contacts);

    public static readonly EngagementsListRequestExpandItem EngagementType = new(
        Values.EngagementType
    );

    public static readonly EngagementsListRequestExpandItem Owner = new(Values.Owner);

    public EngagementsListRequestExpandItem(string value)
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
    public static EngagementsListRequestExpandItem FromCustom(string value)
    {
        return new EngagementsListRequestExpandItem(value);
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

    public static bool operator ==(EngagementsListRequestExpandItem value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(EngagementsListRequestExpandItem value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(EngagementsListRequestExpandItem value) => value.Value;

    public static explicit operator EngagementsListRequestExpandItem(string value) => new(value);

    /// <summary>
    /// Constant strings for enum values
    /// </summary>
    public static class Values
    {
        public const string Account = "account";

        public const string Contacts = "contacts";

        public const string EngagementType = "engagement_type";

        public const string Owner = "owner";
    }
}
