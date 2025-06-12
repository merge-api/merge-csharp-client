using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Merge.Client.Core;

namespace Merge.Client.Accounting;

[JsonConverter(typeof(EnumSerializer<ProjectsRetrieveRequestExpandItem>))]
public enum ProjectsRetrieveRequestExpandItem
{
    [EnumMember(Value = "company")]
    Company,

    [EnumMember(Value = "contact")]
    Contact,
}
