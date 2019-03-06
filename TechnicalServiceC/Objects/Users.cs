using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechnicalServiceC.Objects
{
    public class User
    {
        public int Id { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public string Access { get; set; }
        public string Project { get; set; }

        public User(string login, string password, string access, string project)
        {
            this.Login = login;
            this.Password = password;
            this.Access = access;
            this.Project = project;
        }
    }
}
