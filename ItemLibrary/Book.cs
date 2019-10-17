using System;

namespace ItemLibrary
{
    public class Book
    {
        public string Isbn13 { get; set; }
        public string Author { get; set; }
        public string Name { get; set; }
        public int PageNo { get; set; }
        public string Course { get; set; }


        public Book(string isbnNo, string author, string name, int pageNo, string course)
        {
            Isbn13 = isbnNo;
            Author = author;
            Name = name;
            PageNo = pageNo;
            Course = course;
        }
        public override string ToString()
        {
            return $"{Isbn13}-{Author}-{Name}-{PageNo}-{Course}";
        }
    }
}
