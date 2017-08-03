using System;
using System.Collections.Generic;

namespace ContosoUniversity.Models
{
    //Declaration of the model
    public class Student
    {
        //Property of the models
        public int ID { get; set; }
        public string LastName { get; set; }
        public string FirstMidName { get; set; }
        public DateTime EnrollmentDate { get; set; }


        public virtual ICollection<Enrollment> Enrollments { get; set; }
    }
}