using System;
using System.Collections.Generic;
using System.Collections;
using System.Text;

namespace IteratorsAndComparators
{
    public class Book : IComparable<Book>
    {
        public string Title { get; set; }
        public int Year { get; set; }

        public List<string> Authors { get; set; }

        public int CompareTo(Book other)
        {
            var result = this.Year.CompareTo(other.Year);
            if (result == 0)
            {
                result = this.Year.CompareTo(other.Title);
            }
            return result;
        }
        public override string ToString()
        {
            return $"{this.Title} - {this.Year}";
        }
        public Book(string title, int year, params string[] authors)
        {
            Title = title;
            Year = year;
            Authors = new List<string>(authors);
        }
    }
}