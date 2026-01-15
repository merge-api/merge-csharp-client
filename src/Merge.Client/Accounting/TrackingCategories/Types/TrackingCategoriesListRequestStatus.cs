using System.Text.Json.Serialization;
using Merge.Client.Core;

namespace Merge.Client.Accounting;

[JsonConverter(typeof(StringEnumSerializer<TrackingCategoriesListRequestStatus>))]
[Serializable]
public readonly record struct TrackingCategoriesListRequestStatus : IStringEnum
{
    public static readonly TrackingCategoriesListRequestStatus Empty = new(Values.Empty);

    public static readonly TrackingCategoriesListRequestStatus Active = new(Values.Active);

    public static readonly TrackingCategoriesListRequestStatus Archived = new(Values.Archived);

    public TrackingCategoriesListRequestStatus(string value)
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
    public static TrackingCategoriesListRequestStatus FromCustom(string value)
    {
        return new TrackingCategoriesListRequestStatus(value);
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

    public static bool operator ==(TrackingCategoriesListRequestStatus value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(TrackingCategoriesListRequestStatus value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(TrackingCategoriesListRequestStatus value) =>
        value.Value;

    public static explicit operator TrackingCategoriesListRequestStatus(string value) => new(value);

    /// <summary>
    /// Constant strings for enum values
    /// </summary>
    [Serializable]
    public static class Values
    {
        public const string Empty = "";

        public const string Active = "ACTIVE";

        public const string Archived = "ARCHIVED";
    }
}
