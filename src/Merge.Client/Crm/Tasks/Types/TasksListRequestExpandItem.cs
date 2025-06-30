using System.Text.Json.Serialization;
using Merge.Client.Core;

namespace Merge.Client.Crm;

[JsonConverter(typeof(StringEnumSerializer<TasksListRequestExpandItem>))]
[Serializable]
public readonly record struct TasksListRequestExpandItem : IStringEnum
{
    public static readonly TasksListRequestExpandItem Account = new(Values.Account);

    public static readonly TasksListRequestExpandItem Opportunity = new(Values.Opportunity);

    public static readonly TasksListRequestExpandItem Owner = new(Values.Owner);

    public TasksListRequestExpandItem(string value)
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
    public static TasksListRequestExpandItem FromCustom(string value)
    {
        return new TasksListRequestExpandItem(value);
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

    public static bool operator ==(TasksListRequestExpandItem value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(TasksListRequestExpandItem value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(TasksListRequestExpandItem value) => value.Value;

    public static explicit operator TasksListRequestExpandItem(string value) => new(value);

    /// <summary>
    /// Constant strings for enum values
    /// </summary>
    [Serializable]
    public static class Values
    {
        public const string Account = "account";

        public const string Opportunity = "opportunity";

        public const string Owner = "owner";
    }
}
