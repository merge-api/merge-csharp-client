using System.Text.Json.Serialization;
using Merge.Client.Core;

namespace Merge.Client.FileStorage;

[JsonConverter(typeof(StringEnumSerializer<CategoryEnum>))]
public readonly record struct CategoryEnum : IStringEnum
{
    public static readonly CategoryEnum Hris = new(Values.Hris);

    public static readonly CategoryEnum Ats = new(Values.Ats);

    public static readonly CategoryEnum Accounting = new(Values.Accounting);

    public static readonly CategoryEnum Ticketing = new(Values.Ticketing);

    public static readonly CategoryEnum Crm = new(Values.Crm);

    public static readonly CategoryEnum Mktg = new(Values.Mktg);

    public static readonly CategoryEnum Filestorage = new(Values.Filestorage);

    public CategoryEnum(string value)
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
    public static CategoryEnum FromCustom(string value)
    {
        return new CategoryEnum(value);
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

    public static bool operator ==(CategoryEnum value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(CategoryEnum value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(CategoryEnum value) => value.Value;

    public static explicit operator CategoryEnum(string value) => new(value);

    /// <summary>
    /// Constant strings for enum values
    /// </summary>
    public static class Values
    {
        public const string Hris = "hris";

        public const string Ats = "ats";

        public const string Accounting = "accounting";

        public const string Ticketing = "ticketing";

        public const string Crm = "crm";

        public const string Mktg = "mktg";

        public const string Filestorage = "filestorage";
    }
}
