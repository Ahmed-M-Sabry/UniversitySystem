namespace AspDotNetCore.Models
{
    public class Department
    {
        public int id { get; set; }
        public string Name { get; set; }
        public string Manager { get; set; }

        public virtual List<Trainee> Trainees { get; set; }
        public virtual List<Instructore> Instructores { get; set;}
        public virtual List<Course> Courses { get; set; }

    }
}
