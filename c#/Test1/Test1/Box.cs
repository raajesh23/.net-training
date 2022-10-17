using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Test1
{
    class Box
    {
        
        public delegate void CustomDel();
        public float length = 10;
        public float breadth = 5;



        public static void Box1()
        {



        }



        public static void Box2()
        {



        }

         public static void Box3()
        {

        }


        static void Main(string[] args)
        {



            CustomDel Box3 = new CustomDel(Box1);
            CustomDel b = new CustomDel(Box2);
            Box3 += Box1;
            Box3 = b+Box3;
            Box3();



        }
    }
}
