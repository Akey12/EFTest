using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFTest.Models {
	public class Parent {

		[Key]
		public int Id { get;set; }
		public string Name { get;set; }

	}
}
