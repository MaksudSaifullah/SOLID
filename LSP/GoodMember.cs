using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSP
{
    internal class GoodMember
    {
        //Why use abstract class here???? Why not Interface??
        //An abstract class allows you to create functionality that subclasses can implement or override.
        //An interface only allows you to define functionality, not implement it. And whereas a class can extend only one abstract class, it can take advantage of multiple interfaces.
        public abstract class Fruit
        {
            public abstract string GetColor();
        }
        public class Apple : Fruit
        {
            public override string GetColor()
            {
                return "Red";
            }
        }
        public class GreenApple : Apple
        {
            public override string GetColor()
            {
                return "Green Apple";
            }
        }
        public class RedApple : Apple
        {
            
        }
        public class Orange : Fruit
        {
            public override string GetColor()
            {
                return "Orange";
            }
        }
    }
}
