using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System;

namespace Entities.Models
{
	[Table("owner")]
	public class Owner : IEntity
    {
		[Key]
        [Column("OwnerID")]
		public int ID { get; set; }

		[Required(ErrorMessage = "Name is required")]
		[StringLength(60, ErrorMessage = "Name can't be longer than 60 characters")]
		public string Name { get; set; }

		[Required(ErrorMessage = "Date of birth is required")]
		public DateTime DateOfBirth { get; set; }

		[Required(ErrorMessage = "Address is required")]
		[StringLength(100, ErrorMessage = "Address cannot be loner then 100 characters")]
		public string Address { get; set; }
	}
}