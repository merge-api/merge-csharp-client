using System.Text.Json.Serialization;
using Merge.Client.Core;

namespace Merge.Client.Hris;

[JsonConverter(typeof(StringEnumSerializer<EmployeesRetrieveRequestExpandItem>))]
public readonly record struct EmployeesRetrieveRequestExpandItem : IStringEnum
{
    public static readonly EmployeesRetrieveRequestExpandItem Company = new(Values.Company);

    public static readonly EmployeesRetrieveRequestExpandItem Employments = new(Values.Employments);

    public static readonly EmployeesRetrieveRequestExpandItem Groups = new(Values.Groups);

    public static readonly EmployeesRetrieveRequestExpandItem HomeLocation = new(
        Values.HomeLocation
    );

    public static readonly EmployeesRetrieveRequestExpandItem Manager = new(Values.Manager);

    public static readonly EmployeesRetrieveRequestExpandItem PayGroup = new(Values.PayGroup);

    public static readonly EmployeesRetrieveRequestExpandItem Team = new(Values.Team);

    public static readonly EmployeesRetrieveRequestExpandItem WorkLocation = new(
        Values.WorkLocation
    );

    public EmployeesRetrieveRequestExpandItem(string value)
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
    public static EmployeesRetrieveRequestExpandItem FromCustom(string value)
    {
        return new EmployeesRetrieveRequestExpandItem(value);
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

    public static bool operator ==(EmployeesRetrieveRequestExpandItem value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(EmployeesRetrieveRequestExpandItem value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(EmployeesRetrieveRequestExpandItem value) => value.Value;

    public static explicit operator EmployeesRetrieveRequestExpandItem(string value) => new(value);

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
