namespace CodingChallenge.Data.Classes
{
    public class ContadorFormas
    {
        private int Cantidad { get; set; }
        private decimal Area { get; set; }
        private decimal Perimetro { get; set; }

        public ContadorFormas(decimal area, decimal perimetro)
        {
            Cantidad = 1;
            Area = area;
            Perimetro = perimetro;
        }

        public void SumarCantidad(int cant)
        {
            this.Cantidad = this.Cantidad + cant;
        }

        public void SumarArea(decimal area)
        {
            this.Area = this.Area + area;
        }

        public void SumarPerimetro(decimal perimetro)
        {
            this.Perimetro = this.Perimetro + perimetro;
        }

        public int ObtenerCantidad()
        {
            return this.Cantidad;
        }

        public decimal ObtenerArea()
        {
            return this.Area;
        }

        public decimal ObtenerPerimetro()
        {
            return this.Perimetro;
        }


    }
}
