using System;

namespace mod2
{
    class Program
    {
        static void Main(string[] args)
        {
            Users user = new Users();
            user.setUserName("Erick");
            user.setEmail("erick@email.com");


            Console.WriteLine("User:" + user.setUserName() + " : " + user.getEmail());
        }

    }

    public class Users
    {
        private string userName = "";
        private string email = "";

        public string setUserName()
        {
            return userName;
        }
        public void setUserName(string uName)
        {
            userName = uName;
        }
        public string getEmail()
        {
            return email;
        }
        public void setEmail(string email2)
        {
            email = email2;
        }

        internal class getUserName
        {
        }
    }
    public class Roles
    {
    }
    public class Images
    {

    }
    public class Posts
    {

    }
    public class Comments
    {

    }
}
     