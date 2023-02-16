using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;

namespace ItemClass
{
    abstract public class Item
    {
        abstract public void Sound();
        abstract public void Show();
        abstract public void Desc();
    }
    public class Teapot : Item
    {
        public override void Desc()
        {
            Console.WriteLine("Teapot is used to heat water.");
        }

        public override void Show()
        {
            Console.WriteLine("Teapot");
        }

        public override void Sound()
        {
            Console.WriteLine("Whoooooooooosh");
        }
    }
    public class MicrowaveOven : Item
    {
        public override void Desc()
        {
            Console.WriteLine("Microwave oven is used to heat food.");
        }

        public override void Show()
        {
            Console.WriteLine("Microwave oven");
        }

        public override void Sound()
        {
            Console.WriteLine("W-w-w-w-w-w-w");
        }
    }

    public class Car : Item
    {
        public override void Desc()
        {
            Console.WriteLine("Car is used to get to some point that is far away from you, faster.");
        }

        public override void Show()
        {
            Console.WriteLine("Car");
        }

        public override void Sound()
        {
            Console.WriteLine("R-r-r-r-r-r-r-r");
        }
    }
    public class Stemboat : Item
    {
        public override void Desc()
        {
            Console.WriteLine("A boat that moves by steam power.");
        }

        public override void Show()
        {
            Console.WriteLine("Steamboat");
        }

        public override void Sound()
        {
            Console.WriteLine("Hsh-sh-sh-sh-sh-sh-sh");
        }
    }
}
