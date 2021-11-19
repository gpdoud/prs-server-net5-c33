using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace prs_server_net5.Models {

	public class Product {

		public int Id { get; set; }
		[StringLength(30), Required]
		public string PartNbr { get; set; }
		[StringLength(30), Required]
		public string Name { get; set; }
		[Column(TypeName = "decimal(11,2)")]
		public decimal Price { get; set; }
		[StringLength(30), Required]
		public string Unit { get; set; } = "Each";
		[StringLength(255)]
		public string PhotoPath { get; set; }

		public int VendorId { get; set; }
		public virtual Vendor Vendor { get; set; }
		[JsonIgnore]
		public virtual ICollection<Requestline> Requestlines { get; set; }

		public Product() { }
	}
}