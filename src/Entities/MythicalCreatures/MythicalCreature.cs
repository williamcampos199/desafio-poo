namespace RpgGamePOO.src.Entities.MythicalCreatures
{
    public abstract class MythicalCreature
    {
        public string name { get; set; }
        public int level { get; set; }
        public string  CreatureType { get; set; }
        public string  Element { get; set; }


        public abstract void SpecialAttack(int bonus);

        public abstract void SpecialDefense();

        public override string ToString()
        {
            return $"Criatura Mitica {this.name} de Level {this.level} com Tipo {this.CreatureType}";
        }

    }
}