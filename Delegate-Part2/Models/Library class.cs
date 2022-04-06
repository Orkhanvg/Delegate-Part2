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
                catch (AlreadyExsistException)
                {
                    throw new AlreadyExsistException("This book is already exsist");
                }
               catch (CapacityLimit)
                {
                    throw new CapacityLimit("Limit is full");
                }



            }
        }
        public void GetBookById(int?id)
        {
            foreach (var item in books)
            {
                if (id==item.ID&&item.IsDeleted==false&&id!=null)
                {
                    item.ShowInfo();


                }
                else
                {
                    throw new SystemException("Null Reference");
                }
            }
            
        }
        public void GetAllBooks()
        {
            List<Book> books2 = new List<Book>();
            foreach (var item in books)
            {
                books2.Add(item);
                books.Remove(item);

            }

        }
       
        public void DeleteBookById(int?id)
        {
            foreach (var item in books)
            {
                if (id == item.ID && item.IsDeleted == false && id != null)
                {
                    item.IsDeleted = true;


                }
                else if(id==null)
                {
                    throw new SystemException("NullReference");

                }
                else
                {
                    throw new SystemException("NotFound");
                }
            }

        }
        //EditBookName() - parametr olaraq int tipindən nullable bir id qəbul edəcək
        //həmin id-li book-u tapıb name-ni dəyişəcək
        //    əgər id null olarsa NullReferenceException qaytaracaq əgər elə bir book tapmasa NotFoundException qaytaracaq.

        public void EditBookName(int?id)
        {
            item.
        }
    }


}
