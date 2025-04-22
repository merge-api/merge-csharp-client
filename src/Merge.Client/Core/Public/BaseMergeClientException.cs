using System;

namespace Merge.Client.Core;

/// <summary>
/// Base exception class for all exceptions thrown by the SDK.
/// </summary>
public class BaseMergeClientException(string message, Exception? innerException = null)
    : Exception(message, innerException);
