class Calculator
{
	static void Main(string[] args)
	{
		int a = 10;
		int b = 6;
		
		Console.WriteLine("HasilPenambahan: {0} + {1} = {2}", a, b, Penambahan(a, b));
		Console.WriteLine("HasilPengurangan: {0} - {1} = {2}", a, b, Penambahan(a, b));
		
		Console.WriteLine("\nTekan sembarang key untuk keluar");
		Console.ReadKey();
		
	}
	
	static int Penambahan (int a, int b)
	{
		return a + b;
	}
	
	static int Pengurangan(int a, int b)
	{
		return a - b;
	}
}