using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testzzz
{
    internal class Student
    {
        string name;
        int age;
        int idcard;
        string local;

        static void Main (string[] args)
        {
            Student s = new Student();
            s.name = "Tran Trong Hoa";
            s.age = 18;
            s.idcard = 100;
            s.local = "Vie";
            Console.WriteLine(s.name+s.age+s.idcard+s.local);
            Student newstu = new Student();
            newstu.name = "Tran hung";
            newstu.age = 18;
            newstu.idcard = 100;
            newstu.local = "en";
            Console.WriteLine(newstu.name+newstu.age+newstu.idcard+newstu.local);
        }

        
    }
}
