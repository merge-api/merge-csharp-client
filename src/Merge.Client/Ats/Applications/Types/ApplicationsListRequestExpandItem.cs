using System.Text.Json.Serialization;
using Merge.Client.Core;

namespace Merge.Client.Ats;

[JsonConverter(typeof(StringEnumSerializer<ApplicationsListRequestExpandItem>))]
[Serializable]
public readonly record struct ApplicationsListRequestExpandItem : IStringEnum
{
    public static readonly ApplicationsListRequestExpandItem Candidate = new(Values.Candidate);

    public static readonly ApplicationsListRequestExpandItem CreditedTo = new(Values.CreditedTo);

    public static readonly ApplicationsListRequestExpandItem CurrentStage = new(
        Values.CurrentStage
    );

    public static readonly ApplicationsListRequestExpandItem Job = new(Values.Job);

    public static readonly ApplicationsListRequestExpandItem Offers = new(Values.Offers);

    public static readonly ApplicationsListRequestExpandItem RejectReason = new(
        Values.RejectReason
    );

    public static readonly ApplicationsListRequestExpandItem ScreeningQuestionAnswers = new(
        Values.ScreeningQuestionAnswers
    );

    public static readonly ApplicationsListRequestExpandItem ScreeningQuestionAnswersQuestion = new(
        Values.ScreeningQuestionAnswersQuestion
    );

    public ApplicationsListRequestExpandItem(string value)
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
    public static ApplicationsListRequestExpandItem FromCustom(string value)
    {
        return new ApplicationsListRequestExpandItem(value);
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

    public static bool operator ==(ApplicationsListRequestExpandItem value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(ApplicationsListRequestExpandItem value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(ApplicationsListRequestExpandItem value) => value.Value;

    public static explicit operator ApplicationsListRequestExpandItem(string value) => new(value);

    /// <summary>
    /// Constant strings for enum values
    /// </summary>
    [Serializable]
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
