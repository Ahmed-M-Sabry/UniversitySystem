using System.ComponentModel.DataAnnotations.Schema;

namespace AspDotNetCore.Models
{
    public class Course
    {
        public int id { get; set; }
        public string Name { get; set; }
        public int Degree { get; set; }
        public int PassDegree { get; set; }

        [ForeignKey("FkDepartment")]
        public int? Department_id { get; set; }
        public virtual Department? FkDepartment { get; set; }

        public virtual List<CourseResult> CourseResults { get; set; }
        public virtual List<Instructore> Instructores { get; set; }

    }
}
