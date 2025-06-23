using System.Text.Json.Serialization;

namespace Merge.Client.Core;

public interface IStringEnum : IEquatable<string>
{
    public string Value { get; }
}
