using System;
namespace RpgGamePOO.src.Entities.MythicalCreatures
{
    public class Hydra : MythicalCreature
    {
        public int numberOfHeads { get; set; }
         public override void SpecialAttack(int bonus)
        {
             Console.WriteLine($"{this.name} Usou um Attack Special de Bonus {(Math.Sqrt(bonus) + 5) * (level + (Math.Pow(numberOfHeads,3 ))) } com o elemento {this.Element}");
        }

        public override void SpecialDefense()
        {
            Console.WriteLine($"{this.name} Usou uma Defesa Especial e Cresceu a Quantidade de Cabeças");
            numberOfHeads+= (numberOfHeads + 1) * 3;
        }
        
    }
}