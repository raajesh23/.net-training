using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace doctor_and_scholarship
{
    class Doctor
    {
        static void Main(string[] args)
        {
            Doctor d = new Doctor();
            d.Name = "lenin";
            d.RegNo = 007;
            d.FeesCharged = 3000;
            d.Display();
            Console.Read();

        }
        private int regno;
        private string nme;
        private int fees;
        public string Name  
        {
            get { return nme; }
            set { nme = value; }
        }

        public int RegNo    
        {
            get
            {
                return regno;
            }
            set
            {
                regno = value;
            }
        }

        public int FeesCharged 
        {
            get
            {
                return fees;
            }
            set
            {
                fees = value;
            }
        }


        public void Display()
        {
            Console.WriteLine("********Docter fee******");
            Console.WriteLine("Name: " + nme);
            Console.WriteLine("Register No :" + regno);
            Console.WriteLine("FeesCharged: " + fees);
        }
    }
    /*class Doctor
    {
        static void Main(string[] args)
        {
            Calling d = new Calling();
            d.Name = "lenin";
            d.RegNo = 007;
            d.FeesCharged = 3000;
            d.Display();
            Console.Read();

        }
    }*/

}