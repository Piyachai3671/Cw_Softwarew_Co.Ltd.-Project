﻿using CW_ordermedicine.Data.DataModel;
using System.ComponentModel.DataAnnotations;

namespace CW_ordermedicine.Data.Models
{
	public class User 
	{
		public int UserID { get; set; }

		public string? Name { get; set; }
		public string? Username { get; set; }
		[Required(ErrorMessage = "กรุณากรอกรหัสผ่าน !")]
		[MinLength(6, ErrorMessage = "รหัสผ่านต้องมีมากกว่า 6 ตัวอักษรขึ้นไป !")]
		public string? Password { get; set; }
		[Required(ErrorMessage = "กรุณากรอกเบอร์โทรศัพท์ !")]
		[MinLength(10 , ErrorMessage = "เบอร์โทรศัพท์ต้องมี 10 หลัก !")]
		public string? Tel { get; set; }
		public string? Department { get; set; }
		public string? Level { get; set; }
		public int GroupID { get; set; }

		public int UserImgid { get; set; }
		public string? UserImgName { get; set; }
		public string? UserPath { get; set; }

		public User() { }
		public User ToUi(TableUser tableUser) //UI ไปเทเบิล
		{

			return new User
			{
				UserID = tableUser.UserID,
				Username = tableUser.Name,
				Password = tableUser.Password,
				Name = tableUser.Name,
				Tel= tableUser.Tel,
				Department = tableUser.Department,
				Level = tableUser.Level,
				GroupID = tableUser.GroupID,
				UserImgid = tableUser.UserImgid,
				UserImgName = tableUser.UserImgName,
				UserPath = tableUser.UserPath,

			};

		}

		public TableUser ToTable(User NewUser)
		{
			return new TableUser
			{
				UserID = NewUser.UserID,
				Username = NewUser.Username,
				Password = NewUser.Password,
				Name = NewUser.Name,
				Tel = NewUser.Tel,
				Department = NewUser.Department,
				Level = NewUser.Level,
				GroupID = NewUser.GroupID,
				UserImgid = NewUser.UserImgid,
				UserImgName = NewUser.UserImgName,
				UserPath = NewUser.UserPath,
			};
		}
	}

}
