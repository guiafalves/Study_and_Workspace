using static System.Console;

namespace ExemploPOO.Models
{
    public class  rectangle
    {
        private double length;
        private double width;
        private bool real;

        public void measurements(double width, double length)
        {
            if (width > 0 && length > 0)
            { 
            this.width = width;
            this.length = length;
            real = true;
            }
            else
            { 
                WriteLine("Valores inválidos!");
            }
        
        }
        public double getArea()
        {
            if (real)
            {
                return width * length;
            }
            else{
                WriteLine("Preencha valores válidos.");
                return 0;
            }
        }
    }
}