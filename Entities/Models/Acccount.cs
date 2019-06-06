using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System;

namespace Entities.Models
{
	[Table("account")]
	public class Account
	{
		[Key]
        [Column("AccountID")]
		public int ID { get; set; }

		[Required(ErrorMessage = "Date created is required")]
		public DateTime DateCreated { get; set; }

		[Required(ErrorMessage = "Account type is required")]
		public string AccountType { get; set; }

		[Required(ErrorMessage = "Owner Id is required")]
		public int OwnerId { get; set; }
	}
}