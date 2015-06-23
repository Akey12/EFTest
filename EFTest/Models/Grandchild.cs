using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFTest.Models {
	public class Grandchild {

		[Key]
		public int Id { get;set; }
		public string Name { get;set; }

		public virtual Child Parent { get;set; }
	
	}
}
