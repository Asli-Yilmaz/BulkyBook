using BulkyBookWeb.Models;
using Microsoft.EntityFrameworkCore;
using System.Data.Common;

namespace BulkyBookWeb.Data;

public class ApplicationDBContex: DbContext
{
	//ctor yaz +2 kez taba bas constructerı oluşturur
	public ApplicationDBContex(DbContextOptions<ApplicationDBContex>options): base(options)
	{

	}
	public DbSet<Category> Categories{ get; set; }
}
