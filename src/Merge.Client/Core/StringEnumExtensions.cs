namespace Merge.Client.Core;

internal static class StringEnumExtensions
{
    public static string Stringify(this IStringEnum stringEnum) => stringEnum.Value;
}
