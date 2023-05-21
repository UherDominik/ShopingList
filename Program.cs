using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqNakupSeznam
{
	class Program
	{
		static void Main(string[] args)
		{

			string[] kategorie = { "ovoce a zelenina", "luštěniny", "pečivo", "mléčné výrobky", "maso", "sladkosti", "nápoje", "ostatní" };
			List<Polozka> polozky = new List<Polozka>();
			Polozka def = new Polozka("-");
			


			for (int i = 0; i < kategorie.Length; i++)
            {
				Console.WriteLine($"[{i}]: {kategorie[i]}");
            }
			Console.WriteLine("-------------------------------------");
			bool dalsiPolozka = true;
            while (dalsiPolozka)
            {
				Console.Write("Položka: ");
				string nazev = Console.ReadLine();
				Console.Write("Kategorie: ");
				int kat = int.Parse(Console.ReadLine());
				Console.Write("Přidat další položku [ano/ne]: ");
				string souhlasDalsi = Console.ReadLine();
				polozky.Add(new Polozka(nazev, kategorie[kat]));
				if (souhlasDalsi == "ne")
				{
					dalsiPolozka = false;
					Console.WriteLine("-------------------------------------");
				}
			}
			var dotaz = from j in kategorie
						join u in polozky on j equals u.Kategorie into ju
						select new { Kategorie = j , Polozky = ju.DefaultIfEmpty(def)};

			foreach (var skupina in dotaz)
			{
				Console.WriteLine();
				Console.Write($" {(skupina.Kategorie).ToUpper()}: ");
				foreach (var u in skupina.Polozky)
				{
					Console.Write(u.Nazev);
					
				}
				Console.WriteLine();

			}
		
			

		}
	}
}