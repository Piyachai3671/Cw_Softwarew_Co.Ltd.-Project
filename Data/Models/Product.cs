 using CW_ordermedicine.Data.DataModel;

namespace CW_ordermedicine.Data.Models
{
	
	public class Product
	{
		public int IDProduct { get; set; }  //IDรหัสสินค้า
		public string NameProduct { get; set; }	 //ชื่อ
		public int? RemainderProduct { get; set; } //สินค้าคงเหลือ
		public string? UnitProduct { get; set; } //หน่วย
		public string? StorageProduct { get; set; }	//สถานที่เก็บสินค้า
		public string? CompanyProduct { get; set; }  //บริษัทที่จำหน่าย
		public string? GroupProduct { get; set; } //กลุ่มสินค้า/รายละเอียด
		public string? LicensedProduct { get; set; }  //กลุ่มใบอนุญาติ	
		public double? PriceProduct { get; set; }  //ราคาปลีก
        public string? ImgProduct { get; set; } //รูป

		public Product() { }
		public Product ToUi(TableProduct tableProduct) //UI ไปเทเบิล
		{

			return new Product
			{
				IDProduct = tableProduct.IDProduct,
				NameProduct = tableProduct.NameProduct,
				RemainderProduct = tableProduct.RemainderProduct,
				UnitProduct = tableProduct.UnitProduct,
				StorageProduct = tableProduct.StorageProduct,
				PriceProduct = tableProduct.PriceProduct

			};

		}

		public TableProduct ToTable(Product NewProduct)
		{
			return new TableProduct
			{
				IDProduct = NewProduct.IDProduct,
				NameProduct = NewProduct.NameProduct,
				RemainderProduct = NewProduct.RemainderProduct,
				UnitProduct = NewProduct.UnitProduct,
				StorageProduct = NewProduct.StorageProduct,
				PriceProduct = NewProduct.PriceProduct
			};
		}
	}
}
