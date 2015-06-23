using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EFTest.Context;
using EFTest.Models;

namespace EFTest {
	public class Program {
		public static void Main ( string[] args ) {
			using ( var db = new FamilyContext ( ) ) { 
				Console.WriteLine("Press enter to start:");
				Console.ReadLine();

				var parent = new Parent { Name = "LuLu"};
				var parent2 = new Parent {Name = "LaLa"};

				db.Parents.Add(parent);
				db.Parents.Add(parent2);
				db.SaveChanges();

				var child1 = new Child { Name = "Hehe", Parent = parent};
				var child2 = new Child { Name = "Haha", Parent = parent2};
				db.Children.Add(child1);
				db.Children.Add(child2);
				db.SaveChanges();

				var list = from b in db.Parents
						   select b;

				var childList = from b in db.Children
						        select b;

				Console.WriteLine(String.Format("There are {0} parents in the list", list.Count()));
				Console.WriteLine(String.Format("There are {0} children in the list", childList.Count()));
				Console.ReadLine();

			}
		}
	}
}
