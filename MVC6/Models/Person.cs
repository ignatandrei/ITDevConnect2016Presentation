using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AMVC6.Models
{
    public interface IPerson
    {
        int id { get; set; }
        string Name { get; set; } 
    }
    public class Person:IPerson
    {
        public int id { get; set; }
        public string Name { get; set; } = "Andrei";
    }
}
