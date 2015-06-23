using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EFTest.Models;

namespace EFTest.Context {
	public class FamilyContext : DbContext {

		public DbSet<Parent> Parents { get; set; }
		public DbSet<Child> Children { get; set; }
		public DbSet<Grandchild> GrandChildren { get; set; }
	}
}
