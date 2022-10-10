using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_5
{


    abstract class Student
    {
        public string Name;
        public  int StudentId;
        public float grade;

        public abstract Boolean IsPassed(float grade);
    
    }

    class UndergGrad:Student
    {
        
        
        public override bool IsPassed(float grade) 
        {
            if (grade > 70.0f)
            {
                Console.WriteLine("Passed");
                return true;
            }
            else
            {
                Console.WriteLine("Failed");
                return false;
            }
        }
    }
    class Grad:Student
    {
        public override bool IsPassed(float grade)
        {
            if (grade > 80.0f) { 
            Console.WriteLine("Passed");
            return true;
        }else {
                Console.WriteLine( "Failed");
                return false;
        }
        }
    }
    class Program1
    {
        static void Main(string[] args)
        {
            Student student = new UndergGrad();
            student.Name = "Raajesh";
            student.StudentId = 007;
            Console.WriteLine("enter the grade for undergrad:");
            student.grade = Convert.ToSingle(Console.ReadLine());
            student.IsPassed(student.grade);
            student = new Grad(); 
            student.Name = "kumar";
            student.StudentId = 10101;
            Console.WriteLine("Enter the grade for grad");
            student.grade = Convert.ToSingle(Console.ReadLine());
            student.IsPassed(student.grade);
            Console.Read();


            
        }
    }
}
  
