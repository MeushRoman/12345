using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechnicalServiceC.Objects;

namespace TechnicalServiceC.Modules
{
    public class CreateProject
    {
        Dictionary<Project, int> projects = new Dictionary<Project, int>();

        public void CreateNewProject(int id, string name, int idUser)
        {
            projects.Add(new Project(id, name), idUser);
        }

        public override string ToString()
        {
            string str = "";
            foreach (var item in projects)
            {
                str += string.Format("{0}\t{1}\n", item.Key, item.Value);
            }
            return str;
        }
    }
}
