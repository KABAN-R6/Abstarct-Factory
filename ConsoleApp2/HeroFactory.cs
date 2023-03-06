using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    abstract class HeroFactory
    {
        public abstract Movement CreateMovement();
        public abstract Wepon CreateWeapon();
    }
}
