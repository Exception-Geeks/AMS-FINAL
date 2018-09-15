//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AttendanceManagement.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Student
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Student()
        {
            this.Attendances = new HashSet<Attendance>();
            this.Teacher_Teaches_Student = new HashSet<Teacher_Teaches_Student>();
        }
    
        public string USN { get; set; }
        public string Name { get; set; }
        public string Section { get; set; }
        public int Sem { get; set; }
        public string Department_DID { get; set; }
        public string Subject_SubCode { get; set; }
        public DateTime Date { get; set; }
        public string Slot { get; set; }
        public bool IsPresent { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Attendance> Attendances { get; set; }
        public virtual Department Department { get; set; }
        public virtual Subject Subject { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Teacher_Teaches_Student> Teacher_Teaches_Student { get; set; }
    }
}