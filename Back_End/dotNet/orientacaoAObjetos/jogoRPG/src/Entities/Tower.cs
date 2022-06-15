namespace jogoRPG.src.Entities
{
    public class Tower : Hero
    {
        public Tower(string Name, int level, string heroType, int speed, int pass){
            this.Name = Name;
            this.level = level;
            this.heroType = heroType;
            this.speed = speed;
            this.pass = pass;
    }

    public override string Attack(){
            return this.Name + " " + "tira do Lomba, GOL! É o GOL DO TÍTULO!";}
}
}