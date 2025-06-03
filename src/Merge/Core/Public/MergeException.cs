using System;

namespace Merge;

/// <summary>
/// Base exception class for all exceptions thrown by the SDK.
/// </summary>
public class MergeException(string message, Exception? innerException = null)
    : Exception(message, innerException);
