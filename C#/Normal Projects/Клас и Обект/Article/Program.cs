using System;
using System.Collections.Generic;
using System.Linq;


namespace Article
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            List<string> parameters = input.Split(", ").ToList();
            int count = int.Parse(Console.ReadLine());

            Article article = new Article(parameters[0], parameters[1], parameters[2]);

            for (int i = 0; i < count; i++)
            {
                List<string> currCommand = Console.ReadLine().Split(": ").ToList();

                if (currCommand[0] == "Edit" )
                {
                    article.Edit(currCommand[1]);
                }
                if (currCommand[0] == "ChangeAuthor")
                {
                    article.ChangeAouthor(currCommand[1]);
                }
                if (currCommand[0] == "Rename")
                {
                    article.ChangeTitle(currCommand[1]);
                }

            }
            Console.WriteLine(article.ToString());
        }
    }
    class Article
    {
        public string Title;
        public string Content;
        public string Aouthor;

        public Article(string title, string content, string aouthor)
        {
            this.Title = title;
            this.Content = content;
            this.Aouthor = aouthor;
        }

        public void Edit (string newContent)
        {
            this.Content = newContent;
        }
       public void ChangeAouthor (string newAouthor)
        {
            this.Aouthor = newAouthor;
        }
        public void ChangeTitle (string newTitle)
        {
            this.Title = newTitle;
        }
        public override string ToString()
        {
            return Title + " - " + Content + " - " + Aouthor; 
        }
    }
}
