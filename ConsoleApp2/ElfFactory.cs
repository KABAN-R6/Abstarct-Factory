using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    class ElfFactory : HeroFactory
    {
        public override Movement CreateMovement()
        {
            return new FlyMovement();
        }

        public override Wepon CreateWeapon()
        {
            return new Arbalet();
        }
    }
}
