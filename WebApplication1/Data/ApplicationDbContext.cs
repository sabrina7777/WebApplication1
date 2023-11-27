using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using WebApplication1.Models;


namespace WebApplication1.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        //This whole section of dbset not sure (don't run mimgration until this is adjusted) update joblinksjobs to something else?

        public DbSet<User> Users { get; set; }

        public DbSet <Job> Jobs { get; set; }
       
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Job>().HasMany(j => j.NextJobs).WithMany();

           /* modelBuilder.Entity<JobLink>()
               .HasKey(jl => new { jl.JobId, jl.NextJobId });

            modelBuilder.Entity<JobLink>()
                .HasOne(jl => jl.Job)
                .WithMany(j => j.NextJobLinks)
                .HasForeignKey(jl => jl.JobId)
                .OnDelete(DeleteBehavior.Restrict);*/

     
        }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
    }
}