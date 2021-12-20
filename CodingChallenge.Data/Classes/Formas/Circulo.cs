using System;

namespace CodingChallenge.Data.Classes.Formas
{
    public class Circulo : IForma
    {

        private decimal radio;
   
        public Circulo(decimal radio)
        {
            this.radio = radio;
        }

        public string ObtenerNombre()
        {
            return "Circulo";
        }

        //Area = Πr²
        public decimal CalcularArea()
        {
            return (decimal)Math.PI * this.radio * this.radio ;

        }

        public decimal CalcularPerimetro()
        {
            return (decimal)Math.PI * this.radio;
        }
    }
}