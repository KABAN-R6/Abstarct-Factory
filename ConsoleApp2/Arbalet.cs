using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    class Arbalet : Wepon
    {
        public override void Hit()
        {
            Console.WriteLine("Стреляем из арбалета");
        }
    }
}
