using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CW_ordermedicine.Data.ModelData
{
	[Table("CartProduct")]
	public class TableCartProduct
	{
		[Key]
		public int Cartid { get; set; }
		public int? IDProduct { get; set; }  //ชื่อ
		public int? OrderID { get; set; }  //ชื่อ
		public string? NameProduct { get; set; }  //ชื่อ
		public int? AmountProduct { get; set; } //สินค้าคงเหลือ

		public string? UnitProduct { get; set; } //หน่วย
		public double? PriceProduct { get; set; }  //ราคาปลีก
		public double? SumPriceProduct { get; set; }  //ราคาปลีก
	}
}
