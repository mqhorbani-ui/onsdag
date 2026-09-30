using System;
using System.Collections.Generic;
using System.Text;

namespace OOPExercisesOnsdag
{



    public class Dog : Animal
    {
        public override void MakeSound(bool isUnique)
        {

            Console.WriteLine("Woof!");
        }

    }
}