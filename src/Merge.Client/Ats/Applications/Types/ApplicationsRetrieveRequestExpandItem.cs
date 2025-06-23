using System.Text.Json.Serialization;
using Merge.Client.Core;

namespace Merge.Client.Ats;

[JsonConverter(typeof(StringEnumSerializer<ApplicationsRetrieveRequestExpandItem>))]
public readonly record struct ApplicationsRetrieveRequestExpandItem : IStringEnum
{
    public static readonly ApplicationsRetrieveRequestExpandItem Candidate = new(Values.Candidate);

    public static readonly ApplicationsRetrieveRequestExpandItem CreditedTo = new(
        Values.CreditedTo
    );

    public static readonly ApplicationsRetrieveRequestExpandItem CurrentStage = new(
        Values.CurrentStage
    );

    public static readonly ApplicationsRetrieveRequestExpandItem Job = new(Values.Job);

    public static readonly ApplicationsRetrieveRequestExpandItem Offers = new(Values.Offers);

    public static readonly ApplicationsRetrieveRequestExpandItem RejectReason = new(
        Values.RejectReason
    );

    public static readonly ApplicationsRetrieveRequestExpandItem ScreeningQuestionAnswers = new(
        Values.ScreeningQuestionAnswers
    );

    public static readonly ApplicationsRetrieveRequestExpandItem ScreeningQuestionAnswersQuestion =
        new(Values.ScreeningQuestionAnswersQuestion);

    public ApplicationsRetrieveRequestExpandItem(string value)
    {
        Value = value;
    }

    /// <summary>
    /// The string value of the enum.
    /// </summary>
    public string Value { get; }

    /// <summary>
    /// Create a string enum with the given value.
    /// </summary>
    public static ApplicationsRetrieveRequestExpandItem FromCustom(string value)
    {
        return new ApplicationsRetrieveRequestExpandItem(value);
    }

    public bool Equals(string? other)
    {
        return Value.Equals(other);
    }

    /// <summary>
    /// Returns the string value of the enum.
    /// </summary>
    public override string ToString()
    {
        return Value;
    }

    public static bool operator ==(ApplicationsRetrieveRequestExpandItem value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(ApplicationsRetrieveRequestExpandItem value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(ApplicationsRetrieveRequestExpandItem value) =>
        value.Value;

    public static explicit operator ApplicationsRetrieveRequestExpandItem(string value) =>
        new(value);

    /// <summary>
    /// Constant strings for enum values
    /// </summary>
    public static class Values
    {
        public const string Candidate = "candidate";

        public const string CreditedTo = "credited_to";

        public const string CurrentStage = "current_stage";

        public const string Job = "job";

        public const string Offers = "offers";

        public const string RejectReason = "reject_reason";

        public const string ScreeningQuestionAnswers = "screening_question_answers";

        public const string ScreeningQuestionAnswersQuestion =
            "screening_question_answers.question";
    }
}
