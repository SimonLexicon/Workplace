using System;
using System.Collections.Generic;
using System.Text;

namespace Workplace.Models.Book
{
    public abstract class Publication
    {
        private int pages;
        public string Publisher { get; }
        public string Title { get; }
        public string CopyrightName { get; private set; }
        public int CopyrightDate { get; set; }
        private DateTime publicationDate;
        private bool published = false;

        public int Pages
        {
            get { return pages; }
            set { if (value <= 0){
                    throw new ArgumentException("Pages cant be less than or zero");
                }
            }
        }

        public Publication(string title, string publisher, int pages)
        {
            if (string.IsNullOrEmpty(title))
                throw new ArgumentException("Title cant be null or empty.");
            if (string.IsNullOrEmpty(publisher))
                throw new ArgumentException("Publisher cant be null or empty.");

            Title = title;
            Publisher = publisher;
            Pages = pages;

        }

        public string GetPublicationDate()
        {
            if (published)
            {
                return publicationDate.ToString("d");
            }
            else
            {
                return "Not published yet";
            }
        }

        public void Publish(DateTime datePublished)
        {
            this.publicationDate = datePublished;
            published = true;
        }

        public void Copyright(string copyrightName, int copyrightDate)
        {
            if (string.IsNullOrEmpty(copyrightName))
                throw new ArgumentException("CopyrightName cant be null or empty.");
            
            if (copyrightDate < DateTime.Now.Year)
                throw new ArgumentException("Cant Copyright back in time.");

            CopyrightName = copyrightName;
            CopyrightDate = copyrightDate;
        }

        public override string ToString()
        {
            return Title;
        }
    }
}
