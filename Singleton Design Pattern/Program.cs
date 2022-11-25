using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton_Design_Pattern
{
    public class Student
    {
        static void Main(string[] args)
        {
            School student = School.GetInstance();   //method invoking
            School studentsecond = School.GetInstance();
            string sStudentName = student.getStudentDetails();
            string sStudentSecondName = studentsecond.getStudentSecondDetails();
            Console.WriteLine(sStudentName);
            Console.WriteLine(sStudentSecondName);
            Console.ReadLine();
        }
    }
}
