using CW_ordermedicine.Data.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CW_ordermedicine.Data.ModelData
{
	[Table("Order")]
	public class TableOrder
	{
		[Key]
		public int OrderID { get; set; }

		public double OrderSumPrice { get; set; }
		public int OrderUserID { get; set; }
		public string? OrderUsername { get; set; }
		public string? OrderDepartment { get; set; }
		public int OrderGroupID { get; set; }

		public DateTime OrderDateCreate { get; set; }
		public DateTime? OrderDateSuccess { get; set; }
		public DateTime? OrderDateCancel { get; set; }
		public string OrderStatus { get; set; }

	}
}



