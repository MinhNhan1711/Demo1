using System;
using System.Collections.Generic;
using System.Text;

namespace Lab2_LeTruongMinhNhan
{
    interface IBook
    {
        string this[int index]
        {
            get;
            set;
        }

        string Title
        {
            get { return this.Title; }
            set { this.Title = value; }
        }

        string Author
        {
            get { return this.Author; }
            set { this.Author = value; }
        }

        string Publisher
        {
            get { return this.Publisher; }
            set { this.Publisher = value; }
        }

        string ISBN
        {
            get { return this.ISBN; }
            set { this.ISBN = value; }
        }

        int Year
        {
            get { return this.Year; }
            set { this.Year = value; }
        }

        void Show();
    }
}
