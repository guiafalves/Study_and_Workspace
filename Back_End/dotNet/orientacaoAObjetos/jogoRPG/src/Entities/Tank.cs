namespace jogoRPG.src.Entities
{
    public class Tank : Hero
    {
        public Tank(string Name, int level, string heroType, int speed, int pass){
            this.Name = Name;
            this.level = level;
            this.heroType = heroType;
            this.speed = speed;
            this.pass = pass;
        }
                       public override string Attack(){
            return this.Name + " " + "Aplica lindo drible, e cruza.";}

            public string Attack(int Bonus){
                if (Bonus < 6){
                    return this.Name + " Perdeu a bola ";
                } else { 
                    return this.Name + " Aplicou a Cirineta";
                }
                }
            }
    }
