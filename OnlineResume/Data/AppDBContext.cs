using Microsoft.EntityFrameworkCore;
using OnlineResume.Models;

namespace OnlineResume.Data
{
	public class AppDBContext : DbContext
	{
        public AppDBContext(DbContextOptions<AppDBContext> options) : base(options) { }

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
            // seed data of personal data
            modelBuilder.Entity<PersonalData>().HasData(new PersonalData()
            {
                Id = 1,
                FullName = "Mohammad Fathi",
                Age = 18,
                BirthDay = DateTime.Now,
                Email = "m_fathi65@yahoo.com",
                PhoneNumber = "09934836290",
                AboutMe = "test",
                Gender = Gender.Male,
			});
            modelBuilder.Entity<User>().HasData(new User()
            {
                Id = 1,
                UserName = "edovoss",
                Email = "m_fathi65@yahoo.com",
                Password = "0pd4s2f14"
            });

			base.OnModelCreating(modelBuilder);
		}

        public DbSet<PersonalData> PersonalData { get; set; }
        public DbSet<Education> Educations { get; set; }
        public DbSet<Experience> Experiences { get; set; }
        public DbSet<Language> Languages { get; set; }
        public DbSet<Project> Projects { get; set; }
        public DbSet<Skill> Skills { get; set; }
        public DbSet<SoftSkills> SoftSkills { get; set; }

        public DbSet<User> Users { get; set; }
    }
}
