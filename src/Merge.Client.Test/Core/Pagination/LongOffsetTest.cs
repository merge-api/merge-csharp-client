using Merge.Client.Core;
using NUnit.Framework;
using SystemTask = global::System.Threading.Tasks.Task;

namespace Merge.Client.Test.Core.Pagination;

[TestFixture(Category = "Pagination")]
public class LongOffsetTest
{
    [Test]
    public async SystemTask OffsetPagerShouldWorkWithLongPage()
    {
        var responses = new List<Response>
        {
            new() { Data = new Data { Items = ["item1", "item2"] } },
            new() { Data = new Data { Items = ["item1"] } },
            new() { Data = new Data { Items = [] } },
        }.GetEnumerator();
        Pager<object> pager = await OffsetPager<
            Request,
            object?,
            Response,
            long,
            object?,
            object
        >.CreateInstanceAsync(
            new Request { Pagination = new Pagination { Page = 1 } },
            null,
            (_, _, _) =>
            {
                responses.MoveNext();
                return SystemTask.FromResult(responses.Current);
            },
            request => request?.Pagination?.Page ?? 0,
            (request, offset) =>
            {
                request.Pagination ??= new();
                request.Pagination.Page = offset;
            },
            null,
            response => response?.Data?.Items?.ToList(),
            null
        );

        var pageCounter = 0;
        var itemCounter = 0;
        await foreach (var page in pager.AsPagesAsync())
        {
            pageCounter++;
            itemCounter += page.Items.Count;
        }

        Assert.Multiple(() =>
        {
            Assert.That(pageCounter, Is.EqualTo(3));
            Assert.That(itemCounter, Is.EqualTo(3));
        });
    }

    private class Request
    {
        public Pagination? Pagination { get; set; }
    }

    private class Pagination
    {
        public long Page { get; set; }
    }

    private class Response
    {
        public Data? Data { get; set; }
    }

    private class Data
    {
        public IEnumerable<string>? Items { get; set; }
    }
}
