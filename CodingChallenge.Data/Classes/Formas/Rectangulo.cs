
namespace CodingChallenge.Data.Classes.Formas
{

    public class Rectangulo : IForma
    {

        private decimal largo;
        private decimal ancho;

        public Rectangulo(decimal largo, decimal ancho)
        {
            this.largo = largo;
            this.ancho = ancho;
        }

        public string ObtenerNombre()
        {
            return "Rectangulo";
        }

        public decimal CalcularArea()
        {
            return this.largo * this.ancho;
        }

        //P = 2 l + 2 a
        public decimal CalcularPerimetro()
        {
            return this.largo * 2 + this.ancho * 2;
        }
    }
}