using System.Text.Json.Serialization;
using Merge.Client.Core;

namespace Merge.Client.Crm;

[JsonConverter(
    typeof(StringEnumSerializer<CustomObjectClassesAssociationTypesListRequestExpandItem>)
)]
[Serializable]
public readonly record struct CustomObjectClassesAssociationTypesListRequestExpandItem : IStringEnum
{
    public static readonly CustomObjectClassesAssociationTypesListRequestExpandItem TargetObjectClasses =
        new(Values.TargetObjectClasses);

    public CustomObjectClassesAssociationTypesListRequestExpandItem(string value)
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
    public static CustomObjectClassesAssociationTypesListRequestExpandItem FromCustom(string value)
    {
        return new CustomObjectClassesAssociationTypesListRequestExpandItem(value);
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
        CustomObjectClassesAssociationTypesListRequestExpandItem value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        CustomObjectClassesAssociationTypesListRequestExpandItem value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        CustomObjectClassesAssociationTypesListRequestExpandItem value
    ) => value.Value;

    public static explicit operator CustomObjectClassesAssociationTypesListRequestExpandItem(
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
