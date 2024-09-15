using CloudProject.Models;

namespace CloudProject.Services;

public interface IExamService
{
    Task<IEnumerable<Exam>> GetAllExamsAsync();
    Task<Exam?> GetExamByIdAsync(int examId);
    Task<Exam?> CreateExamAsync(Exam exam);
    Task<Exam?> UpdateExamAsync(Exam exam);
    Task<bool> DeleteExamAsync(int examId);
}