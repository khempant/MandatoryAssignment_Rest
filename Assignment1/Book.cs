using System;

namespace Assignment1
{
    public class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public string IsbnNo { get; set; }
        public int PageNo { get; set; }

        public Book(string title, string author, string isbnNo, int pageNo)
        {
            Title = title;
            Author = author;
            IsbnNo = isbnNo;
            PageNo = pageNo;
        }

    }
}
