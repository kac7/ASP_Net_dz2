using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication_dz1
{
    public class Singleton
    {
        public List<User> Users { get; set; } = new List<User>();
        private static Singleton _instance;
        public int id { get; set; } = 1;
        public static Singleton Instance => _instance ?? (_instance = new Singleton());
        private Singleton()
        {

        }
    }
}