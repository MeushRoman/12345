using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechnicalServiceC.Objects;

namespace TechnicalServiceC.Modules
{
    public class CreateCar
    {
        public Dictionary<int, string> Components = new Dictionary<int, string>();
        public List<Project> Projects { get; set; }
        public List<Car> Cars = new List<Car>();

        //создание машины
        public void CreateNewCar(string model, int year, string type, int numb, bool active, int projectId)
        {
            Cars.Add(new Car(model, year, type, numb, active, projectId));
        }

        //создание компонента
        public void CreateNewComponent(int code, string name)
        {
            Components.Add(code, name);
        }

        public string ShowComponents()
        {
           // int i = 0;
            string str = "";
            foreach (var item in Components)
            {
                // i++;{0}\t
                str += string.Format("{0}\t{1}\n", item.Key, item.Value);                
            }
            return str;
        }

        public void setComponentInCar(int carId, int componentCode)
        {
            Cars.Where(w => w.Numb == carId).ToList()[0].ComponentsCode.Add(componentCode);
        }


    }
}
