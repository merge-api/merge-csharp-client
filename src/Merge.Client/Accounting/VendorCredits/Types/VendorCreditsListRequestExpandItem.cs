using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Merge.Client.Core;

namespace Merge.Client.Accounting;

[JsonConverter(typeof(EnumSerializer<VendorCreditsListRequestExpandItem>))]
public enum VendorCreditsListRequestExpandItem
{
    [EnumMember(Value = "accounting_period")]
    AccountingPeriod,

    [EnumMember(Value = "company")]
    Company,

    [EnumMember(Value = "lines")]
    Lines,

    [EnumMember(Value = "tracking_categories")]
    TrackingCategories,

    [EnumMember(Value = "vendor")]
    Vendor,
}
