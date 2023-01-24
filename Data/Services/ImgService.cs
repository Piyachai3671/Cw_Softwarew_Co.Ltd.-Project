using CW_ordermedicine.Data.DataModel;
using CW_ordermedicine.Data.ModelData;
using CW_ordermedicine.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace CW_ordermedicine.Data.Services
{
	public class ImgService
	{
		private readonly ApplicationContext _Context;
			public ImgService(ApplicationContext context)
		{
			_Context = context;
		}
		private List<TableImg> imgclass = new List<TableImg>()
		{

		};
		public async Task<List<TableImg>> GetImgClassServices()
		{
			var u = _Context.TableImg.ToList();
			return await Task.FromResult(u);
		}
		public void AddNewImg(TableImg NewImg)
		{
			_Context.TableImg.Add(NewImg);

			_Context.SaveChanges();//บันทึกลง SQL

		}
		public bool Uploadimg(TableImg ic)
		{
			_Context.TableImg.Add(ic);
			_Context.SaveChanges();
			return true;
		}
	}
}
