using CW_ordermedicine.Data.DataModel;
using CW_ordermedicine.Data.Models;
using Microsoft.AspNetCore.Components;



using System.Runtime.CompilerServices;

namespace CW_ordermedicine.Data.Services
{
	public class LoginService
	{
		public TableUser UserToLogin;
		private UserService UserService; // เอาuser มาใช้
		public LoginService(UserService userService)
		{
			UserService = userService;
		}
		public async Task<bool> Login(string UserName, string Password)
		{
			bool Status = false;
			TableUser? Users = await UserService.SelectUser(UserName, Password); //การล็อคอินมีได้แค่1คนจึงใช้การค้นหา
			if (Users != null)
			{
				UserToLogin = Users;
				Status = true;


			}
			return await Task.FromResult(Status);
		}
		public bool LogOut()
		{
			UserToLogin = UserToLogin;
			bool Status = false;
			return Status;

		}
	}
}
