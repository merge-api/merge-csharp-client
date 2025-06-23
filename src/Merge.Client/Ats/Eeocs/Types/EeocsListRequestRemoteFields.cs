using System.Text.Json.Serialization;
using Merge.Client.Core;

namespace Merge.Client.Ats;

[JsonConverter(typeof(StringEnumSerializer<EeocsListRequestRemoteFields>))]
public readonly record struct EeocsListRequestRemoteFields : IStringEnum
{
    public static readonly EeocsListRequestRemoteFields DisabilityStatus = new(
        Values.DisabilityStatus
    );

    public static readonly EeocsListRequestRemoteFields DisabilityStatusGender = new(
        Values.DisabilityStatusGender
    );

    public static readonly EeocsListRequestRemoteFields DisabilityStatusGenderRace = new(
        Values.DisabilityStatusGenderRace
    );

    public static readonly EeocsListRequestRemoteFields DisabilityStatusGenderRaceVeteranStatus =
        new(Values.DisabilityStatusGenderRaceVeteranStatus);

    public static readonly EeocsListRequestRemoteFields DisabilityStatusGenderVeteranStatus = new(
        Values.DisabilityStatusGenderVeteranStatus
    );

    public static readonly EeocsListRequestRemoteFields DisabilityStatusRace = new(
        Values.DisabilityStatusRace
    );

    public static readonly EeocsListRequestRemoteFields DisabilityStatusRaceVeteranStatus = new(
        Values.DisabilityStatusRaceVeteranStatus
    );

    public static readonly EeocsListRequestRemoteFields DisabilityStatusVeteranStatus = new(
        Values.DisabilityStatusVeteranStatus
    );

    public static readonly EeocsListRequestRemoteFields Gender = new(Values.Gender);

    public static readonly EeocsListRequestRemoteFields GenderRace = new(Values.GenderRace);

    public static readonly EeocsListRequestRemoteFields GenderRaceVeteranStatus = new(
        Values.GenderRaceVeteranStatus
    );

    public static readonly EeocsListRequestRemoteFields GenderVeteranStatus = new(
        Values.GenderVeteranStatus
    );

    public static readonly EeocsListRequestRemoteFields Race = new(Values.Race);

    public static readonly EeocsListRequestRemoteFields RaceVeteranStatus = new(
        Values.RaceVeteranStatus
    );

    public static readonly EeocsListRequestRemoteFields VeteranStatus = new(Values.VeteranStatus);

    public EeocsListRequestRemoteFields(string value)
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
    public static EeocsListRequestRemoteFields FromCustom(string value)
    {
        return new EeocsListRequestRemoteFields(value);
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

    public static bool operator ==(EeocsListRequestRemoteFields value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(EeocsListRequestRemoteFields value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(EeocsListRequestRemoteFields value) => value.Value;

    public static explicit operator EeocsListRequestRemoteFields(string value) => new(value);

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
