using System;

namespace RpgGamePOO.src.Entities.Heroes
{
    public class Hero
    {
        public string name { get; set; }
        public int level { get; set; }
        public string heroType { get; set; }

        public virtual void Attack()
        {
            Console.WriteLine($"{this.name } Atacou com os Punhos ");
        }

        public virtual void Defense()
        {
            Console.WriteLine($"{this.name} Defendeu");
        }

        public virtual void SpecialAttack(int bonus)
        {
            Console.WriteLine($"{this.name} Usou um Attack Special de Bonus {bonus * (level + 1) }");
        
        }

        public override string ToString()
        {
            return $"Heroi {this.name} de Level {this.level} com Tipo {this.heroType}";
        }

    }
}