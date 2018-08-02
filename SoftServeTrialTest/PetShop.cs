using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftServeTrialTest
{
    public class PetShop : IEnumerable<Animal>
    {
        public PetShop()
        {
            _animal = new List<Animal>();
        }

        public void Add(Animal animal)
        {
            _animal.Add(animal);
        }

        public IEnumerator<Animal> GetEnumerator()
        {
           return _animal.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public void IntroduceAll()
        {
            foreach (var animal in _animal)
            {
                animal.Introduce();
            }
        }

        private readonly List<Animal> _animal;
    }
}
