using CW_ordermedicine.Data.DataModel;
using CW_ordermedicine.Data.ModelData;
using CW_ordermedicine.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace CW_ordermedicine.Data
{
	public class ApplicationContext : DbContext

	{
		public ApplicationContext(
			DbContextOptions<ApplicationContext> options ):base(options) { 
		
		}
		
		public DbSet<TableUser> TableUser { get; set; }
		public DbSet<TableGroupMember> TableGroupMember { get; set; }
		public DbSet<TableProduct> TableProduct { get; set; }
		public DbSet<TableCartProduct> TableCartProduct { get; set; }
		 
		public DbSet<TableOrder> TableOrder { get; set; }
		public DbSet<TableOrderItem> TableOrderItem { get; set; }

		public DbSet<TableReport> TableReport { get; set; }
		public DbSet<TableImg> TableImg { get; set; }
	}
}
