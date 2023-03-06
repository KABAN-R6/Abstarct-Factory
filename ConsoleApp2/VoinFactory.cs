using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    class VoinFactory : HeroFactory
    {
        public override Movement CreateMovement()
        {
            return new RunMovemetn();
        }

        public override Wepon CreateWeapon()
        {
            return new Sword();
        }
    }
}
