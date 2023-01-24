using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CW_ordermedicine.Data.DataModel
{
	[Table ("User")]
	public class TableUser
	{
		[Key]
		public int UserID { get; set; }

		public string? Name { get; set; }
		public string? Username { get; set; }
		public string? Password { get; set; }
		public string? Tel { get; set; }
		public string? Department { get; set; }

		public int GroupID { get; set; }
		public int UserImgid { get; set; }
		public string? UserImgName { get; set; }
		public string? UserPath { get; set; }
	}

}
