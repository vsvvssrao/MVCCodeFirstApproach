using MvcSpaDemo.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MvcSpaDemo.DataAccess
{
    public class StudentData
    {
        public static void AddStudent(Student student)
        {
            var context = new StudentContext();
            context.Student.Add(student);
            context.SaveChanges();
        }

        public static IEnumerable<Student> GetStudents()
        {
            var context = new StudentContext();
            return context.Student.ToList();
        }

        public static Student GetStudentById(int studentID)
        {
            var context = new StudentContext();
            return context.Student.FirstOrDefault(x => x.StudentID == studentID);
        }

        public static void UpdateStudent(Student student)
        {
            var context = new StudentContext();
            context.Student.Attach(student);
            context.Entry(student).State = EntityState.Modified;
            context.SaveChanges();
        }

        public static void DeleteStudent(int studentID)
        {
            var context = new StudentContext();
            var student = context.Student.Find(studentID);
            context.Student.Remove(student);
            context.SaveChanges();
        }
    }
}