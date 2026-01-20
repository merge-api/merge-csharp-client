using System.Text.Json.Serialization;
using Merge.Client.Core;

namespace Merge.Client.Accounting;

[JsonConverter(typeof(StringEnumSerializer<TrackingCategoriesListRequestCategoryType>))]
[Serializable]
public readonly record struct TrackingCategoriesListRequestCategoryType : IStringEnum
{
    public static readonly TrackingCategoriesListRequestCategoryType Empty = new(Values.Empty);

    public static readonly TrackingCategoriesListRequestCategoryType Class = new(Values.Class);

    public static readonly TrackingCategoriesListRequestCategoryType Department = new(
        Values.Department
    );

    public TrackingCategoriesListRequestCategoryType(string value)
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
    public static TrackingCategoriesListRequestCategoryType FromCustom(string value)
    {
        return new TrackingCategoriesListRequestCategoryType(value);
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
        TrackingCategoriesListRequestCategoryType value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        TrackingCategoriesListRequestCategoryType value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(TrackingCategoriesListRequestCategoryType value) =>
        value.Value;

    public static explicit operator TrackingCategoriesListRequestCategoryType(string value) =>
        new(value);

    /// <summary>
    /// Constant strings for enum values
    /// </summary>
    [Serializable]
    public static class Values
    {
        public const string Empty = "";

        public const string Class = "CLASS";

        public const string Department = "DEPARTMENT";
    }
}
