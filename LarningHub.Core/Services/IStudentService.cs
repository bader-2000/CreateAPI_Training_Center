﻿using LarningHub.Core.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LarningHub.Core.Services
{
    public interface IStudentService
    {
        public List<Student> GetAllStudent();
        public Student GetStudentByID(int ID);
        public void CreateStudent(Student student);
        public void UpdateStudent(Student student);
        public void DeleteStudent(int ID);
        public List<Student> displayFNameAndLNameStudent();
        public List<Student> displayStudentByFname(String Fname);
        public List<Student> displayStudentByBirthDate(DateTime student_date);
        public List<Student> displayStudentbetweenInterval(DateTime from_date, DateTime to_date);
        public List<Student> displayStudentHighestMarks(int NumOfStudent);
    }
}
