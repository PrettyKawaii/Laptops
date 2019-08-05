using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleForTasks
{
    class LaptopSystem
    {
        static List<Laptop> laptops = new List<Laptop>();

        static void Main(string[] args)
        {
            //Console.ForegroundColor = ConsoleColor.White;
            //Console.BackgroundColor = ConsoleColor.White;
            Inializer();

            for (int a = 0; ;)
            {
                Interface();
            }
        }

        public static void Interface()
        {
            Console.WriteLine(" Welcome to LaptopSystem.");
            Console.WriteLine(" Please, select, what would you like see.");
            Console.WriteLine(" 1 - view all laptops; 2 - turn on/off; 3 - add/delete laptop; 4 - exit;");
            string selection = Console.ReadLine();
            switch (selection)
            {
                case "1":
                    Console.WriteLine(" View all laptops");
                    OutputLaptops();
                    break;
                case "2":
                    Console.WriteLine(" Turn on/off");
                    TurnLaptops();
                    break;
                case "3":
                    Console.WriteLine(" Add/Delete laptop");
                    ManageLaptops();
                    break;
                case "4":
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine(" Unknowh choice");
                    break;
            }

        }

        public static Laptop SelectLaptop()
        {
            Console.WriteLine("Select laptop id.");
            OutputLaptops();
            int selection = Int32.Parse(Console.ReadLine());
            Laptop computer = laptops.Single(x=> x.id == selection);
            return computer;
        }


        public static void OutputLaptops()
        {
            foreach (Laptop item in laptops)
            {
                item.GetInfo();
            }
        }

        public static void OutputLaptopsDeletion()
        {
            foreach (Laptop item in laptops)
            {
                item.GetInfoDeletion();
            }
        }

        public static void ManageLaptops()
        {
            Console.WriteLine(" 1 - add laptop; 2 - delete laptop");
            string selection = Console.ReadLine();
            switch (selection)
            {
                case "1":
                    //Console.WriteLine(" Add laptop");
                    addLaptop();
                    break;
                case "2":
                    //Console.WriteLine(" Delete laptop");
                    deleteLaptop();
                    break;
                default:
                    Console.WriteLine(" Unknowh choice");
                    break;
            }
        }
        public static void addLaptop()
        {
            Console.Write(" Please, enter laptop mark:");
            string mark = Console.ReadLine();
            Console.Write(" Enter laptop model:");
            string model = Console.ReadLine();
            Console.Write(" Enter laptop backlight existence(true/false): ");
            string backlightS = Console.ReadLine();

            Laptop computer = new Laptop(mark, model);
            computer.backlight = backlightS == "true";
            computer.id = laptops.Count;
            laptops.Add(computer);
        }
        public static void deleteLaptop()
        {
            //0) Turn On\Off make as select lapton, then make action

            Console.WriteLine("Please, select laptop id for deletion.");
            Laptop computer = SelectLaptop();
            laptops.Remove(computer);
            Console.WriteLine("Deletion succesful.");
        }
        
        public static void TurnLaptops()
        {
            //Console.WriteLine(" Select laptop");
            //OutputLaptops();
            //string laptopSelection = Console.ReadLine();
            Laptop computer = SelectLaptop();
            Console.WriteLine(" 1 - turn on; 2 - turn off");
            string turnSelection = Console.ReadLine();
            switch (turnSelection)
            {
                case "1":   
                    computer.TurnOn();
                    break;
                case "2":
                    computer.TurnOff();
                    break;
                default:
                    Console.WriteLine("Unknown choice");
                    break;

            }
        }
        public static void Inializer()
        {
            Laptop computer1 = new Laptop();
            computer1.id = laptops.Count; ;
            computer1.mark = "Asus";
            computer1.model = "ZenBook";
            computer1.backlight = true;
            laptops.Add(computer1);

            Laptop computer2 = new Laptop();
            computer2.id = laptops.Count;
            computer2.mark = "Lenovo";
            computer2.model = "b120";
            laptops.Add(computer2);
        }
    }
}
