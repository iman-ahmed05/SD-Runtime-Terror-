using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BID_E.Models
{
    [Table("General")]
    public class General
    {
        [Key]
        public String Student_Num { get; set; }
        public String Race { get; set; }
        public String Language { get; set; }
        public String Gender { get; set; }
        public int Years_In_System { get; set; }
        public int Start_age { get; set; }
        public int End_age { get; set; }
        public String Course_Code { get; set; }
        public string Home_Province { get; set; }
        public String Home_Country { get; set; }
        public String AGG_YOS1 { get; set; }
        public String PROG_O_YOS1 { get; set; }
        public String AGG_YOS2 { get; set; }
        public String PROG_O_YOS2 { get; set; }
        public String AGG_YOS3 { get; set; }
        public String PROG_O_YOS3 { get; set; }
        public String YOS3_OUT { get; set; }
        public int Start_Year { get; set; }
        public int Reg_Start { get; set; }
        public int Reg_End { get; set; }
        public int StudentCount { get; internal set; }
    }

    public class LookupOutcome
    {
        public String outcome { get; set; }
        public int count { get; set; }

    }

    public class LookupRace
    {
        public String race { get; set; }
        public int count { get; set; }
    }
}
