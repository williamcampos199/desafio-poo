using System;

namespace RpgGamePOO.src.Entities.MythicalCreatures 
{
    public class Dragon : MythicalCreature
    {
        public override void SpecialAttack(int bonus)
        {
             Console.WriteLine($"{this.name} Usou Bafo de Fogo Bonus {(bonus) * (level)  } ");
        }

        public override void SpecialDefense()
        {
            Console.WriteLine($"{this.name} Usou uma Defesa Especial ");
        }
        
    }
}