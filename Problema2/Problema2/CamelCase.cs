using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema2
{
   public class CamelCase
    {
        static void Main(string[] args)
        {//clase main donde se llama la clase calculate que contiene la funcion
            calculate calculate = new calculate();
            string prueba = "thisIsATestAndIHaveToProbeThatIsCorrectlyAndFunctioningGood";//string the prueba
            Console.WriteLine("La cadena original es: "+prueba);//imprime la cadena de ejemplo
            calculate.DisplayCamelCaseString(prueba);//se llama la funcion para que trabaje la prueba y realice la funcion para la que fue creada en este caso contar y separar el texto
            Console.ReadKey();
        }
       
    }
    public class calculate {
        public string DisplayCamelCaseString(string camelCase)//metodo publico para que pueda ser accesado por todas las instancias del priyecto
        {
            int cont = 1;
            List<char> caracterMayuscula = new List<char>();//hago una lista de tipo char para que el ciclo pase por cada caracter que haya en la variable
            caracterMayuscula.Add(camelCase[0]);
            foreach (char c in camelCase.Skip(1))//el ciclo inicia aqui para que evalue todo el string pero caracter por caracter y si encuentra
            {
                if (char.IsUpper(c))//un caracter en mayuscula añada un espacio y que agruegue uno al contador para que se lleve el control de las palabras
                {
                    caracterMayuscula.Add(' ');//añade el espacio antes de que continue otra mayuscula
                    cont=cont + 1;
                    caracterMayuscula.Add(char.ToUpper(c));
                }
                else
                    caracterMayuscula.Add(c);//si lo anterior no se cumple lo que realizaria es que continue recorriendo el string
            }
            Console.WriteLine("La cantidad de palabras es: "+cont);
            Console.WriteLine("La cadena de palabras es: " + new string(caracterMayuscula.ToArray()));
            return new string(caracterMayuscula.ToArray());//returna el nuevo string que en este caso seria ya separado por los espacios
  // escogi este metodo porque me parecio util usar las librerias genericas que trae ya el visual por lo que 
  //creo que es una solucion optima para dar un resultado favorable ademas es una solucion que busque en internet pero que
  //supe como es que la cosas pasan dentro del codigo, creo que es optima porque no hay que utilizar librerias ajenas a las que ya vienen
  //implicitas en c# ademas de ser una solucion sencilla de entender y que da un resultado favorable.
        }

    }
} 
