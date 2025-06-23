using System.Text.Json.Serialization;
using Merge.Client.Core;

namespace Merge.Client.Crm;

[JsonConverter(typeof(StringEnumSerializer<TasksRetrieveRequestExpandItem>))]
public readonly record struct TasksRetrieveRequestExpandItem : IStringEnum
{
    public static readonly TasksRetrieveRequestExpandItem Account = new(Values.Account);

    public static readonly TasksRetrieveRequestExpandItem Opportunity = new(Values.Opportunity);

    public static readonly TasksRetrieveRequestExpandItem Owner = new(Values.Owner);

    public TasksRetrieveRequestExpandItem(string value)
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
    public static TasksRetrieveRequestExpandItem FromCustom(string value)
    {
        return new TasksRetrieveRequestExpandItem(value);
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

    public static bool operator ==(TasksRetrieveRequestExpandItem value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(TasksRetrieveRequestExpandItem value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(TasksRetrieveRequestExpandItem value) => value.Value;

    public static explicit operator TasksRetrieveRequestExpandItem(string value) => new(value);

    /// <summary>
    /// Constant strings for enum values
    /// </summary>
    public static class Values
    {
        public const string Account = "account";

        public const string Opportunity = "opportunity";

        public const string Owner = "owner";
    }
}
