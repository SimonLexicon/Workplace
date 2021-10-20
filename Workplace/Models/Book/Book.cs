using System;
using System.Collections.Generic;
using System.Text;

namespace Workplace.Models.Book
{
    public class Book : Publication
    {
        public Book(string title, string publisher, int pages, string isbn, string author, int price) 
            : base(title, publisher, pages)
        {
            if (string.IsNullOrEmpty(isbn))
                throw new ArgumentException("ISBN cant be null or empty.");
            if (string.IsNullOrEmpty(author))
                throw new ArgumentException("author cant be null or empty.");
            if (price <= 0)
                throw new ArgumentException("Price cannot be less than or zero");

            ISBN = isbn;
            Author = author;
            Price = price;
        }

        private int price;

        public string ISBN { get; }
        public string Author { get; }
        public int Price { get { return price; } private set {
                if (value <= 0)
                    throw new ArgumentException("Price cannot be less than or zero");
                price = value;}}

        public string SetPrice(int price)
        {
            int oldPrice = Price;
            Price = price;
            return $"Replaced old price:{oldPrice}, with new price: {Price}";
        }

    }
}
