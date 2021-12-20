namespace CodingChallenge.Data.Classes
{
    /// Interface base que define los metodos que debe implementar una nueva forma geometrica 

    public interface IForma
    {

        decimal CalcularArea();
        decimal CalcularPerimetro();
        string ObtenerNombre();
    }

}