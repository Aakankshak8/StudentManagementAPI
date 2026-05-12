using Microsoft.EntityFrameworkCore;
using StudentManagementAPI.Data;
using StudentManagementAPI.Interfaces;
using StudentManagementAPI.Models;

namespace StudentManagementAPI.Repositories
{
    public class StudentRepository : IStudentRepository
    {
        private readonly AppDbContext _context;

        public StudentRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task<List<Students>> GetAllStudents()
        {
            return await _context.Students.ToListAsync();
        }

        public async Task<Students> AddStudent(
            Students student)
        {
            await _context.Students.AddAsync(student);

            await _context.SaveChangesAsync();

            return student;
        }

        public async Task<Students> UpdateStudent(
            Students student)
        {
            _context.Students.Update(student);

            await _context.SaveChangesAsync();

            return student;
        }

        public async Task<bool> DeleteStudent(int id)
        {
            var student =
                await _context.Students.FindAsync(id);

            if (student == null)
            {
                return false;
            }

            _context.Students.Remove(student);

            await _context.SaveChangesAsync();

            return true;
        }

        public Task<Students> GetStudentsById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Students> UpdateStudents(Students student)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteStudents(int id)
        {
            throw new NotImplementedException();
        }
    }
}