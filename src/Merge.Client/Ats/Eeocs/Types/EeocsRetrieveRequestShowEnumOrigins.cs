using System.Text.Json.Serialization;
using Merge.Client.Core;

namespace Merge.Client.Ats;

[JsonConverter(typeof(StringEnumSerializer<EeocsRetrieveRequestShowEnumOrigins>))]
public readonly record struct EeocsRetrieveRequestShowEnumOrigins : IStringEnum
{
    public static readonly EeocsRetrieveRequestShowEnumOrigins DisabilityStatus = new(
        Values.DisabilityStatus
    );

    public static readonly EeocsRetrieveRequestShowEnumOrigins DisabilityStatusGender = new(
        Values.DisabilityStatusGender
    );

    public static readonly EeocsRetrieveRequestShowEnumOrigins DisabilityStatusGenderRace = new(
        Values.DisabilityStatusGenderRace
    );

    public static readonly EeocsRetrieveRequestShowEnumOrigins DisabilityStatusGenderRaceVeteranStatus =
        new(Values.DisabilityStatusGenderRaceVeteranStatus);

    public static readonly EeocsRetrieveRequestShowEnumOrigins DisabilityStatusGenderVeteranStatus =
        new(Values.DisabilityStatusGenderVeteranStatus);

    public static readonly EeocsRetrieveRequestShowEnumOrigins DisabilityStatusRace = new(
        Values.DisabilityStatusRace
    );

    public static readonly EeocsRetrieveRequestShowEnumOrigins DisabilityStatusRaceVeteranStatus =
        new(Values.DisabilityStatusRaceVeteranStatus);

    public static readonly EeocsRetrieveRequestShowEnumOrigins DisabilityStatusVeteranStatus = new(
        Values.DisabilityStatusVeteranStatus
    );

    public static readonly EeocsRetrieveRequestShowEnumOrigins Gender = new(Values.Gender);

    public static readonly EeocsRetrieveRequestShowEnumOrigins GenderRace = new(Values.GenderRace);

    public static readonly EeocsRetrieveRequestShowEnumOrigins GenderRaceVeteranStatus = new(
        Values.GenderRaceVeteranStatus
    );

    public static readonly EeocsRetrieveRequestShowEnumOrigins GenderVeteranStatus = new(
        Values.GenderVeteranStatus
    );

    public static readonly EeocsRetrieveRequestShowEnumOrigins Race = new(Values.Race);

    public static readonly EeocsRetrieveRequestShowEnumOrigins RaceVeteranStatus = new(
        Values.RaceVeteranStatus
    );

    public static readonly EeocsRetrieveRequestShowEnumOrigins VeteranStatus = new(
        Values.VeteranStatus
    );

    public EeocsRetrieveRequestShowEnumOrigins(string value)
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
    public static EeocsRetrieveRequestShowEnumOrigins FromCustom(string value)
    {
        return new EeocsRetrieveRequestShowEnumOrigins(value);
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

    public static bool operator ==(EeocsRetrieveRequestShowEnumOrigins value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(EeocsRetrieveRequestShowEnumOrigins value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(EeocsRetrieveRequestShowEnumOrigins value) =>
        value.Value;

    public static explicit operator EeocsRetrieveRequestShowEnumOrigins(string value) => new(value);

    /// <summary>
    /// Constant strings for enum values
    /// </summary>
    public static class Values
    {
        public const string DisabilityStatus = "disability_status";

        public const string DisabilityStatusGender = "disability_status,gender";

        public const string DisabilityStatusGenderRace = "disability_status,gender,race";

        public const string DisabilityStatusGenderRaceVeteranStatus =
            "disability_status,gender,race,veteran_status";

        public const string DisabilityStatusGenderVeteranStatus =
            "disability_status,gender,veteran_status";

        public const string DisabilityStatusRace = "disability_status,race";

        public const string DisabilityStatusRaceVeteranStatus =
            "disability_status,race,veteran_status";

        public const string DisabilityStatusVeteranStatus = "disability_status,veteran_status";

        public const string Gender = "gender";

        public const string GenderRace = "gender,race";

        public const string GenderRaceVeteranStatus = "gender,race,veteran_status";

        public const string GenderVeteranStatus = "gender,veteran_status";

        public const string Race = "race";

        public const string RaceVeteranStatus = "race,veteran_status";

        public const string VeteranStatus = "veteran_status";
    }
}
