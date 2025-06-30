using System.Text.Json.Serialization;
using Merge.Client.Core;

namespace Merge.Client.Ats;

[JsonConverter(typeof(StringEnumSerializer<EeocsListRequestShowEnumOrigins>))]
[Serializable]
public readonly record struct EeocsListRequestShowEnumOrigins : IStringEnum
{
    public static readonly EeocsListRequestShowEnumOrigins DisabilityStatus = new(
        Values.DisabilityStatus
    );

    public static readonly EeocsListRequestShowEnumOrigins DisabilityStatusGender = new(
        Values.DisabilityStatusGender
    );

    public static readonly EeocsListRequestShowEnumOrigins DisabilityStatusGenderRace = new(
        Values.DisabilityStatusGenderRace
    );

    public static readonly EeocsListRequestShowEnumOrigins DisabilityStatusGenderRaceVeteranStatus =
        new(Values.DisabilityStatusGenderRaceVeteranStatus);

    public static readonly EeocsListRequestShowEnumOrigins DisabilityStatusGenderVeteranStatus =
        new(Values.DisabilityStatusGenderVeteranStatus);

    public static readonly EeocsListRequestShowEnumOrigins DisabilityStatusRace = new(
        Values.DisabilityStatusRace
    );

    public static readonly EeocsListRequestShowEnumOrigins DisabilityStatusRaceVeteranStatus = new(
        Values.DisabilityStatusRaceVeteranStatus
    );

    public static readonly EeocsListRequestShowEnumOrigins DisabilityStatusVeteranStatus = new(
        Values.DisabilityStatusVeteranStatus
    );

    public static readonly EeocsListRequestShowEnumOrigins Gender = new(Values.Gender);

    public static readonly EeocsListRequestShowEnumOrigins GenderRace = new(Values.GenderRace);

    public static readonly EeocsListRequestShowEnumOrigins GenderRaceVeteranStatus = new(
        Values.GenderRaceVeteranStatus
    );

    public static readonly EeocsListRequestShowEnumOrigins GenderVeteranStatus = new(
        Values.GenderVeteranStatus
    );

    public static readonly EeocsListRequestShowEnumOrigins Race = new(Values.Race);

    public static readonly EeocsListRequestShowEnumOrigins RaceVeteranStatus = new(
        Values.RaceVeteranStatus
    );

    public static readonly EeocsListRequestShowEnumOrigins VeteranStatus = new(
        Values.VeteranStatus
    );

    public EeocsListRequestShowEnumOrigins(string value)
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
    public static EeocsListRequestShowEnumOrigins FromCustom(string value)
    {
        return new EeocsListRequestShowEnumOrigins(value);
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

    public static bool operator ==(EeocsListRequestShowEnumOrigins value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(EeocsListRequestShowEnumOrigins value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(EeocsListRequestShowEnumOrigins value) => value.Value;

    public static explicit operator EeocsListRequestShowEnumOrigins(string value) => new(value);

    /// <summary>
    /// Constant strings for enum values
    /// </summary>
    [Serializable]
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
