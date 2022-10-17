using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Assignment6
{
    class TestStructures
    {
        static void Main(string[] args)
        {
            Books books = new Books();
            books.SetValues("Rich Dad Poor Dad", "Robert Kiyosaki", "Financial Management", 209);
            books.GetValues();
            Console.Read();
        }
    }

    struct Books
    {
        private string title;
        private string Author;
        private string Subject;
        private int Book_Id;

        public void GetValues()
        {
            Console.WriteLine("**********Book Details*******");
            Console.WriteLine("Book ID: " + Book_Id);
            Console.WriteLine("Title: "+title);
            Console.WriteLine("Author: " + Author);
            Console.WriteLine("Subject: " + Subject);
           
        }
        public void SetValues(string Title,string authour,string subject,int BId)
        {
            title = Title;
            Author = authour;
            Subject = subject;
            Book_Id = BId;
        }

    }
    
}
