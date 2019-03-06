using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechnicalServiceC.Objects;

namespace TechnicalServiceC.Modules
{
    public class CreateUser
    {
        public List<User> users { get; set; }

        public override string ToString()
        {            
            string str = "";
            foreach (User item in users)
            {
                str += string.Format("{0}\t{1}\t{2}\n", item.Id, item.Login, item.Project);
            }
            return str;
        }

        public void CreateNewUser(string login, string password, string access, string project)
        {
            users.Add(new User(login, password, access, project));
        }
    }
}
