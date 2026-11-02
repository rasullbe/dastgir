using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Dastgir.Api.Entities.Enums;

namespace Dastgir.Api.Entities;

public class Sessions
{
    public long SessionId { get; set; }
    [Required] public long UserId { get; set; }
    [ForeignKey(nameof(UserId))] public Users User { get; set; }
    public DateTime StartDate { get; set; } = DateTime.UtcNow;
    public DateTime? EndDate { get; set; }
    public TopicEnum Topic { get; set; }
    public string Status { get; set; } = "Active";
    public string Summary { get; set; }
    public int MessageCount { get; set; } = 0;
}
