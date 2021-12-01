using System;
using System.Text.RegularExpressions;

namespace KebabCase
{
    class Program
    {
    static void Main(string[] args)
        {
            Console.WriteLine("Escriba el texto a convertir \n");
            string value = Console.ReadLine();
      
            // Reemplaza con DASH
            value = Regex.Replace(value, @"[^0-9a-zA-Z]", "-");

            // Elimina dashes consecutivos
            value = Regex.Replace(value, @"[-]{2,}", "-");

            // Remueve los dashes del final
            value = Regex.Replace(value, @"-+$", string.Empty);

            // Remueve dashes al inicio
            if (value.StartsWith("-")) value = value.Substring(1);

              //Lowercase 
            value=value.ToLower(); 
            Console.WriteLine("To Kebab Case: "+value);

        }
    }
}
