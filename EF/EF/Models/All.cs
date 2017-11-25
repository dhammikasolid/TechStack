using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EF.Models
{
    public class Student
    {
        public int Id { get; set; }
        [MaxLength(100)]
        public string Name { get; set; }
        public DateTime? BirthDay { get; set; }

        [Required, ForeignKey("Class1")]
        public int Class1Id { get; set; }
        public virtual Class Class1 { get; set; }

        [ForeignKey("Class2")]
        public int? Class2Id { get; set; }
        public virtual Class Class2 { get; set; }

        public virtual StudentProfile Profile {get; set;}
    }

    public class Class
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Grade { get; set; }

        [InverseProperty("Class1")]
        public virtual List<Student> Students1 { get; set; }
        [InverseProperty("Class2")]
        public virtual List<Student> Students2 { get; set; }

        public virtual List<ClassTeacher> Teachers { get; set; }
    }

    public class Teacher
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Subject { get; set; }

        public virtual List<ClassTeacher> Classes { get; set; }

        [ForeignKey("ReportsTo")]
        public int? ReportsToId { get; set; }
        public Teacher ReportsTo { get; set; }
    }

    public class ClassTeacher
    {
        [MaxLength(100)]
        public string Participation { get; set; }

        [Key, Column(Order = 1)]
        public int TeacherId { get; set; }
        public virtual Teacher Teacher { get; set; }

        [Key, Column(Order = 2)]
        public int ClassId { get; set; }
        public virtual Class Class { get; set; }
    }

    public class StudentProfile
    {
        [Key, ForeignKey("Student")]
        public int Id { get; set; }
        public string ContactNo { get; set; }

        public virtual Student Student { get; set;}
    }
}
