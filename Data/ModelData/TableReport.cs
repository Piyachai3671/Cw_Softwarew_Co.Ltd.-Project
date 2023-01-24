using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CW_ordermedicine.Data.ModelData
{
	[Table("Report")]
	public class TableReport
	{
		[Key]
		public int ReportID { get; set; }
		public int? ReportUserID { get; set; }
		public string? ReportUserName { get; set; }

		public int? ReportOrderID { get; set; }
		public int? ReportOrderItemID { get; set; }
		public int? ReportGroupID { get; set; }
		public string ReportDepartment { get; set; }
		public double? ReportPriceSum { get; set; }
		public DateTime ReportDate { get; set; }
		public string? ReportStatus { get; set; }
	}
}
