using System.ComponentModel.DataAnnotations.Schema;

namespace AspDotNetCore.Models
{
    public class CourseResult
    {
        public int Id { get; set; }
        public int Drgree { get; set; }

        [ForeignKey("FkCourse")]
        public int? Course_id { get; set; }
        public virtual Course? FkCourse { get; set; }

        [ForeignKey("FkTrainee")]
        public int? Trainee_Id { get; set; }
        public virtual Trainee? FkTrainee { get; set; }
    }
}
