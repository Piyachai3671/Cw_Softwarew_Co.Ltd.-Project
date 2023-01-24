using CW_ordermedicine.Data.DataModel;
using CW_ordermedicine.Data.ModelData;
using System.ComponentModel.DataAnnotations;

namespace CW_ordermedicine.Data.Models
{
	public class GroupMember
	{
		public int GroupID { get; set; }

        [Required(ErrorMessage = "กรุณากรอกชื่อกลุ่ม")]
        public string? GroupName { get; set; }
        //[Required(ErrorMessage = "กรุณาเลือกแผนก")]
        public string? Department { get; set; }
        public int UserID { get; set; }

		public GroupMember() { }
		public GroupMember ToUi(TableGroupMember tableGroupMember) //UI ไปเทเบิล
		{

			return new GroupMember
			{
				GroupID = tableGroupMember.GroupID,
				GroupName = tableGroupMember.GroupName,
				Department = tableGroupMember.Department,
				UserID = tableGroupMember.UserID,
				
			};

		}

		public TableGroupMember ToTable(GroupMember NewGroupMember)
		{
			return new TableGroupMember
			{
				GroupID = NewGroupMember.GroupID,
				GroupName = NewGroupMember.GroupName,
				Department = NewGroupMember.Department,
				UserID = NewGroupMember.UserID,
			};
		}
	}
}
