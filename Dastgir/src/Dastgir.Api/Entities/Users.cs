using System.ComponentModel.DataAnnotations;
using Dastgir.Api.Entities.Enums;

namespace Dastgir.Api.Entities;

public class Users
{
    public long UserId { get; set; }
    [Required] public string PhoneNumber { get; set; }
    [Required] public string FirstName { get; set; }
    public string LastName { get; set; }
    [Required] public string UserEmail { get; set; }
    public int UserAge { get; set; }
    public DateTime RegistrationDate { get; set; } = DateTime.UtcNow;
    public DateTime LastActivityDate { get; set; } = DateTime.UtcNow;
    public bool IsActive { get; set; } = true;
    public string Gender { get; set; }
    public string MentalHealthBackground { get; set; }
    public int ConsultationCount { get; set; } = 0;
    public string PreferredLanguage { get; set; } = "ru";
    public string EmergencyContact { get; set; }
    public string EmergencyContactPhone { get; set; }
    public MoodEnum CurrentMood { get; set; } = MoodEnum.Neutral;
    public DateTime LastMoodUpdate { get; set; } = DateTime.UtcNow;
}
