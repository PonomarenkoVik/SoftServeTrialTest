using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftServeTrialTest
{
    public abstract class Animal
    {
        protected Animal(string name, string breed)
        {
            Name = name;
            Breed = breed;
        }
        public string Name { get; set; }
        public string Breed { get; set; }

        public virtual void Introduce()
        {
            Console.WriteLine("Name - {0}, breed - {1}", Name, Breed);
        }
    }
}
