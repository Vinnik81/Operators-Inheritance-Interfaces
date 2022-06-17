using System;
using System.Collections;
using System.Collections.Generic;
//using static HomeWork_5.Devices;

namespace HomeWork_5
{
    //Task 1
    /*public class Money
     {
         private int cent;
         public int Dolar { get; set; }
         public int Cent
         {
             get => cent;
             set
             {
                 if (value >= 100)
                 {
                     Dolar += value / 100;
                     cent = value % 100;
                 }
                 else cent = value;
             }
         }
         public Money(int dolar, int cent)
         {
             this.Dolar = dolar;
             this.Cent = cent;
         }
         public static Money operator +(Money a, Money b)
         {
             int centSum = a.Cent + b.Cent;
             int dolar = a.Dolar + b.Dolar + centSum / 100;
             int cent = centSum % 100;
             return new Money(dolar, cent);
         }
         public  static Money operator -(Money a, Money b)
         {

             int centSale = a.Cent - b.Cent;
             int dolar = a.Dolar - b.Dolar - centSale / 100;
             int cent = centSale % 100;
             return new Money(dolar, cent);
         }
         public virtual void Print()
         {
             Console.WriteLine($"{Dolar}$, {Cent}cent");
         }

         public class Product : Money
         {
             string name;

             public Product(int dolar, int cent, string name): base(dolar, cent)
             {
                 this.name = name;
             }

             public override void Print()
             {
                 base.Print();
                 Console.WriteLine($"Название продукта: {name}");
             }
         }
     }*/
    //Task 2
    /* public class Devices
      {
          string name;
          string sound;
          string typename;
          string color;
          double height;
          double width;
          public Devices(string Name, string Sound, string Typename, string Color,  double Height, double Width)
          {
              name = Name;
              sound = Sound;
              typename = Typename;
              color = Color;
              height = Height;
              width = Width;
          }
          public virtual void Sound()
          {
              Console.WriteLine($"Устойство {name} издаёт звук {sound}");
          }
          public virtual void Show()
          {
              Console.WriteLine($"Название устройства: {name}");
          }
          public virtual void Desc()
          {
              Console.WriteLine($"Описание устройства {name}: \nпринадлежность {typename}, \nцвет {color}, \nдлинна {height} м, \nширина {width} м.");
          }
         public class Kettle: Devices
          {
              string type;
              int volume;
              public Kettle
                  (
                  string Type, int Volume, string Name, string Sound, string Typename, string Color, double Height, double Width 
                  ) : base(Name, Sound, Typename, Color, Height, Width)
              {
                  type = Type;
                  volume = Volume;
              }
              public override void Sound()
              {
                  base.Sound();
                  Console.Write(" Свист.");
              }
              public override void Show()
              {
                  base.Show();
                  Console.WriteLine($"тип {type}");
              }
              public override void Desc()
              {
                  base.Desc();
                  Console.WriteLine($"обём чайника {volume} литр.");
              }
          }
          public class Microwave: Devices
          {
              string typemic;
              int volumemic;
              public Microwave
                  (
                  string Typemic, int Volumemic, string Name, string Sound, string Typename, string Color, double Height, double Width
                  ) : base(Name, Sound, Typename, Color, Height, Width)
              {
                  typemic = Typemic;
                  volumemic = Volumemic;
              }
              public override void Sound()
              {
                  base.Sound();
                  Console.Write(" Дзинь.");
              }
              public override void Show()
              {
                  base.Show();
                  Console.WriteLine($"тип {typemic}");
              }
              public override void Desc()
              {
                  base.Desc();
                  Console.WriteLine($"обём микроволновки {volumemic} литр.");
              }
          }
          public class Car: Devices
          {
              string typecar;
              int volumecar;
              int power;
              public Car
                  (
                  string Typecar, int Volumecar, int Power, string Name, string Sound, string Typename, string Color, double Height, double Width
                  ) : base(Name, Sound, Typename, Color, Height, Width)
              {
                  typecar = Typecar;
                  volumecar = Volumecar;
                  power = Power;
              }
              public override void Sound()
              {
                  base.Sound();
                  Console.Write(" Бип.");
              }
              public override void Show()
              {
                  base.Show();
                  Console.WriteLine($"тип {typecar}");
              }
              public override void Desc()
              {
                  base.Desc();
                  Console.WriteLine($"обём двигателя {volumecar} куб.дм., \nмощность двигателя {power} л.с.");
              }
          }
          public class Steamship: Devices
          {
              string typest;
              string mover;
              int powership;
              public Steamship
                  (
                  string Typest, string Mover, int Powership, string Name, string Sound, string Typename, string Color, double Height, double Width
                  ) : base(Name, Sound, Typename, Color, Height, Width)
              {
                  typest = Typest;
                  mover = Mover;
                  powership = Powership;
              }
              public override void Sound()
              {
                  base.Sound();
                  Console.Write(" Туту.");
              }
              public override void Show()
              {
                  base.Show();
                  Console.WriteLine($"тип {typest}");
              }
              public override void Desc()
              {
                  base.Desc();
                  Console.WriteLine($"тип движителя {mover}, \nмощность двигателя {powership} кВт.");
              }
          }
      }*/
    //Task 3
    /* public class MusicalInstruments
     {
         string name;
         public MusicalInstruments(string Name)
         {
             name = Name;
         }
         public virtual void Sound()
         {
             Console.WriteLine($"Музыкальный инструмент {name} издаёт звук: ");
         }
         public virtual void Show()
         {
             Console.Write($"Музыкальный инструмент {name}");
         }
         public virtual void Desc()
         {
             Console.WriteLine($"Тип инструмента {name}: ");
         }
         public virtual void History()
         {
             Console.WriteLine($"История создания инструмента {name}:");
         }
     }
     public class Violin: MusicalInstruments
     {
         string typeV;
         string soundV;
         string historyV;
         public Violin(string TypeV, string SoundV, string HistoryV, string Name): base(Name)
         {
             typeV = TypeV;
             soundV = SoundV;
             historyV = HistoryV;
         }
         public override void Sound()
         {
             base.Sound();
             Console.Write($"{soundV}");
         }
         public override void Show()
         {
             base.Show();
             Console.WriteLine();
         }
         public override void Desc()
         {
             base.Desc();
             Console.Write($"{typeV}");
         }
         public override void History()
         {
             base.History();
             Console.WriteLine($"{historyV}");
         }
     }
     public class Trombone: MusicalInstruments
     {
         string typeT;
         string soundT;
         string historyT;
         public Trombone(string TypeT, string SoundT, string HistoryT, string Name) : base(Name)
         {
             typeT = TypeT;
             soundT = SoundT;
             historyT = HistoryT;
         }
         public override void Sound()
         {
             base.Sound();
             Console.Write($"{soundT}");
         }
         public override void Show()
         {
             base.Show();
             Console.WriteLine();
         }
         public override void Desc()
         {
             base.Desc();
             Console.Write($"{typeT}");
         }
         public override void History()
         {
             base.History();
             Console.WriteLine($"{historyT}");
         }
     }
     public class Ukulele: MusicalInstruments
     {
         string typeU;
         string soundU;
         string historyU;
         public Ukulele(string TypeU, string SoundU, string HistoryU, string Name) : base(Name)
         {
             typeU = TypeU;
             soundU = SoundU;
             historyU = HistoryU;
         }
         public override void Sound()
         {
             base.Sound();
             Console.Write($"{soundU}");
         }
         public override void Show()
         {
             base.Show();
             Console.WriteLine();
         }
         public override void Desc()
         {
             base.Desc();
             Console.Write($"{typeU}");
         }
         public override void History()
         {
             base.History();
             Console.WriteLine($"{historyU}");
         }
     }
     public class Violoncello: MusicalInstruments
     {
         string typeC;
         string soundC;
         string historyC;
         public Violoncello(string TypeC, string SoundC, string HistoryC, string Name) : base(Name)
         {
             typeC = TypeC;
             soundC = SoundC;
             historyC = HistoryC;
         }
         public override void Sound()
         {
             base.Sound();
             Console.Write($"{soundC}");
         }
         public override void Show()
         {
             base.Show();
             Console.WriteLine();
         }
         public override void Desc()
         {
             base.Desc();
             Console.Write($"{typeC}");
         }
         public override void History()
         {
             base.History();
             Console.WriteLine($"{historyC}");
         }
     }*/
    //Task 4
    public abstract class Worker
    {
        string firstName;
        string lastName;
        DateTime birthDate;
        public Worker(string FirstName, string LastName, DateTime date)
        {
            firstName = FirstName;
            lastName = LastName;
            birthDate = date;
        }
        public abstract void Working();
        public virtual void Print()
        {
            Console.WriteLine($"Фамилия: {lastName} \nИмя: {firstName} \nДата рождения: {birthDate.ToLongDateString()}");
        }
    }
    public class President: Worker
    {
        int salaryP;
        public President(int SalaryP, string FirstName, string LastName, DateTime date): base(FirstName, LastName, date)
        {
            salaryP = SalaryP;
        }
        public override void Working()
        {
            Console.WriteLine("Я управляю предприятием.");
        }
        public override void Print()
        {
            base.Print();
            Console.WriteLine($"Зароботна плата: {salaryP} руб.");
        }
    }
    public class Security: Worker
    {
        int salaryS;
        public Security(int SalaryS, string FirstName, string LastName, DateTime date): base(FirstName, LastName, date)
        {
            salaryS = SalaryS;
        }
        public override void Working()
        {
            Console.WriteLine("Я охраняю предприятие.");
        }
        public override void Print()
        {
            base.Print();
            Console.WriteLine($"Зароботна плата: {salaryS} руб.");
        }
    }
    public class Manager: Worker
    {
        int salaryM;
        public Manager(int SalaryM, string FirstName, string LastName, DateTime date): base(FirstName, LastName, date)
        {
            salaryM = SalaryM;
        }
        public override void Working()
        {
            Console.WriteLine("Я руковожу рабочими.");
        }
        public override void Print()
        {
            base.Print();
            Console.WriteLine($"Зароботна плата: {salaryM} руб.");
        }
    }
    public class Engineer: Worker
    {
        int salaryE;
        public Engineer(int SalaryE, string FirstName, string LastName, DateTime date): base(FirstName, LastName, date)
        {
            salaryE = SalaryE;
        }
        public override void Working()
        {
            Console.WriteLine("Я разрабатываю устройства.");
        }
        public override void Print()
        {
            base.Print();
            Console.WriteLine($"Зароботна плата: {salaryE} руб.");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //Task 1
            /* Money.Product product = new Money.Product(3, 20, "Торт");
             product.Print();
             Money.Product product1 = new Money.Product(10, 50, "Коньяк");
             product1.Print();
             Console.WriteLine("Ощая сумма равна: ");
             Money money = product + product1;
             money.Print();
             Console.WriteLine("Введите скидку: ");
             int dolar = int.Parse(Console.ReadLine());
             int cent = int.Parse(Console.ReadLine());
             Money money1 = new Money(dolar, cent);
             Money sale = money - money1;
             sale.Print();*/

            //Task 2
            /* Devices[] devices =
             {
                 new Kettle("Электрический", 2, "Чайник", "", "Бытовая техника", "Серый", 0.02, 0.01),
                 new Microwave("Электронное", 6, "Микроволновка", "","Бытовая техника", "Серебристый", 0.04, 0.02),
                 new Car("Сидан", 10, 120, "Lada Vesta", "", "сухопутный транспорт", "Аквамарин", 5.0, 2.2),
                 new Steamship("Сухогруз", "Винтовые", 1500, "Пароход", "", " водный транспорт", "Белый", 60, 10)
             };
             foreach (Devices item in devices)
             {
                 item.Show();
                 item.Sound();
                 Console.WriteLine();
                 item.Desc();
                 Console.WriteLine();
             }*/

            //Task 3
            /* MusicalInstruments[] instruments =
             {
                 new Violin("Смычковый", "Скрипка", 
                 "Скрипка - один из наиболее распространенных и совершенных музыкальных инструментов нашего времени. Появилась она в конце XV века. По своему происхождению скрипка - народный инструмент.",
                 "Violin"),
                 new Trombone("Духовой", "Трамбон", "Появление тромбона относится к XV веку. Принято считать, что непосредственными предшественниками этого инструмента были кулисные трубы, при игре на которых у музыканта была возможность передвигать трубку инструмента.",
                 "Trombone"),
                 new Ukulele("Струнный", "Укулеле", " “Укулеле” – миниатюрная четырехугольная гитара, изобретенная в Португалии ориентировочно в 1886 году.", "Ukulele"),
                 new Violoncello("Смычковый", "Виолончель", "Появление виолончели относится к кону XV и началу XVI века в результате длительного развития народных смычковых инструментов. Первоначально она применялась как басовый инструмент в различных ансамблях.",
                 "Violoncello")
             };
             foreach (MusicalInstruments item in instruments)
             {
                 item.Show();
                 item.Sound();
                 Console.WriteLine();
                 item.Desc();
                 Console.WriteLine();
                 item.History();
             }*/

            //task 4
            Worker[] worker =
            {
                new President(350000, "Парфирий", "Лидман", new DateTime(1975, 2, 09)),
                new Security(22000, "Алексей", "Нежданов", new DateTime(1993, 5, 01)),
                new Manager(120000, "Никита", "Плющ", new DateTime(1998, 10, 28)),
                new Engineer(35000, "Вадим", "Токарев", new DateTime(1980, 11, 12))
            };
            foreach (Worker item in worker)
            {
                item.Print();
                item.Working();
            }
        }
    }
}
