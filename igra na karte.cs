using System;
					
public class Program
{
	public static void Main()
	{
		int vrijednostKarte ,rezultat = 0;
		while (rezultat < 31){
			
		Console.WriteLine("Upisi vrijednost karte od 1-13");
		vrijednostKarte = Convert.ToInt32(Console.ReadLine());
		if(vrijednostKarte > 13 || vrijednostKarte < 1)
		{
			Console.WriteLine("Nisi upisao ispravnu vrijednost");
			continue;
		}
		else
		{ 
			rezultat += vrijednostKarte;
		}
		}
			if(rezultat == 31)
			{
				Console.WriteLine("Bodovi: "+ rezultat);
				Console.WriteLine("Pobjeda");
		}
		else {
		    Console.WriteLine("Bodovi: "+ rezultat);
			Console.WriteLine("Izgubili ste!");
		}
		
  }
}