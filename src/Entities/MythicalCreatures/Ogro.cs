using System;
namespace RpgGamePOO.src.Entities.MythicalCreatures
{
    public class Ogro : MythicalCreature
    {
        public override void SpecialAttack(int bonus)
        {
             Console.WriteLine($"{this.name} Usou um Attack Special de Bonus {(bonus + 1) * (level + 1) } com o elemento {this.Element}");
        }

        public override void SpecialDefense()
        {
            Console.WriteLine($"{this.name} Usou uma Defesa Especial ");
        }
    }
}