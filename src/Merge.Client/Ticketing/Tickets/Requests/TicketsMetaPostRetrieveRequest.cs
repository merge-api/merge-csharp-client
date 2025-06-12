using System.Text.Json.Serialization;
using Merge.Client.Core;

namespace Merge.Client.Ticketing;

public record TicketsMetaPostRetrieveRequest
{
    /// <summary>
    /// If provided, will only return tickets for this collection.
    /// </summary>
    [JsonIgnore]
    public string? CollectionId { get; set; }

    /// <summary>
    /// If provided, will only return tickets for this ticket type.
    /// </summary>
    [JsonIgnore]
    public string? TicketType { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
