using CW_ordermedicine.Data.DataModel;
using CW_ordermedicine.Data.Models;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;

namespace CW_ordermedicine.Data.Services
{
	public class ProductService
	{
		private ApplicationContext _Context; //ประกาศเพื่อเรียกาารเช้าถึง DataBase
		public ProductService(ApplicationContext context)
		{
			_Context = context;
		}
		//private List<Product> Product = new List<Product>()
		//{
		//	new Product(){IDProduct = 1,NameProduct = "Oploid",RemainderProduct=10,UnitProduct="กล่อง",StorageProduct="CWpharmacy",CompanyProduct="CWcompany",GroupProduct = "รายละเอียด",LicensedProduct="12334656",PriceProduct = 200,ImgProduct="https://res.cloudinary.com/dk0z4ums3/image/upload/v1626773092/attached_image_th/opioidsinprescriptionbottle.jpg" },
		//	new Product(){IDProduct = 2,NameProduct = "dasadad",RemainderProduct=2,UnitProduct="กล่อง",StorageProduct="CWpharmacy",CompanyProduct="CWcompany",GroupProduct = "รายละเอียด",LicensedProduct="12334656",PriceProduct = 350,ImgProduct="https://www.nsm.or.th/nsm/sites/default/files/2021-12/shutterstock_674315233.jpg" },
		//	new Product(){IDProduct = 3,NameProduct = "Parasetamol",RemainderProduct=3,UnitProduct="กล่อง",StorageProduct="CWpharmacy",CompanyProduct="CWcompany",GroupProduct = "รายละเอียด",LicensedProduct="12334656",PriceProduct = 350,ImgProduct="https://www.nsm.or.th/nsm/sites/default/files/2021-12/shutterstock_674315233.jpg" },
		//	new Product(){IDProduct = 4,NameProduct = "Medic",RemainderProduct = 4,UnitProduct="กล่อง", StorageProduct="CWpharmacy",CompanyProduct="CWcompany",GroupProduct = "รายละเอียด",LicensedProduct="12334656",PriceProduct = 550 ,ImgProduct="https://th-live-01.slatic.net/p/a23d9fbbb491047e7db16ef9558972d8.png" },
		//	new Product(){IDProduct = 5,NameProduct = "Panadol",RemainderProduct = 5,UnitProduct="กล่อง", StorageProduct="CWpharmacy",CompanyProduct="CWcompany",GroupProduct = "รายละเอียด",LicensedProduct="12334656",PriceProduct = 920,ImgProduct="https://static.hdmall.co.th/system/image_attachments/images/000/123/572/original/Panadol_%28Paracetamol_500_g%29.jpg" },
		//	new Product(){IDProduct = 6,NameProduct = "Xeraphim",RemainderProduct = 6,UnitProduct="กล่อง", StorageProduct="CWpharmacy",CompanyProduct="CWcompany",GroupProduct = "รายละเอียด",LicensedProduct="12334656",PriceProduct = 700,ImgProduct="https://th-live-01.slatic.net/p/a23d9fbbb491047e7db16ef9558972d8.png" },
		//	new Product(){IDProduct = 7,NameProduct = "Tylenol500",RemainderProduct = 7,UnitProduct="กล่อง", StorageProduct="CWpharmacy",CompanyProduct="CWcompany",GroupProduct = "รายละเอียด",LicensedProduct="12334656",PriceProduct = 750,ImgProduct = "https://th-live-01.slatic.net/p/a23d9fbbb491047e7db16ef9558972d8.png" },
		//	new Product(){IDProduct = 8,NameProduct = "Sephera",RemainderProduct = 8,UnitProduct="กล่อง",StorageProduct="CWpharmacy",CompanyProduct="CWcompany",GroupProduct = "รายละเอียด",LicensedProduct="12334656",PriceProduct = 1220,ImgProduct="https://th-live-01.slatic.net/p/a23d9fbbb491047e7db16ef9558972d8.png" },
		//	new Product(){IDProduct = 9,NameProduct = "Argatha",RemainderProduct = 9,UnitProduct="กล่อง",StorageProduct="CWpharmacy",CompanyProduct="CWcompany",GroupProduct = "รายละเอียด",LicensedProduct="12334656",PriceProduct = 120,ImgProduct="https://th-live-01.slatic.net/p/a23d9fbbb491047e7db16ef9558972d8.png" },
		//	new Product(){IDProduct = 10,NameProduct = "Sepphairine",RemainderProduct = 10, UnitProduct = "กล่อง", StorageProduct="CWpharmacy",CompanyProduct = "CWcompany", GroupProduct = "รายละเอียด",LicensedProduct = "12334656", PriceProduct =680,ImgProduct="https://th-live-01.slatic.net/p/a23d9fbbb491047e7db16ef9558972d8.png" },
		//	new Product(){IDProduct = 11,NameProduct = "Moladol-XS",RemainderProduct = 11, UnitProduct = "กล่อง",StorageProduct="CWpharmacy", CompanyProduct = "CWcompany", GroupProduct = "รายละเอียด",LicensedProduct = "12334656", PriceProduct = 220,ImgProduct="https://th-live-01.slatic.net/p/a23d9fbbb491047e7db16ef9558972d8.png" },
		//	new Product(){IDProduct = 12,NameProduct = "Noncephaisive",RemainderProduct = 12, UnitProduct = "กล่อง", StorageProduct = "CWpharmacy", CompanyProduct = "CWcompany", GroupProduct = "รายละเอียด",LicensedProduct = "12334656", PriceProduct = 730,ImgProduct="https://th-live-01.slatic.net/p/a23d9fbbb491047e7db16ef9558972d8.png" },
		//	new Product(){IDProduct = 13,NameProduct = "Nocsive",RemainderProduct = 13, UnitProduct = "กล่อง", StorageProduct = "CWpharmacy", CompanyProduct = "CWcompany", GroupProduct = "รายละเอียด",LicensedProduct = "12334656", PriceProduct = 730,ImgProduct="https://th-live-01.slatic.net/p/a23d9fbbb491047e7db16ef9558972d8.png" },
		//	new Product(){IDProduct = 14,NameProduct = "Noncep",RemainderProduct = 14, UnitProduct = "กล่อง", StorageProduct = "CWpharmacy", CompanyProduct = "CWcompany", GroupProduct = "รายละเอียด",LicensedProduct = "12334656", PriceProduct = 730,ImgProduct="https://th-live-01.slatic.net/p/a23d9fbbb491047e7db16ef9558972d8.png" },

		//};
		//public async Task<List<Product>> GetProductsAsync()
		//{
		//	return await Task.FromResult(Product);
		//}


		public async Task<List<TableProduct>> GetProductsAsync()
		{
			var u = _Context.TableProduct.ToList();
			return await Task.FromResult(u);
		}
		//public void AddNewProduct(TableProduct NewProduct)
		//{
		//	_Context.TableProduct.Add(NewProduct);

		//	_Context.SaveChanges();//บันทึกลง SQL

		//}
		public void EditProduct(TableProduct EditProduct)
		{
			var FindID = _Context.TableProduct.First(e => e.IDProduct == EditProduct.IDProduct);
			FindID.RemainderProduct = EditProduct.RemainderProduct;

			
			_Context.TableProduct.Update(FindID);
			_Context.SaveChanges();//บันทึกลง SQL
		}

	}
}
