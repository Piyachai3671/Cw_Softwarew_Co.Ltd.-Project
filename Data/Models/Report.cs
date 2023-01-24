using CW_ordermedicine.Data.DataModel;
using CW_ordermedicine.Data.ModelData;

namespace CW_ordermedicine.Data.Models
{
	public class Report
	{
		public int ReportID { get; set; }

		public int? ReportUserID { get; set; }
		public string? ReportUserName { get; set; }

		public int? ReportOrderID { get; set; }
		public int? ReportOrderItemID { get; set; }
		public int? ReportGroupID { get; set; }
		public string? ReportDepartment { get; set; }
		public double? ReportPriceSum { get; set; }
		public string? ReportStatus { get; set; }
		public DateTime ReportDate { get; set; }

		public Report() { }
		public Report ToUi(TableReport tableReport) //UI ไปเทเบิล
		{

			return new Report
			{
				ReportID = tableReport.ReportID,
				ReportUserID = tableReport.ReportUserID,
				ReportUserName= tableReport.ReportUserName,

				ReportOrderID = tableReport.ReportOrderID,
				ReportOrderItemID = tableReport.ReportOrderItemID,
				ReportGroupID = tableReport.ReportGroupID,
				ReportDepartment = tableReport.ReportDepartment,
				ReportPriceSum = tableReport.ReportPriceSum,
				ReportDate = tableReport.ReportDate,
				ReportStatus = tableReport.ReportStatus,
			};

		}

		public TableReport ToTable(Report NewReport)
		{
			return new TableReport
			{
				ReportID = NewReport.ReportID,
				ReportUserID = NewReport.ReportUserID,
				ReportUserName = NewReport.ReportUserName,
				ReportOrderID = NewReport.ReportOrderID,
				ReportOrderItemID = NewReport.ReportOrderItemID,
				ReportGroupID = NewReport.ReportGroupID,
				ReportDepartment = NewReport.ReportDepartment,
				ReportPriceSum = NewReport.ReportPriceSum,
				ReportDate = NewReport.ReportDate,
				ReportStatus = NewReport.ReportStatus,
			};
		}
	}

}
	
