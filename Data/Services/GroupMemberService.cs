using CW_ordermedicine.Data.DataModel;
using CW_ordermedicine.Data.ModelData;
using CW_ordermedicine.Data.Models;
using Microsoft.EntityFrameworkCore;
using System.Reflection.Metadata.Ecma335;

namespace CW_ordermedicine.Data.Services
{
    public class GroupMemberService
    {
		private ApplicationContext _Context; //ประกาศเพื่อเรียกาารเช้าถึง DataBase
		public GroupMemberService(ApplicationContext context)
		{
			_Context = context;
		}
		//private List<GroupMember> Groups = new List<GroupMember>()
		//{
		//	 new GroupMember(){GroupID=0, GroupName="คนที่ไม่มีกลุ่ม",  },
		//		new GroupMember(){GroupID=1, GroupName="A Group",   },
		//		new GroupMember(){GroupID=2, GroupName="B Group", },
		//		new GroupMember(){GroupID=3, GroupName="C Group",  },
		//		new GroupMember(){GroupID=4, GroupName="D Group",  },

		//};
		//public async Task<List<GroupMember>> GetGroupAsync()
		//{
		//	return await Task.FromResult(Groups);
		//}

		public async Task<List<TableGroupMember>> GetGroupAsync()
		{
			var u = _Context.TableGroupMember.ToList();
			return await Task.FromResult(u);


		}
		public void AddNewGroupMember(TableGroupMember NewGroupMember)
		{
			_Context.TableGroupMember.Add(NewGroupMember);

			_Context.SaveChanges();//บันทึกลง SQL

		}
		public void DeleteGroupMember(TableGroupMember DeleteGroupMember)
		{
			var FindID = _Context.TableGroupMember.First(e => e.GroupID == DeleteGroupMember.GroupID);
			
			_Context.TableGroupMember.Remove(FindID);
			_Context.SaveChanges();
		}

		//public void SelectGroup()
		//{
		//	var u = _Context.TableGroupMember.Count();

		//}
		public void SelectGroup2(TableGroupMember b)
		{
			var FindID = _Context.TableGroupMember.First(e => e.GroupID == b.GroupID);

		}
		//public void getdata()
		//{
		//	var u = _Context.TableGroupMember.ToList();

		//}
	}
}