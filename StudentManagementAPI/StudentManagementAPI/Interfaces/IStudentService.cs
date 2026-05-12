using StudentManagementAPI.Models;

namespace StudentManagementAPI.Interfaces
{
    public interface IStudentService
    {
        Task<List<Students>> GetAllStudents();

        Task<Students> AddStudent(Students student);

        Task<Students> UpdateStudent(Students student);

        Task<bool> DeleteStudent(int id);
    }
}