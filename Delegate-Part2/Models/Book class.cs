﻿namespace Delegate_Part2.Models
{
    class Book
    {
        public string Name { get; set; }
        public string AuthorName { get; set; }
        public int PageCount { get; set; }
        public  bool IsDeleted { get; set; }

        
        
        public bool Remove(IsDeleted)
        {
            bool result = false;
            return result ;
        }
        public void ShowInfo()
        {

        }
        public Book(string name, string authorname, int pagecount)
        {
            Name = name;
            AuthorName = authorname;
            PageCount = pagecount;
            IsDeleted = false;
        }



    }
}
