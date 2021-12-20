using System;

namespace CodingChallenge.Data.Classes.Formas
{

    public class Trapecio : IForma
    {

        private decimal baseMayor;
        private decimal baseMenor;
        private decimal altura;
        private decimal ladoIzq;
        private decimal ladoDer;



        public Trapecio(decimal baseMenor, decimal baseMayor, decimal altura, decimal ladoIzq, decimal ladoDer)
        {   //Dado que la principal característica de un trapecio es que tiene solo dos lados paralelos
            //se agrega la siguiente excepcion:

            if (baseMayor == baseMenor )
                throw new ArgumentException("Las bases no deben ser iguales");
            
            //Es posible que falten algunas excepciones por ejemplo si el usuario agrega bases y lados que no convergen en ningun punto 
            //pero creo que no son necesarios para este challengue            

            this.baseMayor = baseMayor;
            this.baseMenor = baseMenor;
            this.altura = altura;
            this.ladoIzq = ladoIzq;
            this.ladoDer = ladoDer;
        }

        public string ObtenerNombre()
        {
            return "Trapecio";
        }


        public decimal CalcularArea()
        {
            return (this.altura * ((this.baseMayor + this.baseMenor) / 2));
        }

        public decimal CalcularPerimetro()
        {            
            
            return this.baseMayor + this.baseMenor + this.ladoIzq + this.ladoDer;
        }
    }
}
