using System.ComponentModel.DataAnnotations;

namespace FGF.Models
{
    public enum Grade
    {
        A, B, C, D, F
    }

    public class Register
    {
        public int EnrollmentID { get; set; }
        public int CourseID { get; set; }
        public int StudentID { get; set; }
        [DisplayFormat(NullDisplayText = "No grade")]
        public Grade? Grade { get; set; }

        public virtual Event Event{ get; set; }
        public virtual Student Student { get; set; }
    }
}