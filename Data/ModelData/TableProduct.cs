using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CW_ordermedicine.Data.DataModel
{
	[Table("Product")]
	public class TableProduct
	{
		[Key]
		public int IDProduct { get; set; }  //IDรหัสสินค้า
		public string NameProduct { get; set; }  //ชื่อ
		public int? RemainderProduct { get; set; } //สินค้าคงเหลือ
		public string? UnitProduct { get; set; } //หน่วย
		public string? StorageProduct { get; set; } //สถานที่เก็บสินค้า
		
		public double? PriceProduct { get; set; }  //ราคาปลีก
		
	}
}
