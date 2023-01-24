using CW_ordermedicine.Data.DataModel;
using CW_ordermedicine.Data.ModelData;
using CW_ordermedicine.Pages.OrderMedicine;

namespace CW_ordermedicine.Data.Models
{
	public class Order
	{
		public int OrderID { get; set; }
		public double OrderSumPrice { get; set; }
		public DateTime OrderDateCreate { get; set; }
		public string? OrderStatus { get; set; }

		/// <summary>
		/// ///////////////////////////////////////
		/// </summary>
		public int OrderUserID { get; set; }
		public string? OrderUsername { get; set; }

		public string? OrderDepartment { get; set; }

		public int OrderGroupID { get; set; }

		/// <summary>
		/// /////////////////////////////////////////////
		/// </summary>

		////เป็นการสร้าง Order ขึ้นมาเพื่อไม่ให้มันซ้ำกันเวลา ClearList ในตระกล้า
		//public int Cartid { get; set; }
		//public List<CartProduct> carts { get; set; }
		////public Order(List<CartProduct> carts)
		////{
		////	this.carts = new();
		////	carts.ForEach(i => this.carts.Add(i));
		////	//this.OrderPrice = this.carts.Sum(i =>i.PriceProduct * i.AmountProduct)??0.0;

		////}

		public Order()
		{ }
		public Order ToUi(TableOrder tableOrder) //UI ไปเทเบิล
		{

			return new Order
			{
				OrderID = tableOrder.OrderID,
				OrderSumPrice = tableOrder.OrderSumPrice,
				OrderDateCreate = tableOrder.OrderDateCreate,
				OrderStatus = tableOrder.OrderStatus,
				//ส่วนของรายละเอียดผู้ซื้อ
				OrderUserID = tableOrder.OrderUserID,
				OrderUsername = tableOrder.OrderUsername,
				OrderDepartment = tableOrder.OrderDepartment,
				OrderGroupID = tableOrder.OrderGroupID,
			};
		}

		public TableOrder ToTable(Order NewOrder)
		{
			return new TableOrder
			{
				OrderID = NewOrder.OrderID,
				OrderSumPrice = NewOrder.OrderSumPrice,
				OrderDateCreate = NewOrder.OrderDateCreate,
				OrderStatus = NewOrder.OrderStatus,
				//ส่วนของรายละเอียดผู้ซื้อ
				OrderUserID = NewOrder.OrderUserID,
				OrderUsername = NewOrder.OrderUsername,
				OrderDepartment = NewOrder.OrderDepartment,
				OrderGroupID = NewOrder.OrderGroupID,
			};
		}


	}
}
