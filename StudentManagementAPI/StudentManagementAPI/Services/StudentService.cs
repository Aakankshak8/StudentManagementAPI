using System;
using StudentManagementAPI.Interfaces;
using StudentManagementAPI.Models;
using StudentManagementAPI.Repositories;

namespace StudentManagementAPI.Services
{
    public class StudentService : IStudentService
    {
        private readonly IStudentRepository _repository;

        public StudentService(IStudentRepository repository)
        {
            _repository = repository;
        }

        public async Task<List<Students>> GetAllStudents()
        {
            return await _repository.GetAllStudents();
        }

        public async Task<Students> AddStudent(Students student)
        {
            student.CreatedDate = DateTime.Now;
            return await _repository.AddStudent(student);
        }

        public async Task<Students> UpdateStudent(Students student)
        {
            return await _repository.UpdateStudent(student);
        }

        public async Task<bool> DeleteStudent(int id)
        {
            return await _repository.DeleteStudent(id);
        }
    }
}