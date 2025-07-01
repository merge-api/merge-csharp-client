using System.Text.Json.Serialization;
using Merge.Client.Core;

namespace Merge.Client.Crm;

[JsonConverter(typeof(StringEnumSerializer<EngagementsRetrieveRequestExpandItem>))]
[Serializable]
public readonly record struct EngagementsRetrieveRequestExpandItem : IStringEnum
{
    public static readonly EngagementsRetrieveRequestExpandItem Account = new(Values.Account);

    public static readonly EngagementsRetrieveRequestExpandItem Contacts = new(Values.Contacts);

    public static readonly EngagementsRetrieveRequestExpandItem EngagementType = new(
        Values.EngagementType
    );

    public static readonly EngagementsRetrieveRequestExpandItem Owner = new(Values.Owner);

    public EngagementsRetrieveRequestExpandItem(string value)
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
    public static EngagementsRetrieveRequestExpandItem FromCustom(string value)
    {
        return new EngagementsRetrieveRequestExpandItem(value);
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

    public static bool operator ==(EngagementsRetrieveRequestExpandItem value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(EngagementsRetrieveRequestExpandItem value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(EngagementsRetrieveRequestExpandItem value) =>
        value.Value;

    public static explicit operator EngagementsRetrieveRequestExpandItem(string value) =>
        new(value);

    /// <summary>
    /// Constant strings for enum values
    /// </summary>
    [Serializable]
    public static class Values
    {
        public const string Account = "account";

        public const string Contacts = "contacts";

        public const string EngagementType = "engagement_type";

        public const string Owner = "owner";
    }
}
