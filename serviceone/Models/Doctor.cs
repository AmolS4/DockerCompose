using System;
using System.Collections.Generic;

namespace serviceone.Models
{
    public class Doctor
    {
        public int EmpNo { get; set; }
        public string DoctorName { get; set; }
    }



    public class DoctorDb : List<Doctor>
    {
        public DoctorDb()
        {
            Add(new Doctor() { EmpNo=101, DoctorName = "Amol"});
            Add(new Doctor() { EmpNo = 102, DoctorName = "Ganesh" });
        }
    }
}
