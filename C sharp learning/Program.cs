using System;
using System.Collections.Generic; //массив, списки.
using System.ComponentModel;
using System.Globalization;
using System.Net;

namespace C_sharp_learning
{
    abstract class Animal
     {
       public abstract string Name { get; set; }
       public Animal(string name)
        {
            Name = name;
        }
        public abstract void Print();     
    }

    class Dog :  Animal
    {
        private float speed;
        public override string Name { get; set; }
        
       public Dog(float speed, string name) : base(name)
        {
            this.speed = speed;                  
        }
        public override void Print()
        {           
            Console.WriteLine("Dog speed: " + speed);
        }
    }

    class Cat : Animal
    {
        public override string Name { get; set; }

        private float speed;
        public Cat(float speed, string name) : base(name)
        {
            this.speed = speed;

        }

        public override void Print()
        {         
            Console.WriteLine("Cat speed: " + speed);
        }
    }


    class MainClass
    {
        static void Main(string[] args) //метод срабатывает при старте программы
        {
            List<Animal> animals = new List<Animal>();
            animals.Add(new Dog(12.23f, "Alex"));
            animals.Add(new Dog(44.13f, "Sam"));
            animals.Add(new Cat(11.11f, "Godlike"));

            foreach (Animal animal in animals)
            {
                animal.Print();
            }
            Console.ReadKey();
        }
    }

}