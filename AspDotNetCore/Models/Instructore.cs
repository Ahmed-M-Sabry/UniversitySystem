using System.ComponentModel.DataAnnotations.Schema;

namespace AspDotNetCore.Models
{
    public class Instructore
    {
        public int id { get; set; }
        public string Name { get; set; }
        public string Image { get; set; }
        public int Salary { get; set; }
        public string Address { get; set; }


        [ForeignKey("FkDepartment")]
        public int? Department_id { get; set; }
        public virtual Department? FkDepartment { get; set; }

        [ForeignKey("FkCourse")]
        public int? Course_id { get; set; }
        public virtual Course? FkCourse { get; set; }
    }
}
