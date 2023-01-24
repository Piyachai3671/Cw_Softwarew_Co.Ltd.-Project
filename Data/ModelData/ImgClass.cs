using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CW_ordermedicine.Data.ModelData
{
	[Table("CartProduct")]
	public class ImgClass
	{
		[Key]
		public int Imgid { get; set; }
		public string Imgname { get; set; }
		public byte[] Img { get; set; }

	}
}
