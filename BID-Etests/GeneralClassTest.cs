using BID_E.Models;
using System;
using System.Linq;
using Xunit;
using Xunit.Sdk;

namespace BID_Etests
{
    public class GeneralClassTest
    {
         General general = new General
        {
            Student_Num = "wkjef",
            Race = "kfj",
            Language = "jskdfn",
            Gender = "jh",
            Years_In_System = 9,
            Start_age = 8,
            End_age = 67,
            Course_Code = "iefj",
            Home_Province = "ldjf",
            Home_Country = "idjfo",
            AGG_YOS1 = "iwej",
            PROG_O_YOS1 = "idfji",
            AGG_YOS2 = "ifjo",
            PROG_O_YOS2 = "dfh",
            AGG_YOS3 = "uew",
            PROG_O_YOS3 = "awd",
            YOS3_OUT = "sxsz",
            Start_Year = 458,
            Reg_End = 388987,
            Reg_Start = 5478

        };
        [Fact]
        public void Student_NumTest()
        {
            string expected = "wkjef";
            Assert.Equal(expected, general.Student_Num);

        }
        [Fact]
        public void RaceTest()
        {
            string expected = "kfj";
            Assert.Equal(expected, general.Race);

        }
        [Fact]
        public void LanguageTest()
        {
            string expected = "jskdfn";
            Assert.Equal(expected, general.Language);

        }
        [Fact]
        public void GenderTest()
        {
            string expected = "jh";
            Assert.Equal(expected, general.Gender);

        }
        [Fact]
        public void Years_In_SystemTest()
        {
            int expected = 9;
            Assert.Equal(expected, general.Years_In_System);

        }
        [Fact]
        public void Start_ageTest()
        {
            int expected = 8;
            Assert.Equal(expected, general.Start_age);

        }
        [Fact]
        public void End_ageTest()
        {
            int expected = 67;
            Assert.Equal(expected, general.End_age);

        }
        [Fact]
        public void Course_CodeTest()
        {
            string expected = "iefj";
            Assert.Equal(expected, general.Course_Code);

        }
        [Fact]
        public void Home_ProvinceTest()
        {
            string expected = "ldjf";
            Assert.Equal(expected, general.Home_Province);

        }
        [Fact]
        public void Home_CountryTest()
        {
            string expected = "idjfo";
            Assert.Equal(expected, general.Home_Country);

        }
        [Fact]
        public void AGG_YOS1Test()
        {
            string expected = "iwej";
            Assert.Equal(expected, general.AGG_YOS1);

        }
        [Fact]
        public void PROG_O_YOS1Test()
        {
            string expected = "idfji";
            Assert.Equal(expected, general.PROG_O_YOS1);

        }
        [Fact]
        public void AGG_YOS2Test()
        {
            string expected = "ifjo";
            Assert.Equal(expected, general.AGG_YOS2);

        }
        [Fact]
        public void PROG_O_YOS2Test()
        {
            string expected = "dfh";
            Assert.Equal(expected, general.PROG_O_YOS2);

        }
        [Fact]
        public void AGG_YOS3Test()
        {
            string expected = "uew";
            Assert.Equal(expected, general.AGG_YOS3);

        }
        [Fact]
        public void PROG_O_YOS3Test()
        {
            string expected = "awd";
            Assert.Equal(expected, general.PROG_O_YOS3);

        }
        [Fact]
        public void YOS3_OUTTest()
        {
            string expected = "sxsz";
            Assert.Equal(expected, general.YOS3_OUT);

        }
        [Fact]
        public void Start_YearTest()
        {
           int expected = 458;
            Assert.Equal(expected, general.Start_Year);

        }
        [Fact]
        public void Reg_EndTest()
        {
            int expected = 388987;
            Assert.Equal(expected, general.Reg_End);

        }
        [Fact]
        public void Reg_StartTest()
        {
            int expected = 5478;
            Assert.Equal(expected, general.Reg_Start);

        }
        LookupOutcome LookUp = new LookupOutcome
        {
            outcome = "k",
            count = 8
        };
        
        [Fact]
        public void LookupOutcomeTest()
        {
            string expected = "k";
            Assert.Equal(expected, LookUp.outcome);

        }
        [Fact]
        public void LookupOutcomeCountTest()
        {
            int expected = 8;
            Assert.Equal(expected, LookUp.count);

        }
        LookupRace Race = new LookupRace
        {
            race = "k",
            count = 8
        };

        [Fact]
        public void LookupRaceTest()
        {
            string expected = "k";
            Assert.Equal(expected, Race.race);

        }
        [Fact]
        public void LLookupRaceCountTest()
        {
            int expected = 8;
            Assert.Equal(expected, Race.count);

        }
        LookupAge Age = new LookupAge
        {
            End_Age = "k",
            count = 8
        };

        [Fact]
        public void LookupAgeTest()
        {
            string expected = "k";
            Assert.Equal(expected, Age.End_Age);

        }
        [Fact]
        public void LookupAgeCountTest()
        {
            int expected = 8;
            Assert.Equal(expected, Age.count);

        }
        LookupYears Years = new LookupYears
        {
            Years_In_System = "k",
            count = 8
        };

        [Fact]
        public void LookupYearsTest()
        {
            string expected = "k";
            Assert.Equal(expected, Years.Years_In_System);

        }
        [Fact]
        public void LookupYearsCountTest()
        {
            int expected = 8;
            Assert.Equal(expected, Years.count);

        }



    }
}
