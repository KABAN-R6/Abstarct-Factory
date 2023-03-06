using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    class Sword : Wepon
    {
        public override void Hit()
        {
            Console.WriteLine("Бьем мечом");
        }
    }
}
