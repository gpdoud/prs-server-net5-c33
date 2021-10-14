using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace prs_server_net5.Models {

	public class Request {

		public int Id { get; set; }
		[StringLength(80), Required]
		public string Description { get; set; }
		[StringLength(80), Required]
		public string Justification { get; set; }
		[StringLength(80)]
		public string RejectionReason { get; set; }
		[StringLength(30), Required]
		public string DeliveryMode { get; set; } = "Pickup";
		[StringLength(15), Required]
		public string Status { get; set; } = "NEW";
		[Column(TypeName = "decimal(11,2)")]
		public decimal Total { get; set; } = 0;

		public int UserId { get; set; }
		public virtual User User { get; set; }

		public virtual ICollection<Requestline> Requestlines { get; set; }

		public Request() { }
	}
}