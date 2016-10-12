using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema1
{
    class DiagonalDifference
    {
        static void Main(string[] args)
        {
            DiagonalDifference difference = new DiagonalDifference();
            string matriz = "11 2 4|4 5 6|10 8 -12";
            int aux = difference.matrix(matriz);
            Console.WriteLine("   ");
            Console.ReadKey();
        }

        public int matrix(string matriz)
        {
            matriz = "11 2 4|4 5 6|10 8 -12";
            string[] split = matriz.Split(new Char[] { '|', ' ','\t' });
            int raiz = Convert.ToInt32(Math.Sqrt(split.Length));
            int diagonalMayor = 0;
            int diagonalMenor = 0;
            
                  foreach (string s in split)
               {

                if (s.Trim() != " ") ;
                       
               }
            Console.WriteLine("El string es el siguiente: " + matriz);


            for (int i = 0; i < raiz; i++)//solo se necesita un ciclo ya que es un vector que se muestre como matriz pero en realidad solo se necesita un ciclo
            {

                diagonalMayor += Convert.ToInt32(split[(i * raiz) + i]);//variable donde el ciclo va a recorrer el y donde se cumpla la operacion y hace que almacene en la variable 
                //el elemento que haya en la posicion lo multiplica con el numero de la raiz que es el numero que salga dependiendo del tamano del vector
                diagonalMenor += Convert.ToInt32(split[(raiz * (i + 1) - 1) - i]);//iteracion similar a la anterior pero alrevez por eso realiza para obtener los elementos de la diagonal menor
                //Console.WriteLine("La diagonal Mayor es: " + split[(i * raiz) + i]);
                //Console.WriteLine("La diagonal Menor es: " + split[(raiz * (i + 1) - 1) - i]);
            }
            Console.WriteLine("La suma de la diagonal Mayor es: "+diagonalMayor);
            Console.WriteLine("La suma de la diagonal Menor es: " + diagonalMenor);
            Console.WriteLine("La resta de Diagonales es: " + (diagonalMayor - diagonalMenor));
            return diagonalMayor - diagonalMenor;
            //este codigo es optimo ya que solo realiza una funcion, no utiliza listas que lo harian mas confusos de lo normal, 
            //utiliza un ciclo para recorrer el vector y utiliza las mismas librerias que vienen por defecto al cargar el codigo.
            //Fue la solucion mas completa que pense y la que se me ocurrio realizar para resolver este problema.

        }
    }

}
