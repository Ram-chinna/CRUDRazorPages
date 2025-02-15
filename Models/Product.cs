﻿using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace CRUDRazorPages.Models
{
	public class Product
	{
		[Key]
		public int Id { get; set; }
		[Required]
		[DisplayName("Product Name")]
		public string ProductName { get; set; }
		[Required]
		public double Price { get; set; }
		[Required]
		public int Qty { get; set; }
	}
}
