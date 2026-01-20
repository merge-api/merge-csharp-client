using System.Text.Json.Serialization;
using Merge.Client.Core;

namespace Merge.Client.Crm;

[JsonConverter(
    typeof(StringEnumSerializer<CustomObjectClassesAssociationTypesRetrieveRequestExpandItem>)
)]
[Serializable]
public readonly record struct CustomObjectClassesAssociationTypesRetrieveRequestExpandItem
    : IStringEnum
{
    public static readonly CustomObjectClassesAssociationTypesRetrieveRequestExpandItem TargetObjectClasses =
        new(Values.TargetObjectClasses);

    public CustomObjectClassesAssociationTypesRetrieveRequestExpandItem(string value)
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
    public static CustomObjectClassesAssociationTypesRetrieveRequestExpandItem FromCustom(
        string value
    )
    {
        return new CustomObjectClassesAssociationTypesRetrieveRequestExpandItem(value);
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
        CustomObjectClassesAssociationTypesRetrieveRequestExpandItem value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        CustomObjectClassesAssociationTypesRetrieveRequestExpandItem value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        CustomObjectClassesAssociationTypesRetrieveRequestExpandItem value
    ) => value.Value;

    public static explicit operator CustomObjectClassesAssociationTypesRetrieveRequestExpandItem(
        string value
    ) => new(value);

    /// <summary>
    /// Constant strings for enum values
    /// </summary>
    [Serializable]
    public static class Values
    {
        public const string TargetObjectClasses = "target_object_classes";
    }
}
