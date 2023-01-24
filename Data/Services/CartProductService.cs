using CW_ordermedicine.Data.DataModel;
using CW_ordermedicine.Data.ModelData;
using CW_ordermedicine.Data.Models;
using CW_ordermedicine.Pages.OrderMedicine;

namespace CW_ordermedicine.Data.Services

{
    public class CartProductService
    {
		//private applicationcontext _context; //ประกาศเพื่อเรียกาารเช้าถึง database
		//public cartproductservice(applicationcontext context)
		//{
		//	_context = context;
		//}
		private List<CartProduct> carts = new List<CartProduct>()
		{

		};

		public async Task<List<CartProduct>> GetCartProductsAsync()
		{
			return await Task.FromResult(carts);
		}

		//public async Task<List<TableCartProduct>> GetCartProductsAsync()
		//{
		//	var u = _Context.TableCartProduct.ToList();
		//	return await Task.FromResult(u);
		//}
		//public void AddNewCartProduct(TableCartProduct NewCartProduct)
		//{
		//	_Context.TableCartProduct.Add(NewCartProduct);

		//	_Context.SaveChanges();//บันทึกลง SQL

		//}

	}

}
