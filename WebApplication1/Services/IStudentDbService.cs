using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.DTO.Request;
using WebApplication1.DTO.Response;
using WebApplication1.Models;

namespace WebApplication1.Services
{
    interface IStudentDbService
    {
        public List<Student> GetStudents();

        public ModifyStudentResponse ModifyStudent(ModifyStudentRequest request);

        public RemoveStudentResponse RemoveStudent(RemoveStudentRequest request);

        public EnrollStudentResponse EnrollStudent(EnrollStudentRequest request);
    }
}
