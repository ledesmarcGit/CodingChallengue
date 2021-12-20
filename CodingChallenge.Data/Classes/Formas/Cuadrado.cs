
namespace CodingChallenge.Data.Classes.Formas
{

    public class Cuadrado : IForma
    {

        private decimal lado;

        public Cuadrado(decimal lado)
        {
            this.lado = lado;
        }

        public string ObtenerNombre()
        {
            return "Cuadrado";
        }

        public decimal CalcularArea()
        {
            return this.lado * this.lado;
        }

        public decimal CalcularPerimetro()
        {
            return this.lado * 4;
        }
    }
}