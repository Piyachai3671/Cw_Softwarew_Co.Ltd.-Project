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
		public DateTime? OrderDateSuccess { get; set; }
		public DateTime? OrderDateCancel { get; set; }
		public string? OrderStatus { get; set; }

		/// <summary>
		/// ///////////////////////////////////////
		/// </summary>
		public int OrderUserID { get; set; }
		public string? OrderUsername { get; set; }

		public string? OrderDepartment { get; set; }

		public int OrderGroupID { get; set; }

		public Order()
		{ }
		public Order ToUi(TableOrder tableOrder) //UI ไปเทเบิล
		{

			return new Order
			{
				OrderID = tableOrder.OrderID,
				OrderSumPrice = tableOrder.OrderSumPrice,
				OrderDateCreate = tableOrder.OrderDateCreate,
				OrderDateSuccess = tableOrder.OrderDateSuccess,
				OrderDateCancel = tableOrder.OrderDateCancel,
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
				OrderDateSuccess = NewOrder.OrderDateSuccess,
				OrderDateCancel = NewOrder.OrderDateCancel,
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
