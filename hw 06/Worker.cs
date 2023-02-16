using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw_06
{
    abstract public class Worker
    {
        abstract public void Print();
    }
    public class President : Worker
    {
        public override void Print()
        {
            Console.WriteLine("President");
        }
    }

    public class Security : Worker
    {
        public override void Print()
        {
            Console.WriteLine("Security");
        }
    }

    public class Manager : Worker
    {
        public override void Print()
        {
            Console.WriteLine("Manager");
        }
    }

    public class Engineer : Worker
    {
        public override void Print()
        {
            Console.WriteLine("Worker");
        }
    }
}
