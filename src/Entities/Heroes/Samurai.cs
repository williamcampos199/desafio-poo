using System;

namespace RpgGamePOO.src.Entities.Heroes
{
    public class Samurai : Hero
    {
        public string katana { get; set; }
        public override void Attack()
        {
            base.Attack();
            Console.WriteLine($"{this.name } Atacou Novamente com sua  {this.katana} ");
        }
    }
}