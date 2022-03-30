using System;

namespace RpgGamePOO.src.Entities.Heroes
{
    public class Wizard : Hero
    {
        public string Staff { get; set; }
        public override void Attack()
        {
             Console.WriteLine($"{this.name } Lançou uma Magia com seu Cajado {this.Staff} ");
        } 
    }
}