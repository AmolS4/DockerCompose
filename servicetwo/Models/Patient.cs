using System;
using System.Collections.Generic;

namespace servicetwo.Models
{
    public class Patient
    {
        public int DempNo { get; set; }
        public string PatientName { get; set; }
    }


    public class PatientsDb : List<Patient>
    {
        public PatientsDb()
        {
            Add(new Patient() {DempNo=10, PatientName = "anil" });
            Add(new Patient() { DempNo = 20, PatientName = "rahul" });
        }
    }
}
