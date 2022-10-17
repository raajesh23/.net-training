using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Assignment6


{
    class BookShelf 
    {
        Boooks b;
       
        public static void SetIndexer(Boooks b)
        {

            
            b[0] = "Kolaiyuthirkalam";
            b[1] = "Meluhas";
            b[2] = "Nagas";
            b[3] = "The Alchemist";
            b[4] = "Seven years of Slave";
            b[0L] = "Sujatha";
            b[1L] = "Amish";
            b[2L] = "Tripathi";
            b[3L] = "Paulo coelho";
            b[4L] = "Solomon Northup";
            b.Display();
            
        }
        public BookShelf()
        {
            b = new Boooks();
            SetIndexer(b);

        }
      


    }

    class Boooks 
    {
        internal string[] BookName = new string[5];
        internal string[] AuthorName = new string[5];
        public string this[int bname]
        {
            get
            {
                return BookName[bname];
            }
            set
            {
                BookName[bname] = value;
            }
        }
        public string this[long aname]
        {
            get
            {
                return AuthorName[aname];
            }
            set
            {
                AuthorName[aname] = value;
            }

        }
        public  void Display()
        {
            Console.WriteLine("*******BookDetails*******");
            for (int i = 0; i < 5; i++)
            {

                Console.WriteLine("the Book {0} was written by {1} ",BookName[i],AuthorName[i]);

            }
        }

    }
    class Driven_Bookshelf
    {
        static void Main(string[] args)
        {

            BookShelf i = new BookShelf();
            
            Console.Read();
        }
    }

}