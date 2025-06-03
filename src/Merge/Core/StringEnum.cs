using System.Text.Json.Serialization;

namespace Merge.Core;

public interface IStringEnum : IEquatable<string>
{
    public string Value { get; }
}
