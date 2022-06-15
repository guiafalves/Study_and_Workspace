namespace jogoRPG.src.Entities
{
    public class Hero
    {
        public Hero(){

        }
        public Hero(string Name, int level, string heroType, int speed, int pass){
            this.Name = Name;
            this.level = level;
            this.heroType = heroType;
            this.speed = speed;
            this.pass = pass;
        }
        public string Name;
        public int level;
        public string heroType;
        public int speed;
        public int pass;

        public override string ToString(){
            return this.Name + " " + this.level + " " + this.heroType + " " + this.speed + " " + this.pass; 

        }

        public virtual string Attack(){
            return this.Name + " " + "Lançou em profundida, quebrando a linha adversária";
        }
    }
}