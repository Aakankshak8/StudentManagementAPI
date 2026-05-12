using StudentManagementAPI.Models;

namespace StudentManagementAPI.Repositories
{
    public interface IStudentRepository
    {
        Task<List<Students>> GetAllStudents();

        Task<Students> GetStudentsById(int id);
        Task<Students>AddStudent(Students student);
        Task<Students> UpdateStudents(Students student);
        Task<bool> DeleteStudents(int id);
        Task<Students> UpdateStudent(Students student);
        Task<bool> DeleteStudent(int id);
    }
}
