/*
 * Refactorear la clase para respetar principios de programación orientada a objetos. Qué pasa si debemos soportar un nuevo idioma para los reportes, o
 * agregar más formas geométricas?
 *
 * Se puede hacer cualquier cambio que se crea necesario tanto en el código como en los tests. La única condición es que los tests pasen OK.
 *
 * TODO: Implementar Trapecio/Rectangulo, agregar otro idioma a reporting.
 * */


/* Autor:Marcos Ledesma
   Fecha:20/12/2021
 *Para la correcta refactorizacion de la clase agrege una nueva interface llamada IForma, de la cual todas las formas deberan implementar los metodos que ahi se declaran.
 *Esto permite agregar nuevas formas geometricas facilmente, agregue en la carpeta Formas las clases que representan cada forma geometrica.
 *Elimine de FormaGeometrica.cs los metodos calcularArea y calcularPerimetro ya que estos son propios de cada forma.
 *Para la traduccion agregue una nueva clase llamada Traductor que sera la encargada de traducir nuestro reporte, si se desa agregar un nuevo idioma
 *solo deberemos agregar las palabras con su traduccion correcta.
 *Agregue una nueva clase llamada ContadorFormas la cual nos permite llevar los totales de cada forma agrupadas en un diccionario.
 *Modifique tambien los tests y agregue nuevos metodos para probar la implementacion de un nuevo idioma y de las formas Trapecio y Rectangulo.
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CodingChallenge.Data.Classes
{
    public class FormaGeometrica
    {

        #region Idiomas

        public const int Castellano = 1;
        public const int Ingles = 2;
        public const int Frances = 3;
        #endregion


        public static string Imprimir(List<IForma> formas, int idioma)
        {
            var sb = new StringBuilder();


            Traductor traductor = new Traductor(idioma);

            if (!formas.Any())
            {
               sb.Append("<h1>"+ traductor.ObtenerTraduccion("Lista vacía de formas")+"!</h1>");
            }
            else
            {
                // Hay por lo menos una forma
                // HEADER
                sb.Append("<h1>"+traductor.ObtenerTraduccion("Reporte de Formas")+"</h1>");
               
                Dictionary<String, ContadorFormas> dicFormas = new Dictionary<String, ContadorFormas>(); 


                foreach (IForma forma in formas)
                {
                    if (dicFormas.ContainsKey(forma.ObtenerNombre()))
                    {
                        dicFormas[forma.ObtenerNombre()].SumarCantidad(1);
                        dicFormas[forma.ObtenerNombre()].SumarPerimetro(forma.CalcularPerimetro());
                        dicFormas[forma.ObtenerNombre()].SumarArea(forma.CalcularArea());
                    }
                    else
                    {
                        ContadorFormas cont = new ContadorFormas(forma.CalcularArea(), forma.CalcularPerimetro());
                        dicFormas.Add(forma.ObtenerNombre(), cont);
                    }
                }

                decimal totalArea = 0;
                decimal totalPerimetro = 0;
                foreach (var forma in dicFormas) {

                    string nombreForma = traductor.ObtenerTraduccion(forma.Key, forma.Value.ObtenerCantidad() == 1);
                    string area = traductor.ObtenerTraduccion("Area");
                    string perimetro = traductor.ObtenerTraduccion("Perimetro");

                    string linea = $"{forma.Value.ObtenerCantidad()} {nombreForma} | {area} {forma.Value.ObtenerArea():#.##} | {perimetro} {forma.Value.ObtenerPerimetro():#.##} <br/>";
                    sb.Append(linea);
                    
                    totalArea += forma.Value.ObtenerArea();
                    totalPerimetro += forma.Value.ObtenerPerimetro();
                }

                // FOOTER
                sb.Append("TOTAL:<br/>");
                sb.Append(formas.Count + " " + traductor.ObtenerTraduccion("formas") + " ");
                sb.Append(traductor.ObtenerTraduccion("Perimetro") +" "+ totalPerimetro.ToString("#.##") + " ");
                sb.Append(traductor.ObtenerTraduccion("Area")+" " + totalArea.ToString("#.##"));
            }

            return sb.ToString();
        }
    
    }
}
