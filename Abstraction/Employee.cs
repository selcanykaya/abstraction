using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction
{
    public abstract class Employee
    {
        public string Name { get; set; }
        public string LastName { get; set; }

        public string Department { get; set; }

        public abstract void Work();

        public void Introduce()
        {
            Console.WriteLine($"Hello, my name is {Name} {LastName} and I work in the {Department} department.");
        }
    }

    public class Manager : Employee
    {
        public override void Work()
        {
            Console.WriteLine($"{Name} {LastName} is managing the team.");
        }
    }
    public class Developer : Employee
    {
        public override void Work()
        {
            Console.WriteLine($"{Name} {LastName} is developing software.");
        }
    }
    public class Designer : Employee
    {
        public override void Work()
        {
            Console.WriteLine($"{Name} {LastName} is designing user interfaces.");
        }
    }

    public class  SalesOfficer : Employee
    {
        public override void Work()
        {
            Console.WriteLine($"{Name} {LastName} is selling products.");
        }
    }
}
