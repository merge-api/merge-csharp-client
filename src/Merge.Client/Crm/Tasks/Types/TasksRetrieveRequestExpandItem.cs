using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Merge.Client.Core;

namespace Merge.Client.Crm;

[JsonConverter(typeof(EnumSerializer<TasksRetrieveRequestExpandItem>))]
public enum TasksRetrieveRequestExpandItem
{
    [EnumMember(Value = "account")]
    Account,

    [EnumMember(Value = "opportunity")]
    Opportunity,

    [EnumMember(Value = "owner")]
    Owner,
}
