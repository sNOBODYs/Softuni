using System;
using System.Collections.Generic;
using System.Text;

namespace Newspapper
{
    class News
    {
        private string title;
        private string text;
        private string writer;

        public string Title
        {
            get { return title; }
            set { this.title = value; }
        }
        public string Text
        {
            get { return text; }
            set { this.text = value; }
        }
        public string Writer
        {
            get { return writer; }
            set { this.writer = value; }
        }
        public News(string text, string writer, string title)
        {
            this.text = text;
            this.writer = writer;
            this.title = title;
        }
        public void Edit(string newText)
        {
            this.Text = newText;
        }
        public void Rename(string newTitle)
        {
            this.Title = newTitle;
        }
        public void ChangeWriter(string newWriter)
        {
            this.Writer = newWriter;
        }
        public override string ToString()
        {
            return $"{this.Title} - {this.Text}: {this.Writer}";
        }

    }
}
