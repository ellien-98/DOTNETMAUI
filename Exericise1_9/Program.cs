using System;

namespace Ex1_9
{
    public class Book
    {
        public virtual int GetPageCount()
        {
            return 1; 
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Book baseBook = new Book();
            Book eragonBook = new Eragon();
            Book gTBook = new GameTheory();
            
            Console.WriteLine($"Book number: {baseBook.GetPageCount()}, Eragon number: {eragonBook.GetPageCount()}, GameTheory number: {gTBook.GetPageCount()} ");
        }
    }

    public class Eragon : Book
    {
        public override int GetPageCount()
        {
            return base.GetPageCount() + 6;
        }
    }

    public class GameTheory : Book
    {
        public override int GetPageCount()
        {
            return base.GetPageCount() + 10;
        }
    }
    
}