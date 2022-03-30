using System;

namespace RpgGamePOO.src.Entities.Heroes
{
    public class Knight : Hero
    {
        public string sword { get; set; }

        public override void Attack()
        {
             Console.WriteLine($"{this.name } Atacou com Sua Espada {this.sword} ");
        }
    }
}