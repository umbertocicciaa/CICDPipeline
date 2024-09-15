using CloudProject.Data;
using CloudProject.Models;
using Microsoft.EntityFrameworkCore;


namespace CloudProject.Services
{
    public class ExamService(ApplicationDbContext context) : IExamService
    {
        public async Task<IEnumerable<Exam>> GetAllExamsAsync()
        {
            return await context.Exams.ToListAsync();
        }

        public async Task<Exam?> GetExamByIdAsync(int examId)
        {
            return await context.Exams.FindAsync(examId);
        }

        public async Task<Exam?> CreateExamAsync(Exam exam)
        {
            context.Exams.Add(exam);
            await context.SaveChangesAsync();
            return exam;
        }

        public async Task<Exam?> UpdateExamAsync(Exam exam)
        {
            context.Entry(exam).State = EntityState.Modified;
            await context.SaveChangesAsync();
            return exam;
        }

        public async Task<bool> DeleteExamAsync(int examId)
        {
            var exam = await context.Exams.FindAsync(examId);
            if (exam == null) return false;

            context.Exams.Remove(exam);
            await context.SaveChangesAsync();
            return true;
        }
    }
}