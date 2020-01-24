using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ispiti2
{
	public class DB : DbContext
	{
		public DbSet<Predmet> dbPredmeti { get; set; }
		public DbSet<Student> dbStudenti { get; set; }

		protected override void OnModelCreating(DbModelBuilder modelBuilder)
		{
			modelBuilder.Entity<Predmet>().HasKey(p => p.Naziv);
			modelBuilder.Entity<Student>().HasKey(s => s.BrIndeksa);
		}
	}
}
