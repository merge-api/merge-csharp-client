using System.Text.Json.Serialization;
using Merge.Core;

namespace Merge.Ats.Eeocs;

[JsonConverter(typeof(StringEnumSerializer<EeocsRetrieveRequestRemoteFields>))]
public readonly record struct EeocsRetrieveRequestRemoteFields : IStringEnum
{
    public static readonly EeocsRetrieveRequestRemoteFields DisabilityStatus = new(
        Values.DisabilityStatus
    );

    public static readonly EeocsRetrieveRequestRemoteFields DisabilityStatusGender = new(
        Values.DisabilityStatusGender
    );

    public static readonly EeocsRetrieveRequestRemoteFields DisabilityStatusGenderRace = new(
        Values.DisabilityStatusGenderRace
    );

    public static readonly EeocsRetrieveRequestRemoteFields DisabilityStatusGenderRaceVeteranStatus =
        new(Values.DisabilityStatusGenderRaceVeteranStatus);

    public static readonly EeocsRetrieveRequestRemoteFields DisabilityStatusGenderVeteranStatus =
        new(Values.DisabilityStatusGenderVeteranStatus);

    public static readonly EeocsRetrieveRequestRemoteFields DisabilityStatusRace = new(
        Values.DisabilityStatusRace
    );

    public static readonly EeocsRetrieveRequestRemoteFields DisabilityStatusRaceVeteranStatus = new(
        Values.DisabilityStatusRaceVeteranStatus
    );

    public static readonly EeocsRetrieveRequestRemoteFields DisabilityStatusVeteranStatus = new(
        Values.DisabilityStatusVeteranStatus
    );

    public static readonly EeocsRetrieveRequestRemoteFields Gender = new(Values.Gender);

    public static readonly EeocsRetrieveRequestRemoteFields GenderRace = new(Values.GenderRace);

    public static readonly EeocsRetrieveRequestRemoteFields GenderRaceVeteranStatus = new(
        Values.GenderRaceVeteranStatus
    );

    public static readonly EeocsRetrieveRequestRemoteFields GenderVeteranStatus = new(
        Values.GenderVeteranStatus
    );

    public static readonly EeocsRetrieveRequestRemoteFields Race = new(Values.Race);

    public static readonly EeocsRetrieveRequestRemoteFields RaceVeteranStatus = new(
        Values.RaceVeteranStatus
    );

    public static readonly EeocsRetrieveRequestRemoteFields VeteranStatus = new(
        Values.VeteranStatus
    );

    public EeocsRetrieveRequestRemoteFields(string value)
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
    public static EeocsRetrieveRequestRemoteFields FromCustom(string value)
    {
        return new EeocsRetrieveRequestRemoteFields(value);
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

    public static bool operator ==(EeocsRetrieveRequestRemoteFields value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(EeocsRetrieveRequestRemoteFields value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(EeocsRetrieveRequestRemoteFields value) => value.Value;

    public static explicit operator EeocsRetrieveRequestRemoteFields(string value) => new(value);

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
