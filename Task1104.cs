using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace LYNK
{
    class Task1104
    {
        public static void Main()
        {
            IList<Doctor> Studata = new List<Doctor>()
            {
                new Doctor(){DoctorID=1,DoctorName="yuvaraj",Age=21,SpecializationID=1},
                new Doctor(){DoctorID=2,DoctorName="Aanand",Age=23,SpecializationID=2},
                new Doctor(){DoctorID=3,DoctorName="pavan kumar",Age=22,SpecializationID=3},
                new Doctor(){DoctorID=4,DoctorName="John",Age=30,SpecializationID=2},
                new Doctor(){DoctorID=5,DoctorName="abdul",Age=23,SpecializationID=3},
                new Doctor(){DoctorID=6,DoctorName="santhosh",Age=21,SpecializationID=1},
                new Doctor(){DoctorID=7,DoctorName="sid",Age=20,SpecializationID=1},
                new Doctor(){DoctorID=8,DoctorName="Hariswar",Age=28,SpecializationID=2 }
            };
            IList<specialization> BranchData = new List<specialization>()
            {
                new specialization(){SpecializationID=1, SpecializationName="Physio"},
                new specialization(){SpecializationID=2, SpecializationName="Dental"},
                new specialization(){SpecializationID=3, SpecializationName="EYE"}
            };
            var JoinData = Studata.Join(
                BranchData,
                stu => stu.SpecializationID,
                brd => brd.SpecializationID,
                (stu, brd) => new
                {
                    DoctorName = stu.DoctorName,
                    SpecializationName = brd.SpecializationName
                }
                );
            foreach (var v in JoinData)
            {
                Console.WriteLine(v.DoctorName + " " + v.SpecializationName);
            }




        }
        public class specialization
        {
            public int SpecializationID { get; set; }
            public string SpecializationName { get; set; }

        }
        class Doctor
        {

            public int DoctorID { get; set; }
            public string DoctorName { get; set; }
            public int Age { get; set; }

            public int SpecializationID { get; set; }
        }

    }
}
