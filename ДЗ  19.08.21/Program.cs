using System;

namespace ДЗ__19._08._21
{
    // class Rectangle
    // {
    //     private double side1;
    //     private double side2;
    //     public double Area { 
    //         get 
    //         {
    //             return AreaCalculator(); 
    //         }
    //     }
    //     public double Perimeter { 
    //         get 
    //         {
    //             return PerimeterCalculator(); 
    //         }
    //     }
    //     public Rectangle(double _side1, double _side2)
    //     {
    //         this.side1 = _side1;
    //         this.side2 = _side2;
    //     }
    //
    //     private double AreaCalculator()
    //     {           
    //         return this.side1 * this.side2;
    //     }
    //
    //     private double PerimeterCalculator()
    //     {           
    //         return 2 * (this.side1 + this.side2);
    //     }
    // }
    // class Program
    // {
    //     static void Main(string[] args)
    //     {
    //         double A = double.Parse(Console.ReadLine().Replace(".", ","));
    //         double B = double.Parse(Console.ReadLine().Replace(".", ","));
    //
    //         Rectangle rect = new Rectangle(A, B);
    //         Console.WriteLine("AREA: " + rect.Area);
    //         Console.WriteLine("PERIMETER: " + rect.Perimeter);
    //         
            //ТАСК 2
            
             class Program
    {
        class Book
        {
            private Title _bookTitle;
            private Author _bookAuthor;
            private Content _bookContent;
            
            public Book(string _title, string _author, string _content)
            {
                _bookTitle = new Title();
                _bookAuthor = new Author();
                _bookContent = new Content();
                _bookTitle.titleStr = _title;
                _bookAuthor.authorStr = _author;
                _bookContent.сontentStr = _content;
            }

            public void ShowInfo()
            {
                _bookTitle.Show();
                _bookAuthor.Show();
                _bookContent.Show();
            }

            public void ShowTitle()
            {
                _bookTitle.Show();
            }

            public void ShowAuthor()
            {
                _bookAuthor.Show();
            }

            public void ShowContent()
            {
                _bookContent.Show();
            }
        }

        class Title
        {
            public string titleStr { get; set; }
            public void Show()
            {
                Console.BackgroundColor = ConsoleColor.White;
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("Title: " + this.titleStr);
            }
        }

        class Author
        {
            public string authorStr { get; set; }
            public void Show()
            {
                Console.BackgroundColor = ConsoleColor.White;
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Author: " + this.authorStr);
            }
        }

        class Content
        {
            public string сontentStr { get; set; }
            public void Show()
            {
                Console.BackgroundColor = ConsoleColor.Yellow;
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("Content: " + this.сontentStr);
            }
        }
        static void Main(string[] args)
        {
            Console.Write("Input Author: ");
            string author = Console.ReadLine();
            Console.Write("Input Title: ");
            string title = Console.ReadLine();
            Console.Write("Input Content: ");
            string content = Console.ReadLine();

            Book book = new Book(title, author, content);
            book.ShowInfo();
        }

    }
}