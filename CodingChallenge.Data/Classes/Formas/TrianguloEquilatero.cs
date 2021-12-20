using System;

namespace CodingChallenge.Data.Classes.Formas
{
    public class TrianguloEquilatero : IForma
    {
        private decimal lado;

        public string ObtenerNombre()
        {
            return "TrianguloEquilatero";
        }

        public TrianguloEquilatero(decimal lado)
        {
            this.lado = lado;
        }

        public decimal CalcularArea()
        {

            return ((decimal)Math.Sqrt(3) / 4) * this.lado * this.lado;
        }

        public decimal CalcularPerimetro()
        {
            return this.lado * 3;
        }
    }
}