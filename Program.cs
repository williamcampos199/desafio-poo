using System;
using System.Collections.Generic;
using RpgGamePOO.src.Entities.Heroes;
using RpgGamePOO.src.Entities.MythicalCreatures;

namespace RpgGamePOO
{
    class Program
    {
        static void Main(string[] args)
        {
            Hero hero = new Hero()
            {
                name = "Alladin",
                level = 3,
                heroType  = "Heroi",
            };

            Cerberus cerberus = new Cerberus()
            {
                name = "Cão de 3 Cabeças",
                level = 7,
                CreatureType = "Cao de Fogo",
                Element = "Fogo",            
            };

            Hydra hydra = new Hydra()
            {
                name = "Hydra de Menelal",
                level = 3,
                CreatureType = "Cobra Aquatica",
                Element = "Agua",
                numberOfHeads = 1
                
            };

            Console.WriteLine(hero);
            Console.WriteLine(hydra);
            Console.WriteLine(cerberus);

        }
    }
}
