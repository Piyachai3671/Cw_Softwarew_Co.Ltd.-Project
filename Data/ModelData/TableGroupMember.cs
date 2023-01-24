using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CW_ordermedicine.Data.ModelData
{
	[Table("GroupMember")]
	
	public class TableGroupMember
	{
		[Key]
		public int GroupID { get; set; }
		public string? GroupName { get; set; }
		public string? Department { get; set; }
		public int UserID { get; set; }
	}
}
