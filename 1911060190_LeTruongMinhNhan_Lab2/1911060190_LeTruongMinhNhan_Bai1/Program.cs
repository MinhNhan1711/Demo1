using System;
using System.Collections;
using System.Linq;
using System.Text;


namespace _1911060190_LeTruongMinhNhan_Bai1
{
 
    public class Book : IBook
    {
        #region
        private string isbn;
        private string title;
        private string author;
        private string publisher;
        private int year;

        private ArrayList chapter = new ArrayList();
        #endregion

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

        public string ISBN;
        public string Title;
        public string Author;
        public string Publisher;
        public int Year;

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

    }

    class BookList
    {
        private ArrayList list = new ArrayList();

        public void AddBook()
        {
            Book b = new Book();
            b.Input();
            list.Add(b);

        }

        public void ShowList()
        {
            foreach (Book b in list)
                b.Show();

        }

        public void InputList()
        {
            int n;
            Console.WriteLine(" Amount of book: ");
            n = int.Parse(Console.ReadLine());
            while (n > 0)
            {
                AddBook();
                n--;
            }
        }
    }

    class Prpgram
    {
        static void Main(string[] args)
        {
             BookList b1 = new BookList();
             b1.InputList();
             b1.ShowList();
             Console.ReadLine();
        }
    }

}