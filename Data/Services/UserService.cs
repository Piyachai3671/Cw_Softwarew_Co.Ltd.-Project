using CW_ordermedicine.Data.Models;
using CW_ordermedicine.Data.ModelData;
using CW_ordermedicine.Data.DataModel;
using Microsoft.EntityFrameworkCore;
using System.Linq.Dynamic.Core;


namespace CW_ordermedicine.Data.Services
{
	public class UserService
	{
		private ApplicationContext _Context; //ประกาศเพื่อเรียกาารเช้าถึง DataBase
		public UserService(ApplicationContext context)
		{
			_Context = context;
		}
		//private List<User> Users = new List<User>()
		//{
		//};
		
		public async Task<List<TableUser>> GetUserAsync()
		{
			var u =_Context.TableUser.ToList();
			return await Task.FromResult(u);
		}
		public void AddNewUser(TableUser NewUser )
		{
			_Context.TableUser.Add(NewUser);

			_Context.SaveChanges();//บันทึกลง SQL

		}
		public void EditUser(TableUser EditUser)
		{
			var FindID = _Context.TableUser.First(e =>e.UserID == EditUser.UserID);
			FindID.Department = EditUser.Department;
			FindID.GroupID= EditUser.GroupID;
			FindID.Name = EditUser.Name;
			FindID.Tel = EditUser.Tel;
			FindID.Password = EditUser.Password;
			FindID.UserImgName = EditUser.UserImgName;
			FindID.UserPath= EditUser.UserPath;


			_Context.TableUser.Update(FindID);
			_Context.SaveChanges();//บันทึกลง SQL
		}
		public Task <TableUser?> SelectUser( string username , string password )
		{
			
			var e = _Context.TableUser.FirstOrDefault(e => e.Username == username && e.Password == password);
			if (e != null)
			{
				return Task.FromResult(e);
			}
			else
			{
				return Task.FromResult(new TableUser());
			}
			
			//var u = _Context.TableUser.First(e => e.Username == username && e.Password == password);
			
			//return Task.FromResult(u);
		}
		
	}
}
