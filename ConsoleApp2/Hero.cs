using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    class Hero
    {
        private Wepon weapon;
        private Movement movement;
        public Hero(HeroFactory factory)
        {
            weapon = factory.CreateWeapon();
            movement = factory.CreateMovement();
        }
        public void Run()
        {
            movement.Move();
        }
        public void Hit()
        {
            weapon.Hit();
        }
    }
}
