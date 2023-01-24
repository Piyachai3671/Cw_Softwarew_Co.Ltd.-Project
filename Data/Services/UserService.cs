using CW_ordermedicine.Data.Models;
using CW_ordermedicine.Data.ModelData;
using CW_ordermedicine.Data.DataModel;
using Microsoft.EntityFrameworkCore;

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

		//	//new User(){UserID=001, Name="cxu43496@xcoxc.com",Username="ปิยชัย1",Department="IT" , GroupID =1},
		//	//new User(){UserID=002, Name="cxu43496@xcoxc.com",Username="ปิยชัย2",Department="IT" , GroupID =1},
		//	//new User(){UserID=003, Name="cxu43496@xcoxc.com",Username="ปิยชัย3",Department="IT" , GroupID =1},
		//	//new User(){UserID=004, Name="cxu43496@xcoxc.com",Username="ปิยชัย4",Department="IT", GroupID =2},
		//	//new User(){UserID=005, Name="yqg92361@cdfaq.com",Username="ยศภัทธ์",Department="Cook" , GroupID =2},
		//	//new User(){UserID=006, Name="dyn62404@nezid.com",Username="พิเชษ",Department="Sell" , GroupID =3},
		//	//new User(){UserID=007, Name="cxu0001.com",Username="สิทธิพงส์1",Department="IT", GroupID = 4},
		//	//new User(){UserID=008, Name="cxu0001.com",Username="สิทธิพงส์2",Department="IT", GroupID = 4},
		//	//new User(){UserID=009, Name="cxu0001.com",Username="dummy1",Department="IT", GroupID = 0},
		//	//new User(){UserID=010, Name="cxu0001.com",Username="dummy2",Department="IT", GroupID = 0},
		//	//new User(){UserID=011, Name="cxu0001.com",Username="dummy3",Department="IT", GroupID = 0},

		//	//new User(){UserID=012, Name="Dummy1.com",Username="dummy4",Password="ax001",Department="IT", GroupID = 0},
		//	//new User(){UserID=013, Name="Dummy2.com",Username="dummy5",Password="ax002",Department="IT", GroupID = 0},
		//	//new User(){UserID=014, Name="Dummy3.com",Username="dummy6",Password="ax003",Department="IT", GroupID = 0},

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
		public Task <TableUser> SelectUser( string username , string password )
		{
			var u = _Context.TableUser.First(e => e.Username == username && e.Password == password);
			return Task.FromResult(u);
		}
		
	}
}
