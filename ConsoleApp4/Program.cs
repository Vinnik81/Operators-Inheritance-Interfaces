using System;
using System.Collections;
using System.Collections.Generic;
using Animals;


namespace ConsoleApp2
{

    partial class Man
    {
        public int Age { get; set; }
    }

    //class Money
    //{
    //    public int Dollar { get; set; }

    //    private int cent;

    //    public int Cent
    //    {
    //        get { return cent; }
    //        set
    //        { //3 dollar 20 centa
    //            if (value >= 100) // 320
    //            {
    //                Dollar += value / 100; // +3
    //                cent = value % 100; // 320 % 100 = 20
    //            }
    //            else
    //                cent = value;
    //        }
    //    }

    //    public static bool operator ==(Money a, Money b)
    //    {
    //        return a.Dollar == b.Dollar && a.Cent == b.Cent;
    //    }
    //    public static bool operator !=(Money a, Money b)
    //    {
    //        return !(a == b);
    //    }


    //    public static Money operator ++(Money money)
    //    {
    //        return new Money { Dollar = money.Dollar, Cent = money.Cent + 1 };
    //    }


    //    public static Money operator --(Money money)
    //    {
    //        return new Money { Dollar = money.Dollar, Cent = money.Cent - 1 };
    //    }


    //    public static bool operator true(Money money)
    //    {
    //        return money.Cent > 0;
    //    }
    //    public static bool operator false(Money money)
    //    {
    //        return money.Cent <= 0;
    //    }

    //    public override string ToString()
    //    {
    //        return $"{Dollar},{Cent}";
    //    }

    //}



    class Person : ICloneable, IComparable
    {
        public Person()
        {

        }
        public Person(string name, string surname, int age)
        {
            Name = name;
            Surname = surname;
            Age = age;
        }

        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }

        public object Clone()
        {
            return new Person(Name, Surname, Age);
        }

        public int CompareTo(object obj)
        {
            return (obj as Person).Name.CompareTo(this.Name);
        }



        //public override bool Equals(object obj)
        //{

        //    if (obj is Person person)
        //        return this.Name == person.Name && this.Surname == person.Surname && this.Age == person.Age;

        //    return false;

        //}

        //public override int GetHashCode()
        //{
        //    return Name.GetHashCode() + Surname.GetHashCode() + Age.GetHashCode();
        //}

        //public static bool operator ==(Person a, Person b)
        //{
        //    return a.Age == b.Age && a.Name == b.Name && a.Surname == b.Surname;
        //}
        //public static bool operator !=(Person a, Person b)
        //{
        //    return !(a == b);
        //}


        public override string ToString()
        {
            return $"{Name} {Surname} {Age}";
        }
    }


    //IClonable
    //ICompareble
    //IEnumberable
    //IConvertable
    //IDisposable


    //struct Point
    //{
    //    public int x { get; set; }
    //    public int y { get; set; }
    //}


    class MyList<T> : IEnumerable where T : struct
    {
        private T[] arr;
        public int Length { get => arr.Length; }

        public MyList(params T[] items)
        {
            arr = items;
        }

        public T this[int index]
        {
            get => arr[index];
            set => arr[index] = value;
        }

        public IEnumerator GetEnumerator()
        {
            return new MyListEnumerator(arr);

            //for (int i = arr.Length-1; i >= 0; i--)
            //{
            //    yield return arr[i];
            //}

            //for (int i = 0; i < arr.Length; i++)
            //{
            //    yield return arr[i];
            //}
            //yield break;
        }


        class MyListEnumerator : IEnumerator
        {
            public object Current => arr[index];
            private T[] arr;
            private int index = -1;

            public MyListEnumerator(T[] arr)
            {
                this.arr = arr;
            }

            public bool MoveNext()
            {
                if (index < arr.Length - 1)
                {
                    index++;
                    return true;
                }

                return false;
            }

            public void Reset()
            {
                index = -1;
            }
        }
    }


    //sealed class Logger
    //{

    //}

    partial class Man
    {
        public string Name { get; set; }
        public string Surname { get; set; }
    }


    //class Person : Logger
    //{

    //}
    class Program
    {
        //static (int, int) MaxMin(params int[] arr)
        //{
        //    int min = arr[0];
        //    int max = arr[0];

        //    for (int i = 0; i < arr.Length; i++)
        //    {
        //        if (arr[i] < min)   min = arr[i];

        //        if (arr[i] > max)   max = arr[i];

        //    }
        //    //arr

        //    return (max, min);
        //}


        //static Tuple<int, int> MaxMin(params int[] arr)
        //{

        //    int min = arr[0];
        //    int max = arr[0];

        //    for (int i = 0; i < arr.Length; i++)
        //    {
        //        if (arr[i] < min) min = arr[i];

        //        if (arr[i] > max) max = arr[i];

        //    }
        //    //arr

        //    return new Tuple<int, int>(max, min);
        //}

        //public static void Print(int a)
        //{
        ////    Console.WriteLine(a);
        //}
        //public static void Print(string a)
        //{
        //    Console.WriteLine(a);
        //}
        //public static void Print(double a)
        //{
        //    Console.WriteLine(a);
        //}

        //public static void Print(object a)
        //{
        //    int b = (int)a; // unboxing
        //    //Console.WriteLine(b);
        //} 

        //public static void Print<T>(T a)
        //{
        //    //Console.WriteLine(a);
        //}

        // boxing
        // unboxing

        //static void Print<T>(T obj) where T : class,new()
        //{
        //    Console.WriteLine(obj);
        //}


        //static IEnumerable<int> GetNumbers()
        //{
        //    return new List<int> { 1, 2, 3, 4, 5, 6 };
        //}


        //static IEnumerable<int> GetNumbers()
        //{
        //    yield return 1;
        //    yield return 2;
        //    yield return 3;
        //    yield return 4;
        //    yield return 5;
        //    yield break;
        //}

        static void Main(string[] args)
        {
            Man man = new Man();

            //MyList<int> myList = new MyList<int>(new int[] { 1, 2, 3, 4, 5, 6, 7 });


            //foreach (var item in myList)
            //{
            //    Console.WriteLine(item);
            //}



            //var list = GetNumbers();

            //foreach (var item in list)
            //{
            //    Console.WriteLine(item);
            //}

            //   Print(5);
            //Print("5555");

            //   Print(new Person("Farid", "Abdullayev", 26));
            //    Print(5.5);



            //Person person = new Person("Farid", "Abdullayev", 26);
            //Person p = (Person)person.Clone();
            //p.Name = "Oleq";

            ////Person p = person;
            ////p.Name = "Oleq";

            //Console.WriteLine(person);






            //List<IFlyable> flyables = new List<IFlyable>();
            //flyables.Add(new Airplane());
            //flyables.Add(new Eagle(1, "Pticka"));





            //  Console.WriteLine(DateTime.Now.ToString("ddd, dd MMM yyy HH’:’mm’:’ss ‘GMT’"));

            //Console.WriteLine(DateTime.Now.ToLongDateString());
            //Console.WriteLine(DateTime.Now.Month);
            //Console.WriteLine(DateTime.Now.Year);
            //Console.WriteLine(DateTime.Now.AddDays(-4));
            //Console.WriteLine(DateTime.Now.DayOfWeek);

            //Console.WriteLine();




            ////Print(5);//value // boxing
            ////Print("5555");
            ////Print(5.5);

            //DateTime start = DateTime.Now;
            //for (int i = 0; i < 1000000000; i++)
            //{
            //    Print(5);
            //}
            //DateTime end = DateTime.Now;
            //Console.WriteLine(end - start);


            //Dog dog = new Dog(2, "Rex");
            //Cat cat = new Cat(9, 2, "Barsik");



            //Animal dog = new Dog(2, "Rex");
            //Animal cat = new Cat(9, 2, "Barsik");

            //List<Animal> animals = new List<Animal>();
            //animals.Add(dog);
            //animals.Add(cat);

            //foreach (var item in animals)
            //{
            //    item.Sound();
            //}


            //double a = default;

            //bool? hasDog = null;
            //Nullable<bool> hasDog1 = null;


            //Console.WriteLine(hasDog.HasValue);




            //var obj = new { Name="Farid",Surname="Abdullayev",Age = 26};
            //Console.WriteLine(obj.Name);






            //string name = "Farid";
            //Console.WriteLine(name);


            //Person p1 = null;
            //p1.Name = "Farid";

            //Console.WriteLine(p1.Name);





            // Tuple<int, string, double> tuple = new Tuple<int, string, double>(5, "Hi", 10.5);




            //(int,string,double)  x = (5, "Hi", 10.5);
            //var  x = (5, "Hi", 10.5);





            //Dictionary<string, Dictionary<string, string>> words = new Dictionary<string, Dictionary<string, string>>();

            //words["ru"] = new Dictionary<string, string>();
            //words["ru"]["один"] = "one";
            //words["ru"]["два"] = "two";
            //words["ru"]["три"] = "three";


            //words["en"] = new Dictionary<string, string>();
            //words["en"]["one"] = "один";
            //words["en"]["two"] = "два";
            //words["en"]["three"] = "три";


            //Console.WriteLine(words["ru"]["два"]);







            //var words = new Dictionary<string, string>()
            //{
            //    {"one", "один" },
            //    {"two", "два" },
            //    {"three", "три" }
            //};
            ////words.Add("one", "один");
            ////words.Add("two", "два");
            ////words.Add("three", "три");

            //Console.WriteLine(words["three"]);




            //Dictionary<int, Person> people = new Dictionary<int, Person>();
            //people.Add(0, new Person("Farid", "Abdullayev", 26));
            //people.Add(1, new Person("Farid", "Abdullayev", 26));
            //Console.WriteLine(people[0]);


            //если ключи то выбрасывает Exception

            //Dictionary<Person,int> people = new Dictionary<Person,int>();


            //Person p1 = new Person("Farid", "Abdullayev", 26);
            //Person p2 = new Person("Farid", "Abdullayev", 26);
            //Person p3 = new Person("Farid", "Abdullayev", 26);

            //people.Add(p1, 999);
            //people.Add(p2, 100);
            //people.Add(p3, 100);


            // Console.WriteLine(people[p1]);









            //Tuple<int, string> tuple = new Tuple<int, string>(1,"Hello");
            //Console.WriteLine(tuple.Item1);
            //Console.WriteLine(tuple.Item2);





            //var maxMin = MaxMin(new int[]{ 1,2,3,4,5,6});

            //Console.WriteLine(maxMin.Item1);
            //Console.WriteLine(maxMin.Item2);

            //Money money = new Money();
            //money.Dollar = 7;
            //money.Cent = 350;

            //Money money1 = new Money();
            //money1.Dollar = 7;
            //money1.Cent = 350;



            //Console.WriteLine(++money);  








            //if (money == money1)
            //{
            //    Console.WriteLine("Yes");
            //}
            //else
            //{
            //    Console.WriteLine("No");
            //}


            //Console.WriteLine(money);

            //Person person1 = new Person("Farid", "Abdullayev", 26);
            //Person person2 = new Person("Farid", "Abdullayev", 26);

            //if (person1.Equals(person2))
            //{
            //    Console.WriteLine("Yes");
            //}
            //else
            //{
            //    Console.WriteLine("No");
            //}


            //if (person1 == person2)
            //{
            //    Console.WriteLine("Yes");
            //}
            //else
            //{
            //    Console.WriteLine("No");
            //}



            //Dictionary<int, Person> people = new Dictionary<int, Person>();
            //people.Add(0, new Person("Farid", "Abdullayev", 26));
            //people.Add(1, new Person("Farid", "Abdullayev", 26));
            //Console.WriteLine(people[0]);


            // aa123af

            //Dictionary<int, int> people = new Dictionary<int, int>();
            //people.Add(0, 1);
            //people.Add(1, 1);

            //Console.WriteLine(people[0]);
            //Console.WriteLine(people[1]);

            //Point point1 = new Point();
            //point1.x = 10;
            //point1.y = 10;

            //Point point2 = new Point();
            //point1.x = 10;
            //point1.y = 10; 

            //if (point1 == point2)
            //{
            //    Console.WriteLine("Yes");
            //}
            //else
            //{
            //    Console.WriteLine("No");
            //}
        }
    }
}