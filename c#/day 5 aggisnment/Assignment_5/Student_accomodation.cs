﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Create an Interface IStudent with int StudentId and string Name as Properties, void ShowDetails() as its method.
//Create 2 classes Dayscholar and Resident that implements the interface Properties and Methods.ShowDetails() should show DaysScholar details and
//Resident Details accordingly

namespace Assignment_5
{
    class Student_accomodation
    {
        static void Main(string[] args)
        {
            IStudent student = new DayScholor();
           
            student.Name = "raajesh";
            student.StudentId = 007;
            student.ShowDetails();
            IStudent resident = new Resident();
            resident.Name = "kumar";
            resident.StudentId = 10101;
            resident.ShowDetails();
            Console.ReadLine();
        }

    }
    interface IStudent
    {
         int StudentId { get; set; }
        string Name { get; set; }
        void ShowDetails();
    }
    class DayScholor: IStudent
    {
       
        
        string name;
        int id;
        public int StudentId
        {
            get { return id; }
            set { id = value; }
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }


        void IStudent.ShowDetails()
        {
            Console.WriteLine("*******DayScholor*******");
            Console.WriteLine(" Student Id: {0}", id);
            Console.WriteLine("Student Name: {0}",name);
            Console.WriteLine();
            
        }
            
    
    }
    class Resident:IStudent //inheriting interface
    {

        string name;
        int id;
        public int StudentId
        {
            get { return id; }
            set { id = value; }
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        void IStudent.ShowDetails()
        {
            Console.WriteLine("*****Resident*****");
            Console.WriteLine(" Student Id: {0}", id);
            Console.WriteLine("Student Name: {0}", name);


        }


    }
}
