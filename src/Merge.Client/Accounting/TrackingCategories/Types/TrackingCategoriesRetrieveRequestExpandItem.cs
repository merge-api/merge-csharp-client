using System.Text.Json.Serialization;
using Merge.Client.Core;

namespace Merge.Client.Accounting;

[JsonConverter(typeof(StringEnumSerializer<TrackingCategoriesRetrieveRequestExpandItem>))]
[Serializable]
public readonly record struct TrackingCategoriesRetrieveRequestExpandItem : IStringEnum
{
    public static readonly TrackingCategoriesRetrieveRequestExpandItem Company = new(
        Values.Company
    );

    public TrackingCategoriesRetrieveRequestExpandItem(string value)
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
    public static TrackingCategoriesRetrieveRequestExpandItem FromCustom(string value)
    {
        return new TrackingCategoriesRetrieveRequestExpandItem(value);
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
        TrackingCategoriesRetrieveRequestExpandItem value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        TrackingCategoriesRetrieveRequestExpandItem value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(TrackingCategoriesRetrieveRequestExpandItem value) =>
        value.Value;

    public static explicit operator TrackingCategoriesRetrieveRequestExpandItem(string value) =>
        new(value);

    /// <summary>
    /// Constant strings for enum values
    /// </summary>
    [Serializable]
    public static class Values
    {
        public const string Company = "company";
    }
}
