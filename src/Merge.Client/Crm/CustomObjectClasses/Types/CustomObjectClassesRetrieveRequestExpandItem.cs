using System.Text.Json.Serialization;
using Merge.Client.Core;

namespace Merge.Client.Crm;

[JsonConverter(typeof(StringEnumSerializer<CustomObjectClassesRetrieveRequestExpandItem>))]
[Serializable]
public readonly record struct CustomObjectClassesRetrieveRequestExpandItem : IStringEnum
{
    public static readonly CustomObjectClassesRetrieveRequestExpandItem Fields = new(Values.Fields);

    public CustomObjectClassesRetrieveRequestExpandItem(string value)
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
    public static CustomObjectClassesRetrieveRequestExpandItem FromCustom(string value)
    {
        return new CustomObjectClassesRetrieveRequestExpandItem(value);
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
        CustomObjectClassesRetrieveRequestExpandItem value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        CustomObjectClassesRetrieveRequestExpandItem value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(CustomObjectClassesRetrieveRequestExpandItem value) =>
        value.Value;

    public static explicit operator CustomObjectClassesRetrieveRequestExpandItem(string value) =>
        new(value);

    /// <summary>
    /// Constant strings for enum values
    /// </summary>
    [Serializable]
    public static class Values
    {
        public const string Fields = "fields";
    }
}
