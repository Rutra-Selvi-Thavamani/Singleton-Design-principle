using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton_Design_Pattern
{
    public class School
    {
        private static int counter = 0;
        private School()
        {
            counter++;
            Console.WriteLine("Counter Value:" + counter.ToString());
        }
        public static School objInstance;
        private static readonly object mylockobject = new object();  //multi threaded
        public static School GetInstance()
        {
            lock (mylockobject)
            {
                if (objInstance == null)
                   objInstance = new School();
            }
            return objInstance;
        }
        public string getStudentDetails()
        {
            return "The First student name is - Aravind";
        }
        public string getStudentSecondDetails()
        {
            return "The seccond student is - Donald";
        }
    }
}

