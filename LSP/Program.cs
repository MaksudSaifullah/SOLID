using System;
using static LSP.BadMember;
using static LSP.GoodMember;

namespace LSP
{
    class Program
    {
        static void Main(string[] args)
        {
            // Bad member is calling...
            BadMember.Orange apple = new BadMember.Orange();
            Console.WriteLine(apple.GetColor());
            Console.WriteLine();

           // BadMember.Apple apple1 = new BadMember.Orange();
            
            // Good member is calling...
            Fruit fruit = new GoodMember.Orange();
            Console.WriteLine(fruit.GetColor());
            fruit = new GoodMember.Apple();
            Console.WriteLine(fruit.GetColor());

            fruit = new GoodMember.Apple();
            Console.WriteLine(fruit.GetColor());

        }
    }
}
