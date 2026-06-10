using System;

namespace ProvaAIAutomation
{
    /// <summary>
    /// Classe per operazioni matematiche di base.
    /// </summary>
    public class Calcolatrice
    {
        /// <summary>
        /// Somma due numeri interi e restituisce il risultato.
        /// </summary>
        /// <param name="a">Primo numero intero.</param>
        /// <param name="b">Secondo numero intero.</param>
        /// <returns>La somma di a + b.</returns>
        public int Somma(int a, int b)
        {
            return a + b;
        }

        /// <summary>
        /// Somma due numeri decimali e restituisce il risultato.
        /// </summary>
        /// <param name="a">Primo numero decimale.</param>
        /// <param name="b">Secondo numero decimale.</param>
        /// <returns>La somma di a + b.</returns>
        public double Somma(double a, double b)
        {
            return a + b;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var calc = new Calcolatrice();
            
            int risultatoInteri = calc.Somma(5, 3);
            Console.WriteLine($"Somma interi 5 + 3 = {risultatoInteri}");
            
            double risultatoDecimali = calc.Somma(2.5, 3.7);
            Console.WriteLine($"Somma decimali 2.5 + 3.7 = {risultatoDecimali}");
        }
    }
}
