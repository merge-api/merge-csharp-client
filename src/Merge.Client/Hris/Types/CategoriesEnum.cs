using System.Text.Json.Serialization;
using Merge.Client.Core;

namespace Merge.Client.Hris;

[JsonConverter(typeof(StringEnumSerializer<CategoriesEnum>))]
public readonly record struct CategoriesEnum : IStringEnum
{
    public static readonly CategoriesEnum Hris = new(Values.Hris);

    public static readonly CategoriesEnum Ats = new(Values.Ats);

    public static readonly CategoriesEnum Accounting = new(Values.Accounting);

    public static readonly CategoriesEnum Ticketing = new(Values.Ticketing);

    public static readonly CategoriesEnum Crm = new(Values.Crm);

    public static readonly CategoriesEnum Mktg = new(Values.Mktg);

    public static readonly CategoriesEnum Filestorage = new(Values.Filestorage);

    public CategoriesEnum(string value)
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
    public static CategoriesEnum FromCustom(string value)
    {
        return new CategoriesEnum(value);
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

    public static bool operator ==(CategoriesEnum value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(CategoriesEnum value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(CategoriesEnum value) => value.Value;

    public static explicit operator CategoriesEnum(string value) => new(value);

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
