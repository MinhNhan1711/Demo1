using System;
using System.Collections;
using System.Text;

namespace Lab2_LeTruongMinhNhan
{
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

        public void sapXepIComparerable()
        {
            list.Sort();
        }

        public void sapXepIComparer()
        {
            list.Sort(new Book());
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
}
