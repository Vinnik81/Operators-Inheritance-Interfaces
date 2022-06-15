using System;

namespace Animals
{
    public class Dog : Animal
    {
        public Dog(int age, string name) : base(age, name)
        {
        }


        override public void Sound()
        {
            Console.WriteLine("Dog say how how");
        }
    }
}
