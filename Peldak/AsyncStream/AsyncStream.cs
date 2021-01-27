using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AsyncStream
{
	public static class Program
	{
		public static async IAsyncEnumerable<int> SzamSor()
		{
			for (int i = 0; i <= 20; i++)
			{
				await Task.Delay(200);
				yield return i;
			}
		}

		static async Task Main(string[] args)
		{
			//Aszinkron bejárás
			await foreach (var szam in SzamSor())
			{
				Console.Write("{0}, ", szam);
			}
			Console.ReadKey();
		}
	}
}
