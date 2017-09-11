using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace AsyncAwait
{
	class Program
	{
		static void Main(string[] args)
		{

			var file = new System.IO.FileStream("./MiArchivo.bin",FileMode.OpenOrCreate);


			Console.WriteLine("Antes de crear");
			

			procesarArchivo(file);
			procesarArchivoAsync(file);

			Console.WriteLine("Despues de crear");
			Console.ReadLine();

		}

		private static async void procesarArchivoAsync(FileStream file)
		{
			var msg = "Hola Mundo";
			var bytes = Encoding.UTF8.GetBytes(msg);

			Console.WriteLine("Escribiendo Async ...");
			for (int i = 0; i <= 10000; i++)
			{


				await file.WriteAsync(bytes, 0, bytes.Length);

			}

			Console.WriteLine("Ya escribío Async ...");
			file.Close();
		}


		private static void procesarArchivo(FileStream file)
		{
			var msg = "Hola Mundo";
			var bytes=Encoding.UTF8.GetBytes(msg);

			Console.WriteLine("Escribiendo ...");
			for (int i = 0; i <= 10000; i++) {

				file.Write(bytes,0,bytes.Length);
			}
			Console.WriteLine("Escribiendo ...");
			//file.Close();
		}


	}
}
