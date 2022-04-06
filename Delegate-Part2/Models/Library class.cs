using System;
using System.Collections.Generic;
using Utils.Exceptions;

namespace Delegate_Part2.Models
{
    class Library_class : IEntity
    {

        public int BookLimit { get; set; }

        public int ID
        {
            get
            {
                return ID;
            }
        }
        private List <Book> books = new List<Book>();

        public void AddBook(Book book)
        {
            foreach (var item in books)
            {
                
                try 
                {
                    if (book.Name != item.Name && item.IsDeleted == false)
                    {
                        books.Add(book);
                    }
                       
                }
                catch 
                {
                    throw new AlreadyExsistException("this book is already exsist");
                }
                



            }
        }
    }


}
