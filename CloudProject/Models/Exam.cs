using System.ComponentModel.DataAnnotations;

namespace CloudProject.Models;

public class Exam
{
    [Key] public int ExamId { get; set; }

    [Required] [StringLength(100)] public string? CourseName { get; set; }

    public DateTime? ExamDate { get; set; }

    [StringLength(100)] public string? Location { get; set; }

    [Range(30, 300)] public int? DurationMinutes { get; set; }

    [StringLength(100)] public string? Instructor { get; set; }
}