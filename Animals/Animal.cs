namespace Animals
{
    public abstract class Animal
    { 
     public Animal(int age, string name)
    {
        Age = age;
        Name = name;
    }
    public int Age { get; set; }
    public string Name { get; set; }

    public abstract void Sound();
    }
}
