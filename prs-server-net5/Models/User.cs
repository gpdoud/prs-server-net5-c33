using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace prs_server_net5.Models {

	public class User {

		public int Id { get; set; }
		[StringLength(30), Required]
		public string Username { get; set; }
		[StringLength(30), Required]
		public string Password { get; set; }
		[StringLength(30), Required]
		public string Firstname { get; set; }
		[StringLength(30), Required]
		public string Lastname { get; set; }
		[StringLength(12)]
		public string Phone { get; set; }
		[StringLength(255)]
		public string Email { get; set; }
		public bool IsReviewer { get; set; }
		public bool IsAdmin { get; set; }

		public virtual ICollection<Request> Requests { get; set; }

		public User() { }
	}
}