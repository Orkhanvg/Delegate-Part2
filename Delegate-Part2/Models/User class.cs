namespace Delegate_Part2.Models
{
    class User_class:IEntity
    {

        public string UserName { get; set; }
        public string Email { get; set; }
        public string Role { get; set; }

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
        public User_class(string username, string email, string role)
        {
            UserName = username;
            Email = email;
            Role = role;

        }
    }
}
