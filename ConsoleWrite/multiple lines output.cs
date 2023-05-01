using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleWrite
{
    internal class multiple_lines_output : Data
    {
        public void Output1()
        {
            Console.WriteLine(
                  "ID: " + ID + "\n" +
                  "Name: " + Name + "\n" +
                  "Age: " + Age + "\n" +
                  "Num: " + Num + "\n" +
                  "Num2: " + Num2);
        }

        public void Output2()
        {
            Console.WriteLine(
                  $"ID: {ID}\n" +
                  $"Name: {Name}\n" +
                  $"Age: {Age}\n" +
                  $"Num: {Num}\n" +
                  $"Num2: {Num2}");
        }
    }
}