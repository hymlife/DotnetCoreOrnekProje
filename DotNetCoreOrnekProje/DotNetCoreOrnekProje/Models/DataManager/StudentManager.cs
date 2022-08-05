using StudentApplication.API.Models.Repository;
using System.Collections.Generic;
using System.Linq;

namespace StudentApplication.API.Models.DataManager
{
    public class StudentManager : IDataRepository<Student, long>
    {
        ApplicationContext ctx;
        public StudentManager(ApplicationContext c)
        {
            ctx = c;
        }

        public Student Get(long id)
        {
            var student = ctx.Students.FirstOrDefault(b => b.StudentId == id);
            return student;
        }

        public IEnumerable<Student> GetAll()
        {
            var students = ctx.Students.ToList();
            return students;
        }

        public long Add(Student stundent)
        {
            ctx.Students.Add(stundent);
            long studentID = ctx.SaveChanges();
            return studentID;
        }

        public long Delete(long id)
        {
            int studentID = 0;
            var student = ctx.Students.FirstOrDefault(b => b.StudentId == id);
            if (student != null)
            {
                ctx.Students.Remove(student);
                studentID = ctx.SaveChanges();
            }
            return studentID;
        }

        public long Update(long id, Student item)
        {
            long studentID = 0;
            var student = ctx.Students.Find(id);
            if (student != null)
            {
                student.FirstName = item.FirstName;
                student.LastName = item.LastName;
                student.Gender = item.Gender;
                student.PhoneNumber = item.PhoneNumber;
                student.Email = item.Email;
                student.DateOfBirth = item.DateOfBirth;
                student.DateOfRegistration = item.DateOfRegistration;
                student.Address1 = item.Address1;
                student.Address2 = item.Address2;
                student.City = item.City;
                student.State = item.State;
                student.Zip = item.Zip;

                studentID = ctx.SaveChanges();
            }
            return studentID;
        }
    }
}