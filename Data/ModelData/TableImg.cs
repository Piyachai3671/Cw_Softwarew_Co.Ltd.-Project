using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CW_ordermedicine.Data.ModelData
{
	[Table("Img")]
	public class TableImg
	{
		[Key]
		public int Imgid { get; set; }
		public string? Imgname { get; set; }
		public string? path { get; set; }

	}
}
