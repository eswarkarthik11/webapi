using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace WebApi.Controllers
{
    public class Users1Controller : ApiController
    {
        public List<users> Get()
        {
            return Users;
        }

        public void Post([FromBody] users u)
        {
            
            Users.Add(u);
            

        }

        static List<users> Users = InitUsers();
        private static List<users> InitUsers()
        {
            var x = new List<users>();
            x.Add(new users { uid = 0, name = "eswar" });
            return x;
        }
    }

    public class users
    {
        public int uid;
        public string name;
    }

    //public class contacts
    //{
    //    public int id;
    //    public int uid;
    //    public int number;
    //}
}