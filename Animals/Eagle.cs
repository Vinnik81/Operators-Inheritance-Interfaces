using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{

    public class Eagle : Animal, IFlyable
    {
        public Eagle(int age, string name) : base(age, name)
        {
        }

        public void Fly()
        {
            Console.WriteLine("Eagle fly");
        }

        public override void Sound()
        {
            Console.WriteLine("");
        }
    }
}

