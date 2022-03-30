using System;

namespace RpgGamePOO.src.Entities.Heroes
{
    public class Ninja : Hero
    {
        public string  Bow { get; set; }

        public string Katana {get;set;}

        public override void Attack()
        {
             Console.WriteLine($"{this.name } Atacou com Sua Katana {this.Katana} e depois com seu Arco e Flecha {this.Bow} ");
        }
    }
}