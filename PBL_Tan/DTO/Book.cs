using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBL_Tan.DTO
{
    class Book
    {
        private string BookID;
        private string BookName;
        private string BookTitle;
        private string BookDescription;
        private string BookAuthor;

        public string BookID1 { get => BookID; set => BookID = value; }
        public string BookName1 { get => BookName; set => BookName = value; }
        public string BookTitle1 { get => BookTitle; set => BookTitle = value; }
        public string BookDescription1 { get => BookDescription; set => BookDescription = value; }
        public string BookAuthor1 { get => BookAuthor; set => BookAuthor = value; }

        public Book(string id, string name, string title, string description, string author)
        {
            BookID = id; 
            BookName = name;
            BookTitle = title;
            BookDescription = description;
            BookAuthor = author;
        }
    }
}
