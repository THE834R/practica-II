using System;

namespace Practica2
{
	class Program
	{
		public static void Main(string[] args)
		{

			double prod1, prod2, prod3, ivaprod1, ivaprod2, ivaprod3,  total;
			string linea;

				Console.Write("Ingresa el precio del primer producto \n");
				linea = Console.ReadLine ();
				prod1 = double.Parse (linea);

				Console.Write("Ingresa el precio del segundo producto\n");
				linea = Console.ReadLine ();
				prod2 = double.Parse (linea);

				Console.Write("Ingresa el precio del tercer producto\n");
				linea = Console.ReadLine ();
				prod3 = double.Parse (linea);


					ivaprod1 = prod1+(prod1 * 	.16);
					ivaprod2 = prod2+(prod2 * 	.16);
					ivaprod3 = prod3+(prod3 * 	.16);

					total = prod1+prod2+prod3;

				Console.Write("el precio del primer producto es: $ "+ prod1 +"  y con iva es: $"+ivaprod1+"\n\n");                   

				Console.Write("el precio del segundo producto es: $ "+ prod2 +"  y con iva es: $"+ivaprod2+"\n\n");                   

				Console.Write("el precio del tercer producto es: $ "+ prod3 +"  y con iva es: $"+ivaprod3+"\n\n");                   



			Console.ReadKey(true);
		}
	}
}