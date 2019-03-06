using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechnicalServiceC.Objects
{
    public class Car
    {
        public int Id { get; set; }
        public int ProjectId { get; set; }

        public List<int> ComponentsCode = new List<int>();

        public string Model { get; private set; }
        public int Year { get; private set; }
        public string Type { get; private set; }
        public int Numb { get; private set; }
        public bool Active { get; set; }

        public void AddNewComponent(int code)
        {
            ComponentsCode.Add(code);
        }
        public void ShowComponents()
        {
            foreach (int item in ComponentsCode)
            {
                Console.WriteLine(item);
            }
        }

        public Car(string model, int year, string type, int numb, bool active, int projectId)
        {
            Model = model;
            Year = year;
            Type = type;
            ProjectId = projectId;
            Numb = numb;
            Active = active;
        }

        public override string ToString()
        {         
            return string.Format("Model: {0},\tYear: {1}\nType: {2},\tNumb: {3}", Model, Year, Type, Numb);
        }
    }
}
