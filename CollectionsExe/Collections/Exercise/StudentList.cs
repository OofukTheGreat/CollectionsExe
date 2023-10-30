using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CollectionsExe.Collections.Exercise.Models;

namespace CollectionsExe.Collections.Exercise
{
    //StudentList is a class represented by a List of students.

    public class StudentList
    {

        //Targil 1 - write the Property of StudentList called Students
        #region Properties
       public List<Student> students { get; set; }
        #endregion

        //Targil 2 - Write a constructor which initiates the students and calls for Student.FillList()
        #region Constructor
        public StudentList()
        {
            students = Student.FillList();
        }
        #endregion


        #region Find Student By Name
        //Targil 3- write a method which retrieves a Student By name. 

        public Student FindStudentByName(string name)
        {
            foreach (Student s in students)
            {
                if (s.Name == name) return s;
            }
            return null;
        }
        #endregion

        #region retrieving a list
        //Targil 4-  write a method which retrieves a list of Students By Kita
        public List<Student> GetStudentsByKits(int kita)
        {
            List<Student> classlist = new List<Student>();
            foreach (Student s in students)
            {
                if (s.Kita==kita) classlist.Add(s);
            }
            return classlist;
        }
        #endregion



    }
}
