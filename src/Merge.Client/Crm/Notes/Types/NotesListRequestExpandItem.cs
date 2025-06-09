using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Merge.Client.Core;

namespace Merge.Client.Crm;

[JsonConverter(typeof(EnumSerializer<NotesListRequestExpandItem>))]
public enum NotesListRequestExpandItem
{
    [EnumMember(Value = "account")]
    Account,

    [EnumMember(Value = "contact")]
    Contact,

    [EnumMember(Value = "opportunity")]
    Opportunity,

    [EnumMember(Value = "owner")]
    Owner,
}
