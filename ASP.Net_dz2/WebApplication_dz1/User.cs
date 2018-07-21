using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication_dz1
{
    public class User
    {
        public Role RoleUser;
        public int Id { get; set; } = 0;
        public string Login { get; set; } = "";
        public string Password { get; set; } = "";
        public string Email { get; set; } = "";
        public string FirstName { get; set; } = "";
        public string LastName { get; set; } = "";
        public string City { get; set; } = "";

        public User(){ }
        public User(int id, string login, string pass, string roleUser) 
        {
            Id = id;
            Login = login;
            Password = pass;
            RoleUser = new Role(roleUser); 
        }
    }
}