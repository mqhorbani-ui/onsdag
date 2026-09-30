using System;
using System.Collections.Generic;
using System.Text;

namespace OOPExercisesOnsdag
{
    public class Cat : Animal
    {
        // Implements the abstract member from Animal
        public override void MakeSound(bool isUnique)
        {
            if (isUnique)
                Console.WriteLine("Meow! (unique)");
            else
                Console.WriteLine("Meow!");
        }

        
    }
}
