using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Models
{
    public class JobLink
    {
        [Key]
        public int JobLinkId { get; set; }

        // Foreign key for the Jobs table
        public int JobId { get; set; }
        public Job? Job { get; set; }

        // Foreign key for the next job
        public int NextJobId { get; set; }
        public Job? NextJob { get; set; }

        //foreign key in EF <navigation property name><primary key property name> OR <primary key property name>
    }
}

