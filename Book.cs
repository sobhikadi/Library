using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    [Serializable]
    public class Book
    {
        public int Id { get; private set; }

        public string Title { get; private set; }

        public int NrOfCopies { get; private set; }

        public string Author { get; private set; }

        public string Genre { get; private set; }

        public string Description { get; private set; }

        public DateTime PublishDate { get; private set; }

        public int NrOfPages { get; private set; }

        public string ISBN { get; private set; }

        public int NrCopiesAvailable { get; private set; }



        public Book(string title, string author, string genre, string description, DateTime publishDate, string isbn, int nrOfCopies, int pages) 
        {
            Title = title;
            NrOfCopies = nrOfCopies;
            Author = author;
            Genre = genre;
            Description = description;
            PublishDate = publishDate;
            NrOfPages = pages;
            ISBN = isbn;
            NrCopiesAvailable = NrOfCopies;
        }

        public Book(int id, string title, string author, string genre, string description, DateTime publishDate, string isbn, int nrOfCopies, int pages)
        {
            Id = id;
            Title = title;
            NrOfCopies = nrOfCopies;
            Author = author;
            Genre = genre;
            Description = description;
            PublishDate = publishDate;
            NrOfPages = pages;
            ISBN = isbn;
            NrCopiesAvailable = NrOfCopies;
        }

        public void ReduceBookStock()
        {
            NrCopiesAvailable--;
        }

        public void IncreaseBookStock()
        {
            if (NrCopiesAvailable == NrOfCopies) return;
            NrCopiesAvailable++;
        }

        public override string ToString()
        {
            return $"{Title} By {Author} - {Genre}; Copies available: {NrCopiesAvailable}.";
        }

    }
}
