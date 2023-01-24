using CW_ordermedicine.Data.DataModel;
using CW_ordermedicine.Data.ModelData;
using System.ComponentModel.DataAnnotations;

namespace CW_ordermedicine.Data.Models
{
	public class CartProduct
	{

		public int Cartid { get; set; }
		public int? IDProduct { get; set; }  //ชื่อ
		public int? OrderID { get; set; }  //ชื่อ
		public string? NameProduct { get; set; }  //ชื่อ
		public int? AmountProduct { get; set; } //สินค้าคงเหลือ

		public string? UnitProduct { get; set; } //หน่วย
		public double? PriceProduct { get; set; }  //ราคาปลีก
		public double? SumPriceProduct { get; set; }  //ราคาปลีก

		public CartProduct() { }
		public CartProduct ToUi(TableCartProduct tableCartProduct) //UI ไปเทเบิล
		{

			return new CartProduct
			{
				Cartid = tableCartProduct.Cartid,
				IDProduct = tableCartProduct.IDProduct,
				OrderID = tableCartProduct.OrderID,
				NameProduct = tableCartProduct.NameProduct,
				AmountProduct = tableCartProduct.AmountProduct,
				UnitProduct = tableCartProduct.UnitProduct,
				PriceProduct = tableCartProduct.PriceProduct,
				SumPriceProduct = tableCartProduct.SumPriceProduct,
			};

		}

		public TableCartProduct ToTable(CartProduct NewCartProduct)
		{
			return new TableCartProduct
			{
				Cartid = NewCartProduct.Cartid,
				IDProduct = NewCartProduct.IDProduct,
				OrderID = NewCartProduct.OrderID,
				NameProduct = NewCartProduct.NameProduct,
				AmountProduct = NewCartProduct.AmountProduct,
				UnitProduct = NewCartProduct.UnitProduct,
				PriceProduct = NewCartProduct.PriceProduct,
				SumPriceProduct = NewCartProduct.SumPriceProduct,
			};
		}
	}
}
