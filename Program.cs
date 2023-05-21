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

			string[] categories = { "ovoce a zelenina", "luštěniny", "pečivo", "mléčné výrobky", "maso", "sladkosti", "nápoje", "ostatní" };
			List<Item> items = new List<Item>();
			Item def = new Item("-");
			


			for (int i = 0; i < categories.Length; i++)
            {
				Console.WriteLine($"[{i}]: {categories[i]}");
            }
			Console.WriteLine("-------------------------------------");
			bool nextItem = true;
            while (nextItem)
            {
				Console.Write("Položka: ");
				string name = Console.ReadLine();
				Console.Write("Kategorie: ");
				int category = int.Parse(Console.ReadLine());
				Console.Write("Přidat další položku [ano/ne]: ");
				string agreeNext = Console.ReadLine();
				items.Add(new Item(name, categories[category]));
				if (agreeNext == "ne")
				{
					nextItem = false;
					Console.WriteLine("-------------------------------------");
				}
			}
			var task = from j in categories
						join u in items on j equals u.Category into ju
						select new { Category = j , Items = ju.DefaultIfEmpty(def)};

			foreach (var group in task)
			{
				Console.WriteLine();
				Console.Write($" {(group.Category).ToUpper()}: ");
				foreach (var u in group.Items)
				{
					Console.Write(u.Name);
					
				}
				Console.WriteLine();

			}
		
			

		}
	}
}