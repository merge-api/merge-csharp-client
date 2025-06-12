using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Merge.Client.Core;

namespace Merge.Client.Accounting;

[JsonConverter(typeof(EnumSerializer<ProjectsListRequestExpandItem>))]
public enum ProjectsListRequestExpandItem
{
    [EnumMember(Value = "company")]
    Company,

    [EnumMember(Value = "contact")]
    Contact,
}
