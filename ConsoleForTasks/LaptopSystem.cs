using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleForTasks
{

    class Laptop
    {
        public int id;
        public string mark;
        public string model;
        public bool backlight;
        public bool status; 

        public void TurnOn()
        {
            status = true;
            Console.Write($" Laptop was turned on.");
            Console.Read();
                    
            
        }

        public void TurnOff()
        {
            status = false;
            Console.Write($" Laptop was turned off.");
        }

        public Laptop(): this("not set", "not set") 
        {
        }

        public Laptop(string mark) : this()
        {
            this.mark = mark;
        }

        public Laptop(string model, string mark)
        {
            this.model = model;
            this.mark = mark;
        }
        //Названия полей
        //Чтобы 2й контсруктор вызывал 1й
        //Методы включения выключения ноута

        public void GetInfo()
        {
            Console.WriteLine($" Id: {id}; Mark: {mark}; Model: {model}; Backlight: {backlight}; Status: {status};");
        }
        public void GetInfoDeletion()
        {
            Console.WriteLine($" Id: {id}; Mark: {mark}; Model: {model};");
        }
    }
}
        