namespace Animals
{
    public class Airplane : Tranpsort, IFlyable
    {
        public void Fly()
        {
            System.Console.WriteLine("Airplane fly");
        }
    }
}

