using System;

namespace ItemLibrary
{
    public class Book
    {
        public string IsbnNo { get; set; }
        public string Author { get; set; }
        public string Name { get; set; }
        public int PageNo { get; set; }
        public string Course { get; set; }


        public Book(string isbnNo, string author, string name, int pageNo, string course)
        {
            IsbnNo = isbnNo;
            Author = author;
            Name = name;
            PageNo = pageNo;
            Course = course;
        }
        public override string ToString()
        {
            return $"{IsbnNo}-{Author}-{Name}-{PageNo}-{Course}";
        }
    }
}
