using System;
using System.Collections;
using System.Text;

namespace Lab2_LeTruongMinhNhan
{
    class Book : IBook, IComparable, IComparer
    {

        private string isbn;
        private string title;
        private string author;
        private string publisher;
        private int year;

        private ArrayList chapter = new ArrayList();

        public string this[int index]
        {
            get
            {
                if (index >= 0 && index < chapter.Count)
                    return (string)chapter[index];
                else
                    throw new IndexOutOfRangeException();
            }
            set
            {
                if (index >= 0 && index < chapter.Count)
                    chapter[index] = value;
                else if (index == chapter.Count)
                    chapter.Add(value);
                else
                    throw new IndexOutOfRangeException();
            }
        }

        public string ISBN
        {
            get;
            set;
        }
        public string Title
        {
            get;
            set;
        }
        public string Author
        {
            get;
            set;
        }
        public string Publisher
        {
            get;
            set;
        }
        public int Year
        {
            get;
            set;
        }

        public void Show()
        {
            Console.WriteLine("--------------------");
            Console.WriteLine("Title:  " + title);
            Console.WriteLine("Author:  " + author);
            Console.WriteLine("Publisher:  " + publisher);
            Console.WriteLine("Year:  " + year);
            Console.WriteLine("ISBN:  " + isbn);
            Console.WriteLine("Chapter: ");
            for (int i = 0; i < chapter.Count; i++)
            {
                Console.WriteLine("\t {0}: {1}", i + 1, chapter[i]);
            }
            Console.WriteLine("--------------------");
        }

        public void Input()
        {
            Console.WriteLine("Title:  ");
            title = Console.ReadLine();
            Console.WriteLine("Author:  ");
            author = Console.ReadLine();
            Console.WriteLine("Publisher:  ");
            publisher = Console.ReadLine();
            Console.WriteLine("Year:  ");
            year = int.Parse(Console.ReadLine());
            Console.WriteLine("ISBN:  ");
            isbn = Console.ReadLine();
            Console.WriteLine("Input chapter (finished with empty string)");
            string str;
            do
            {
                str = Console.ReadLine();
                if (str.Length > 0)
                    chapter.Add(str);
            } while (str.Length > 0);

        }

        public int CompareTo(object obj)
        {
            Book b1 = obj as Book;
            return year.CompareTo(b1.year);
            //return title.CompareTo(b1.title); 
            //return author.CompareTo(b1.author);
            //return publisher.CompareTo(b1.publisher);
            //return isbn.CompareTo(b1.isbn);

        }

        public int Compare(object x, object y)
        {
            Book b1 = x as Book;
            Book b2 = y as Book;
            return b1.author.CompareTo(b2.author);
            //return b1.title.CompareTo(b2.title); 
            //return b1.year.CompareTo(b2.year);
            //return b1.publisher.CompareTo(b2.publisher);
            //return b1.isbn.CompareTo(b2.isbn);
        }
    }

    
        
}
