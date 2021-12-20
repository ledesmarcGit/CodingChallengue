namespace CodingChallenge.Data.Classes
{
    public class Traductor
    {
        private int idioma;

        #region Idiomas

        /*Castellano = 1;
          Ingles = 2;
          Frances = 3*/

        #endregion

        public Traductor(int idioma)
        {
            this.idioma = idioma;
        }


        public string ObtenerTraduccion(string palabras, bool singular = true)
        {
            string traduccion = string.Empty;

           if (this.idioma == 1)
           {
                return ObtenerTraduccionEspañol(palabras, singular);
            }
           else
               if (this.idioma == 2)
               {
                   return ObtenerTraduccionIngles(palabras, singular);
               }
                else
                    if (this.idioma == 3)
                    {
                      return ObtenerTraduccionFrances(palabras, singular);
                    }
                    else
                    {
                       return palabras;
                    }

        }

        private string ObtenerTraduccionEspañol(string palabras, bool singular = true)
        {
            if (singular)
            {
                switch (palabras)
                {
                    case "TrianguloEquilatero":
                        return "Triángulo Equilatero";
                    case "Circulo":
                        return "Círculo";
                    default:
                        return palabras;
                }
            }
            else
            {
                switch (palabras)
                {
                    case "Cuadrado":
                        return "Cuadrados";
                    case "TrianguloEquilatero":
                        return "Triángulos Equilateros";
                    case "Circulo":
                        return "Círculos";
                    case "Trapecio":
                        return "Trapecios";
                    case "Rectangulo":
                        return "Rectangulos";
                    default:
                        return ("No valido");
                }
            }
        }



        private string ObtenerTraduccionIngles(string palabras, bool singular = true)
        {
            if (singular){ 
                switch (palabras)
                {
                    case "Area":
                        return "Area";
                    case "Perimetro":
                        return "Perimeter";
                    case "Cuadrado":
                        return "Square";
                    case "TrianguloEquilatero":
                        return "Triangle";
                    case "Circulo":
                        return "Circle";
                    case "Trapecio":
                        return "Trapezoid";
                    case "Rectangulo":
                        return "Rectangle";
                    case "formas":
                        return "shapes";
                    case "Reporte de Formas":
                        return "Shapes report";
                    case "Lista vacía de formas":
                        return "Empty list of shapes";

                    default:
                        return ("No valido");
                }
            }
            else
            {
                switch (palabras)
                {
                    case "Cuadrado":
                        return "Squares";
                    case "TrianguloEquilatero":
                        return "Triangles";
                    case "Circulo":
                        return "Circles";
                    case "Trapecio":
                        return "Trapezoids";
                    case "Rectangulo":
                        return "Rectangles";
                    default:
                        return ("No valido");
                }
            }

        }


        private string ObtenerTraduccionFrances(string palabras, bool singular = true)
        {
            if (singular)
            {
                switch (palabras)
                {
                    case "Area":
                        return "Zone";
                    case "Perimetro":
                        return "Périmètre";
                    case "Cuadrado":
                        return "Carré";
                    case "TrianguloEquilatero":
                        return "Triangle équilatéral";
                    case "Circulo":
                        return "Cercle";
                    case "Trapecio":
                        return "Trapèze";
                    case "Rectangulo":
                        return "Rectangle";
                    case "formas":
                        return "formes";
                    case "Reporte de Formas":
                        return "Rapport de formulaires";
                    case "Lista vacía de formas":
                        return "Liste vide de formes";

                    default:
                        return ("Non valable");
                }
            }
            else
            {
                switch (palabras)
                {
                    case "Cuadrado":
                        return "Carrés";
                    case "TrianguloEquilatero":
                        return "Triangles équilatéral";
                    case "Circulo":
                        return "Cercles";
                    case "Trapecio":
                        return "Trapèzes";
                    case "Rectangulo":
                        return "Rectangles";
                    default:
                        return ("Non valable");
                }

            }

        }



    }
}
