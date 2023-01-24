using CW_ordermedicine.Data.ModelData;

namespace CW_ordermedicine.Data.Models
{
	public class Img
	{
		public int Imgid { get; set; }
		public string? Imgname { get; set; }
		public string? path { get; set; }

		public Img()
		{ }
		public Img ToUi(TableImg tableImg) //UI ไปเทเบิล
		{

			return new Img
			{
				Imgid = tableImg.Imgid,
				Imgname = tableImg.Imgname,
				path = tableImg.path,
			};
		}

		public TableImg ToTable(Img NewImg)
		{
			return new TableImg
			{
				Imgid = NewImg.Imgid,
				Imgname = NewImg.Imgname,
				path = NewImg.path,
			};
		}

	}

}
