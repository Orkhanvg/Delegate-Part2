namespace Delegate_Part2.Models
{
    class Book:IEntity
    {
        public string Name { get; set; }
        public string AuthorName { get; set; }
        public int PageCount { get; set; }
        public  bool IsDeleted { get; set; }

        public int ID
        {
            get
            {
                return ID;
            }
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
