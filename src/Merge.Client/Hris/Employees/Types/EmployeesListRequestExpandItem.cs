using System.Text.Json.Serialization;
using Merge.Client.Core;

namespace Merge.Client.Hris;

[JsonConverter(typeof(StringEnumSerializer<EmployeesListRequestExpandItem>))]
public readonly record struct EmployeesListRequestExpandItem : IStringEnum
{
    public static readonly EmployeesListRequestExpandItem Company = new(Values.Company);

    public static readonly EmployeesListRequestExpandItem Employments = new(Values.Employments);

    public static readonly EmployeesListRequestExpandItem Groups = new(Values.Groups);

    public static readonly EmployeesListRequestExpandItem HomeLocation = new(Values.HomeLocation);

    public static readonly EmployeesListRequestExpandItem Manager = new(Values.Manager);

    public static readonly EmployeesListRequestExpandItem PayGroup = new(Values.PayGroup);

    public static readonly EmployeesListRequestExpandItem Team = new(Values.Team);

    public static readonly EmployeesListRequestExpandItem WorkLocation = new(Values.WorkLocation);

    public EmployeesListRequestExpandItem(string value)
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
    public static EmployeesListRequestExpandItem FromCustom(string value)
    {
        return new EmployeesListRequestExpandItem(value);
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

    public static bool operator ==(EmployeesListRequestExpandItem value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(EmployeesListRequestExpandItem value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(EmployeesListRequestExpandItem value) => value.Value;

    public static explicit operator EmployeesListRequestExpandItem(string value) => new(value);

    /// <summary>
    /// Constant strings for enum values
    /// </summary>
    public static class Values
    {
        public const string Company = "company";

        public const string Employments = "employments";

        public const string Groups = "groups";

        public const string HomeLocation = "home_location";

        public const string Manager = "manager";

        public const string PayGroup = "pay_group";

        public const string Team = "team";

        public const string WorkLocation = "work_location";
    }
}
