using System.ComponentModel.DataAnnotations.Schema;

namespace AspDotNetCore.Models
{
    public class Trainee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Image { get; set; }
        public string Address { get; set; }
        public int Grade { get; set; }

        [ForeignKey("FkDepartment")]
        public int? Department_id { get; set; }
        public virtual Department? FkDepartment { get; set; }


        public virtual List<CourseResult> CourseResults { get; set; }
    }
}
