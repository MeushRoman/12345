using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechnicalServiceC.Modules;
using TechnicalServiceC.Objects;

namespace TechnicalServiceC
{
    class Program
    {

       
        static void Main(string[] args)
        {
            CreateTechnicalService();
        }

        static void CreateTechnicalService()
        {
            Car c = new Car("s", 0, "a", 1, true, 1);
            CreateProject cp = new CreateProject();
            cp.CreateNewProject(1, "P1", 1);
            CreateCar cc = new CreateCar();
            cc.CreateNewCar("s", 0, "a", 1, true,1);
            cc.CreateNewComponent(123, "Двигатель");
            cc.CreateNewComponent(124, "КПП");
            Console.WriteLine(cc.ShowComponents()); 
            cc.setComponentInCar(1, 123);
            cc.setComponentInCar(1, 124);

            Console.WriteLine(  cc.Cars[0].ToString());
            cc.Cars[0].ShowComponents();


        }
    }
}
