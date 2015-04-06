namespace IPv4ToNumber
{
	using System;

	internal class Program
	{
		private static void Main(string[] args)
		{
			// 255.255.255.255 = (2^32)-1 = uint

			long a = 255 * (long)Math.Pow(256, 3);	// Class A
			long b = 255 * (long)Math.Pow(256, 2);	// Class B
			long c = 255 * 256; 					// Class C		
			long d = 255; 							// Class D

			long ip = a + b + c + d;

			Console.WriteLine(ip);

			Console.ReadKey(true);
		}
	}
}