using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechnicalServiceC.Objects
{
    public class CarBroken
    {
        public int Id { get; set; }
        public DateTime CreateDate { get; set; }
        public int CarId { get; set; }
        public string Description { get; set; }
        public string RecForRepare { get; set; }
        public int UserId { get; set; }
    }
}
