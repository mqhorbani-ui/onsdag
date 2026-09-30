using System;
using System.Collections.Generic;
using System.Text;

namespace OOPExercisesOnsdag
{
    public class Circle : Shape 
    {

        //Skapa subklasser Circle och Rectangle som skriver över GetArea() med enkla beräkningar.

        public override void GetArea()
        {
            double radius = 5; // Exempelvärde för radien
            double area = Math.PI * radius * radius;
            Console.WriteLine($"Area of the circle with radius {radius} is: {area}");
        }



    }
}
