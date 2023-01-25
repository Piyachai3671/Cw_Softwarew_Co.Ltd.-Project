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
		public void SelectGroup2(TableGroupMember b)
		{
			var FindID = _Context.TableGroupMember.First(e => e.GroupID == b.GroupID);

		}
		public void EditGroup(TableGroupMember EditGroup)
		{
			var FindID = _Context.TableGroupMember.First(e => e.GroupID == EditGroup.GroupID);
			FindID.GroupName = EditGroup.GroupName;
			FindID.Department = EditGroup.Department;

			_Context.TableGroupMember.Update(FindID);
			_Context.SaveChanges();//บันทึกลง SQL
		}
	}
}