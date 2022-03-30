using System;

namespace RpgGamePOO.src.Entities.MythicalCreatures
{
    public class WereWolf : MythicalCreature
    {
        public bool fullMoon { get; set; }
         public override void SpecialAttack(int bonus)
        {
            if(fullMoon)
            {
                Console.WriteLine($"{this.name} Usou um Attack Special de Bonus {(bonus + 2) * (level + 3) } com o elemento {this.Element}");
            }
            else
            {
                Console.WriteLine($"{this.name} Usou um Attack Special de Bonus {(bonus) * (level) } com o elemento {this.Element}");
            }
             
        }

        public override void SpecialDefense()
        {
            Console.WriteLine($"{this.name} Usou uma Defesa Especial ");
        }
        
    }
}