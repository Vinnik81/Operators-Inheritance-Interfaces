using System;

namespace Animals
{
    public class Cat : Animal
    {
        public Cat(int lives, int age, string name) : base(age, name)
        {
            Lives = lives;
        }
        public int Lives { get; set; }


        override public void Sound()
        {
            Console.WriteLine("Cat say moew moew");
        }
    }
}
