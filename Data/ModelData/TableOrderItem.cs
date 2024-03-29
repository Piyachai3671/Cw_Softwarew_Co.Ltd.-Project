﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CW_ordermedicine.Data.ModelData
{
	[Table("OrderItem")]
	public class TableOrderItem
	{
		[Key]
		public int OrderItemID { get; set; }
		public int? OrderItemProductID { get; set; }
		public string? OrderItemProductName { get; set; }
		public int? OrderItemProductAmount { get; set; }
		public double? OrderItemProductPrice { get; set; }
		public double? OrderItemProductSumPrice { get; set; }
		public int? OrderItemOrderID { get; set; }
	}
}
