using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using BID_E.Models;
using SQLite.Models;
using Microsoft.EntityFrameworkCore;
using System.Data.Common;
using Microsoft.Data.Sqlite;
using System.Configuration;

using Microsoft.VisualStudio.Web.CodeGeneration.EntityFrameworkCore;
using Microsoft.AspNetCore.Http.Features;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore.Storage;


// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace BID_E.Controllers
{
    public class QueriesController : Controller
    {
        private readonly ILogger<QueriesController> _logger;
        private DatabaseContext db;

        public QueriesController(ILogger<QueriesController> logger, DatabaseContext _db)
        {
            _logger = logger;
            db = _db;
        }
        // GET: /<controller>/
        public IActionResult Landing()
        {
            return View();
        }

        public IActionResult Gen()
        {
            ViewBag.General = db.General.ToList();
            return View();
        }

        public IActionResult GenderAll()
        {
            return View();
        }
        public IActionResult RaceBlack()
        {
            string cs = "Filename =./SD.db";
            SqliteConnection conn = new SqliteConnection(cs);
            SqliteCommand cmd;
            List<LookupOutcome> groupRace = new List<LookupOutcome>();

            string Race = "SELECT YOS3_OUT, COUNT(*) FROM GENERAL WHERE RACE='Black' GROUP BY YOS3_OUT";

            conn.Open();
            if ((conn.State & System.Data.ConnectionState.Open) > 0)
            {
                cmd = new SqliteCommand(Race, conn);
                SqliteDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    LookupOutcome obj = new LookupOutcome();
                    obj.outcome = reader.GetValue(0).ToString();
                    obj.count = reader.GetInt32(1);
                    groupRace.Add(obj);
                }
            }
            conn.Close();
            ViewBag.Race = groupRace;
            return View();
        }

        public IActionResult RaceColoured()
        {
            string cs = "Filename =./SD.db";
            SqliteConnection conn = new SqliteConnection(cs);
            SqliteCommand cmd;
            List<LookupOutcome> groupRace = new List<LookupOutcome>();

            string Race = "SELECT YOS3_OUT, COUNT(*) FROM GENERAL WHERE RACE='Coloured' GROUP BY YOS3_OUT";

            conn.Open();
            if ((conn.State & System.Data.ConnectionState.Open) > 0)
            {
                cmd = new SqliteCommand(Race, conn);
                SqliteDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    LookupOutcome obj = new LookupOutcome();
                    obj.outcome = reader.GetValue(0).ToString();
                    obj.count = reader.GetInt32(1);
                    groupRace.Add(obj);
                }
            }
            conn.Close();
            ViewBag.Race = groupRace;
            return View();
        }

        public IActionResult RaceIndian()
        {
            string cs = "Filename =./SD.db";
            SqliteConnection conn = new SqliteConnection(cs);
            SqliteCommand cmd;
            List<LookupOutcome> groupRace = new List<LookupOutcome>();

            string Race = "SELECT YOS3_OUT, COUNT(*) FROM GENERAL WHERE RACE='Indian' GROUP BY YOS3_OUT";

            conn.Open();
            if ((conn.State & System.Data.ConnectionState.Open) > 0)
            {
                cmd = new SqliteCommand(Race, conn);
                SqliteDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    LookupOutcome obj = new LookupOutcome();
                    obj.outcome = reader.GetValue(0).ToString();
                    obj.count = reader.GetInt32(1);
                    groupRace.Add(obj);
                }
            }
            conn.Close();
            ViewBag.Race = groupRace;
            return View();
        }

        public IActionResult RaceWhite()
        {
            string cs = "Filename =./SD.db";
            SqliteConnection conn = new SqliteConnection(cs);
            SqliteCommand cmd;
            List<LookupOutcome> groupRace = new List<LookupOutcome>();

            string Race = "SELECT YOS3_OUT, COUNT(*) FROM GENERAL WHERE RACE='White' GROUP BY YOS3_OUT";

            conn.Open();
            if ((conn.State & System.Data.ConnectionState.Open) > 0)
            {
                cmd = new SqliteCommand(Race, conn);
                SqliteDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    LookupOutcome obj = new LookupOutcome();
                    obj.outcome = reader.GetValue(0).ToString();
                    obj.count = reader.GetInt32(1);
                    groupRace.Add(obj);
                }
            }
            conn.Close();
            ViewBag.Race = groupRace;
            return View();
        }

        public IActionResult RaceChinese()
        {
            string cs = "Filename =./SD.db";
            SqliteConnection conn = new SqliteConnection(cs);
            SqliteCommand cmd;
            List<LookupOutcome> groupRace = new List<LookupOutcome>();

            string Race = "SELECT YOS3_OUT, COUNT(*) FROM GENERAL WHERE RACE='Chinese' GROUP BY YOS3_OUT";

            conn.Open();
            if ((conn.State & System.Data.ConnectionState.Open) > 0)
            {
                cmd = new SqliteCommand(Race, conn);
                SqliteDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    LookupOutcome obj = new LookupOutcome();
                    obj.outcome = reader.GetValue(0).ToString();
                    obj.count = reader.GetInt32(1);
                    groupRace.Add(obj);
                }
            }
            conn.Close();
            ViewBag.Race = groupRace;
            return View();
        }

        public IActionResult RaceAll()
        {
            string cs = "Filename =./SD.db";
            SqliteConnection conn = new SqliteConnection(cs);
            SqliteCommand cmd;
            List<LookupRace> groupExcluded = new List<LookupRace>();
            List<LookupRace> groupProceed = new List<LookupRace>();
            List<LookupRace> groupQualified = new List<LookupRace>();
            List<LookupRace> groupNA = new List<LookupRace>();

            string Excluded = "SELECT RACE, COUNT(*)  FROM GENERAL WHERE YOS3_OUT = 'Excluded' GROUP BY RACE";
            string Proceed = "SELECT RACE, COUNT(*)  FROM GENERAL WHERE YOS3_OUT = 'Proceed' GROUP BY RACE";
            string Qualified = "SELECT RACE, COUNT(*)  FROM GENERAL WHERE YOS3_OUT = 'Qualified' GROUP BY RACE";
            string NA = "SELECT RACE, COUNT(*)  FROM GENERAL WHERE YOS3_OUT = 'Not Categorised' GROUP BY RACE";

            conn.Open();
            if ((conn.State & System.Data.ConnectionState.Open) > 0)
            {
                cmd = new SqliteCommand(Excluded, conn);
                SqliteDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    LookupRace obj = new LookupRace();
                    obj.race = reader.GetValue(0).ToString();
                    obj.count = reader.GetInt32(1);
                    groupExcluded.Add(obj);
                }

                cmd = new SqliteCommand(Proceed, conn);
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    LookupRace obj = new LookupRace();
                    obj.race = reader.GetValue(0).ToString();
                    obj.count = reader.GetInt32(1);
                    groupQualified.Add(obj);
                }

                cmd = new SqliteCommand(Qualified, conn);
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    LookupRace obj = new LookupRace();
                    obj.race = reader.GetValue(0).ToString();
                    obj.count = reader.GetInt32(1);
                    groupProceed.Add(obj);
                }

                cmd = new SqliteCommand(NA, conn);
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    LookupRace obj = new LookupRace();
                    obj.race = reader.GetValue(0).ToString();
                    obj.count = reader.GetInt32(1);
                    groupNA.Add(obj);
                }
            }
            conn.Close();
            ViewBag.Excluded = groupExcluded;
            ViewBag.Proceed = groupProceed;
            ViewBag.Qualified = groupQualified;
            ViewBag.NA = groupNA;
            return View();

        }

        public IActionResult Age()
        {
            string cs = "Filename =./SD.db";
            SqliteConnection conn = new SqliteConnection(cs);
            SqliteCommand cmd;
            List<LookupAge> groupMale = new List<LookupAge>();
            List<LookupAge> groupFemale = new List<LookupAge>();

            string Male = "SELECT END_AGE, COUNT(*)  FROM GENERAL WHERE GENDER='M' AND YOS3_OUT='Excluded' AND END_AGE BETWEEN 5 AND 20 GROUP BY END_AGE ORDER BY END_AGE";
            string Female = "SELECT END_AGE, COUNT(*)  FROM GENERAL WHERE GENDER='F' AND YOS3_OUT='Excluded' AND END_AGE BETWEEN 5 AND 20 GROUP BY END_AGE ORDER BY END_AGE";

            conn.Open();
            if ((conn.State & System.Data.ConnectionState.Open) > 0)
            {
                cmd = new SqliteCommand(Male, conn);
                SqliteDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    LookupAge obj = new LookupAge();
                    obj.End_Age = reader.GetValue(0).ToString();
                    obj.count = reader.GetInt32(1);
                    groupMale.Add(obj);
                }

                cmd = new SqliteCommand(Female, conn);
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    LookupAge obj = new LookupAge();
                    obj.End_Age = reader.GetValue(0).ToString();
                    obj.count = reader.GetInt32(1);
                    groupFemale.Add(obj);
                }
            }
            conn.Close();
            ViewBag.Male = groupMale;
            ViewBag.Female = groupFemale;
            return View();

        }

        public IActionResult EasternCape()
        {
            string cs = "Filename =./SD.db";
            SqliteConnection conn = new SqliteConnection(cs);
            SqliteCommand cmd;
            List<LookupOutcome> groupMale = new List<LookupOutcome>();
            List<LookupOutcome> groupFemale = new List<LookupOutcome>();

            string Male = "SELECT YOS3_OUT, COUNT(*)  FROM GENERAL WHERE GENDER='M' AND HOME_PROVINCE ='EC' GROUP BY YOS3_OUT ORDER BY YOS3_OUT";
            string Female = "SELECT YOS3_OUT, COUNT(*)  FROM GENERAL WHERE GENDER='F' AND HOME_PROVINCE ='EC' GROUP BY YOS3_OUT ORDER BY YOS3_OUT";

            conn.Open();
            if ((conn.State & System.Data.ConnectionState.Open) > 0)
            {
                cmd = new SqliteCommand(Male, conn);
                SqliteDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    LookupOutcome obj = new LookupOutcome();
                    obj.outcome = reader.GetValue(0).ToString();
                    obj.count = reader.GetInt32(1);
                    groupMale.Add(obj);
                }

                cmd = new SqliteCommand(Female, conn);
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    LookupOutcome obj = new LookupOutcome();
                    obj.outcome = reader.GetValue(0).ToString();
                    obj.count = reader.GetInt32(1);
                    groupFemale.Add(obj);
                }
            }
            conn.Close();
            ViewBag.Male = groupMale;
            ViewBag.Female = groupFemale;
            return View();
        }

        public IActionResult FreeState()
        {
            string cs = "Filename =./SD.db";
            SqliteConnection conn = new SqliteConnection(cs);
            SqliteCommand cmd;
            List<LookupOutcome> groupMale = new List<LookupOutcome>();
            List<LookupOutcome> groupFemale = new List<LookupOutcome>();

            string Male = "SELECT YOS3_OUT, COUNT(*)  FROM GENERAL WHERE GENDER='M' AND HOME_PROVINCE ='FS' GROUP BY YOS3_OUT ORDER BY YOS3_OUT";
            string Female = "SELECT YOS3_OUT, COUNT(*)  FROM GENERAL WHERE GENDER='F' AND HOME_PROVINCE ='FS' GROUP BY YOS3_OUT ORDER BY YOS3_OUT";

            conn.Open();
            if ((conn.State & System.Data.ConnectionState.Open) > 0)
            {
                cmd = new SqliteCommand(Male, conn);
                SqliteDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    LookupOutcome obj = new LookupOutcome();
                    obj.outcome = reader.GetValue(0).ToString();
                    obj.count = reader.GetInt32(1);
                    groupMale.Add(obj);
                }

                cmd = new SqliteCommand(Female, conn);
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    LookupOutcome obj = new LookupOutcome();
                    obj.outcome = reader.GetValue(0).ToString();
                    obj.count = reader.GetInt32(1);
                    groupFemale.Add(obj);
                }
            }
            conn.Close();
            ViewBag.Male = groupMale;
            ViewBag.Female = groupFemale;
            return View();
        }

        public IActionResult Gauteng()
        {
            string cs = "Filename =./SD.db";
            SqliteConnection conn = new SqliteConnection(cs);
            SqliteCommand cmd;
            List<LookupOutcome> groupMale = new List<LookupOutcome>();
            List<LookupOutcome> groupFemale = new List<LookupOutcome>();

            string Male = "SELECT YOS3_OUT, COUNT(*)  FROM GENERAL WHERE GENDER='M' AND HOME_PROVINCE ='GA' GROUP BY YOS3_OUT ORDER BY YOS3_OUT";
            string Female = "SELECT YOS3_OUT, COUNT(*)  FROM GENERAL WHERE GENDER='F' AND HOME_PROVINCE ='GA' GROUP BY YOS3_OUT ORDER BY YOS3_OUT";

            conn.Open();
            if ((conn.State & System.Data.ConnectionState.Open) > 0)
            {
                cmd = new SqliteCommand(Male, conn);
                SqliteDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    LookupOutcome obj = new LookupOutcome();
                    obj.outcome = reader.GetValue(0).ToString();
                    obj.count = reader.GetInt32(1);
                    groupMale.Add(obj);
                }

                cmd = new SqliteCommand(Female, conn);
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    LookupOutcome obj = new LookupOutcome();
                    obj.outcome = reader.GetValue(0).ToString();
                    obj.count = reader.GetInt32(1);
                    groupFemale.Add(obj);
                }
            }
            conn.Close();
            ViewBag.Male = groupMale;
            ViewBag.Female = groupFemale;
            return View();
        }

        public IActionResult KZN()
        {
            string cs = "Filename =./SD.db";
            SqliteConnection conn = new SqliteConnection(cs);
            SqliteCommand cmd;
            List<LookupOutcome> groupMale = new List<LookupOutcome>();
            List<LookupOutcome> groupFemale = new List<LookupOutcome>();

            string Male = "SELECT YOS3_OUT, COUNT(*)  FROM GENERAL WHERE GENDER='M' AND HOME_PROVINCE ='KZ' GROUP BY YOS3_OUT ORDER BY YOS3_OUT";
            string Female = "SELECT YOS3_OUT, COUNT(*)  FROM GENERAL WHERE GENDER='F' AND HOME_PROVINCE ='KZ' GROUP BY YOS3_OUT ORDER BY YOS3_OUT";

            conn.Open();
            if ((conn.State & System.Data.ConnectionState.Open) > 0)
            {
                cmd = new SqliteCommand(Male, conn);
                SqliteDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    LookupOutcome obj = new LookupOutcome();
                    obj.outcome = reader.GetValue(0).ToString();
                    obj.count = reader.GetInt32(1);
                    groupMale.Add(obj);
                }

                cmd = new SqliteCommand(Female, conn);
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    LookupOutcome obj = new LookupOutcome();
                    obj.outcome = reader.GetValue(0).ToString();
                    obj.count = reader.GetInt32(1);
                    groupFemale.Add(obj);
                }
            }
            conn.Close();
            ViewBag.Male = groupMale;
            ViewBag.Female = groupFemale;
            return View();
        }

        public IActionResult Limpopo()
        {
            string cs = "Filename =./SD.db";
            SqliteConnection conn = new SqliteConnection(cs);
            SqliteCommand cmd;
            List<LookupOutcome> groupMale = new List<LookupOutcome>();
            List<LookupOutcome> groupFemale = new List<LookupOutcome>();

            string Male = "SELECT YOS3_OUT, COUNT(*)  FROM GENERAL WHERE GENDER='M' AND HOME_PROVINCE ='LP' GROUP BY YOS3_OUT ORDER BY YOS3_OUT";
            string Female = "SELECT YOS3_OUT, COUNT(*)  FROM GENERAL WHERE GENDER='F' AND HOME_PROVINCE ='LP' GROUP BY YOS3_OUT ORDER BY YOS3_OUT";

            conn.Open();
            if ((conn.State & System.Data.ConnectionState.Open) > 0)
            {
                cmd = new SqliteCommand(Male, conn);
                SqliteDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    LookupOutcome obj = new LookupOutcome();
                    obj.outcome = reader.GetValue(0).ToString();
                    obj.count = reader.GetInt32(1);
                    groupMale.Add(obj);
                }

                cmd = new SqliteCommand(Female, conn);
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    LookupOutcome obj = new LookupOutcome();
                    obj.outcome = reader.GetValue(0).ToString();
                    obj.count = reader.GetInt32(1);
                    groupFemale.Add(obj);
                }
            }
            conn.Close();
            ViewBag.Male = groupMale;
            ViewBag.Female = groupFemale;
            return View();
        }

        public IActionResult Mpumalanga()
        {
            string cs = "Filename =./SD.db";
            SqliteConnection conn = new SqliteConnection(cs);
            SqliteCommand cmd;
            List<LookupOutcome> groupMale = new List<LookupOutcome>();
            List<LookupOutcome> groupFemale = new List<LookupOutcome>();

            string Male = "SELECT YOS3_OUT, COUNT(*)  FROM GENERAL WHERE GENDER='M' AND HOME_PROVINCE ='MP' GROUP BY YOS3_OUT ORDER BY YOS3_OUT";
            string Female = "SELECT YOS3_OUT, COUNT(*)  FROM GENERAL WHERE GENDER='F' AND HOME_PROVINCE ='MP' GROUP BY YOS3_OUT ORDER BY YOS3_OUT";

            conn.Open();
            if ((conn.State & System.Data.ConnectionState.Open) > 0)
            {
                cmd = new SqliteCommand(Male, conn);
                SqliteDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    LookupOutcome obj = new LookupOutcome();
                    obj.outcome = reader.GetValue(0).ToString();
                    obj.count = reader.GetInt32(1);
                    groupMale.Add(obj);
                }

                cmd = new SqliteCommand(Female, conn);
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    LookupOutcome obj = new LookupOutcome();
                    obj.outcome = reader.GetValue(0).ToString();
                    obj.count = reader.GetInt32(1);
                    groupFemale.Add(obj);
                }
            }
            conn.Close();
            ViewBag.Male = groupMale;
            ViewBag.Female = groupFemale;
            return View();
        }

        public IActionResult NorthWest()
        {
            string cs = "Filename =./SD.db";
            SqliteConnection conn = new SqliteConnection(cs);
            SqliteCommand cmd;
            List<LookupOutcome> groupMale = new List<LookupOutcome>();
            List<LookupOutcome> groupFemale = new List<LookupOutcome>();

            string Male = "SELECT YOS3_OUT, COUNT(*)  FROM GENERAL WHERE GENDER='M' AND HOME_PROVINCE ='NW' GROUP BY YOS3_OUT ORDER BY YOS3_OUT";
            string Female = "SELECT YOS3_OUT, COUNT(*)  FROM GENERAL WHERE GENDER='F' AND HOME_PROVINCE ='NW' GROUP BY YOS3_OUT ORDER BY YOS3_OUT";

            conn.Open();
            if ((conn.State & System.Data.ConnectionState.Open) > 0)
            {
                cmd = new SqliteCommand(Male, conn);
                SqliteDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    LookupOutcome obj = new LookupOutcome();
                    obj.outcome = reader.GetValue(0).ToString();
                    obj.count = reader.GetInt32(1);
                    groupMale.Add(obj);
                }

                cmd = new SqliteCommand(Female, conn);
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    LookupOutcome obj = new LookupOutcome();
                    obj.outcome = reader.GetValue(0).ToString();
                    obj.count = reader.GetInt32(1);
                    groupFemale.Add(obj);
                }
            }
            conn.Close();
            ViewBag.Male = groupMale;
            ViewBag.Female = groupFemale;
            return View();
        }

        public IActionResult NorthernCape()
        {
            string cs = "Filename =./SD.db";
            SqliteConnection conn = new SqliteConnection(cs);
            SqliteCommand cmd;
            List<LookupOutcome> groupMale = new List<LookupOutcome>();
            List<LookupOutcome> groupFemale = new List<LookupOutcome>();

            string Male = "SELECT YOS3_OUT, COUNT(*)  FROM GENERAL WHERE GENDER='M' AND HOME_PROVINCE ='NC' GROUP BY YOS3_OUT ORDER BY YOS3_OUT";
            string Female = "SELECT YOS3_OUT, COUNT(*)  FROM GENERAL WHERE GENDER='F' AND HOME_PROVINCE ='NC' GROUP BY YOS3_OUT ORDER BY YOS3_OUT";

            conn.Open();
            if ((conn.State & System.Data.ConnectionState.Open) > 0)
            {
                cmd = new SqliteCommand(Male, conn);
                SqliteDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    LookupOutcome obj = new LookupOutcome();
                    obj.outcome = reader.GetValue(0).ToString();
                    obj.count = reader.GetInt32(1);
                    groupMale.Add(obj);
                }

                cmd = new SqliteCommand(Female, conn);
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    LookupOutcome obj = new LookupOutcome();
                    obj.outcome = reader.GetValue(0).ToString();
                    obj.count = reader.GetInt32(1);
                    groupFemale.Add(obj);
                }
            }
            conn.Close();
            ViewBag.Male = groupMale;
            ViewBag.Female = groupFemale;
            return View();
        }

        public IActionResult WesternCape()
        {
            string cs = "Filename =./SD.db";
            SqliteConnection conn = new SqliteConnection(cs);
            SqliteCommand cmd;
            List<LookupOutcome> groupMale = new List<LookupOutcome>();
            List<LookupOutcome> groupFemale = new List<LookupOutcome>();

            string Male = "SELECT YOS3_OUT, COUNT(*)  FROM GENERAL WHERE GENDER='M' AND HOME_PROVINCE ='WC' GROUP BY YOS3_OUT ORDER BY YOS3_OUT";
            string Female = "SELECT YOS3_OUT, COUNT(*)  FROM GENERAL WHERE GENDER='F' AND HOME_PROVINCE ='WC' GROUP BY YOS3_OUT ORDER BY YOS3_OUT";

            conn.Open();
            if ((conn.State & System.Data.ConnectionState.Open) > 0)
            {
                cmd = new SqliteCommand(Male, conn);
                SqliteDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    LookupOutcome obj = new LookupOutcome();
                    obj.outcome = reader.GetValue(0).ToString();
                    obj.count = reader.GetInt32(1);
                    groupMale.Add(obj);
                }

                cmd = new SqliteCommand(Female, conn);
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    LookupOutcome obj = new LookupOutcome();
                    obj.outcome = reader.GetValue(0).ToString();
                    obj.count = reader.GetInt32(1);
                    groupFemale.Add(obj);
                }
            }
            conn.Close();
            ViewBag.Male = groupMale;
            ViewBag.Female = groupFemale;
            return View();
        }

        public IActionResult Race()
        {
            string cs = "Filename =./SD.db";
            SqliteConnection conn = new SqliteConnection(cs);
            SqliteCommand cmd;
            List<LookupRace> groupExcluded = new List<LookupRace>();
            List<LookupRace> groupProceed = new List<LookupRace>();
            List<LookupRace> groupQualified = new List<LookupRace>();
            List<LookupRace> groupNA = new List<LookupRace>();

            string Excluded = "SELECT RACE, COUNT(*)  FROM GENERAL WHERE YOS3_OUT = 'Excluded' GROUP BY RACE";
            string Proceed = "SELECT RACE, COUNT(*)  FROM GENERAL WHERE YOS3_OUT = 'Proceed' GROUP BY RACE";
            string Qualified = "SELECT RACE, COUNT(*)  FROM GENERAL WHERE YOS3_OUT = 'Qualified' GROUP BY RACE";
            string NA = "SELECT RACE, COUNT(*)  FROM GENERAL WHERE YOS3_OUT = 'Not Categorised' GROUP BY RACE";

            conn.Open();
            if ((conn.State & System.Data.ConnectionState.Open) > 0)
            {
                cmd = new SqliteCommand(Excluded, conn);
                SqliteDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    LookupRace obj = new LookupRace();
                    obj.race = reader.GetValue(0).ToString();
                    obj.count = reader.GetInt32(1);
                    groupExcluded.Add(obj);
                }

                cmd = new SqliteCommand(Proceed, conn);
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    LookupRace obj = new LookupRace();
                    obj.race = reader.GetValue(0).ToString();
                    obj.count = reader.GetInt32(1);
                    groupQualified.Add(obj);
                }

                cmd = new SqliteCommand(Qualified, conn);
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    LookupRace obj = new LookupRace();
                    obj.race = reader.GetValue(0).ToString();
                    obj.count = reader.GetInt32(1);
                    groupProceed.Add(obj);
                }

                cmd = new SqliteCommand(NA, conn);
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    LookupRace obj = new LookupRace();
                    obj.race = reader.GetValue(0).ToString();
                    obj.count = reader.GetInt32(1);
                    groupNA.Add(obj);
                }
            }
            conn.Close();
            ViewBag.Excluded = groupExcluded;
            ViewBag.Proceed = groupProceed;
            ViewBag.Qualified = groupQualified;
            ViewBag.NA = groupNA;
            return View();

        }

        public IActionResult Years()
        {
            string cs = "Filename =./SD.db";
            SqliteConnection conn = new SqliteConnection(cs);
            SqliteCommand cmd;
            List<LookupYears> groupGen = new List<LookupYears>();
            List<LookupYears> groupMale = new List<LookupYears>();
            List<LookupYears> groupFemale = new List<LookupYears>();

            string Gen_Years = "SELECT YEARS_IN_SYSTEM, COUNT(*)  FROM GENERAL GROUP BY YEARS_IN_SYSTEM";
            string Male = "SELECT YEARS_IN_SYSTEM, COUNT(*)  FROM GENERAL WHERE GENDER='M'  GROUP BY YEARS_IN_SYSTEM";
            string Female = "SELECT YEARS_IN_SYSTEM, COUNT(*)  FROM GENERAL WHERE GENDER='F' GROUP BY YEARS_IN_SYSTEM";

            conn.Open();
            if ((conn.State & System.Data.ConnectionState.Open) > 0)
            {
                cmd = new SqliteCommand(Gen_Years, conn);
                SqliteDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    LookupYears obj = new LookupYears();
                    obj.Years_In_System = reader.GetValue(0).ToString();
                    obj.count = reader.GetInt32(1);
                    groupGen.Add(obj);
                }

                cmd = new SqliteCommand(Male, conn);
                while (reader.Read())
                {
                    LookupYears obj = new LookupYears();
                    obj.Years_In_System = reader.GetValue(0).ToString();
                    obj.count = reader.GetInt32(1);
                    groupMale.Add(obj);
                }

                cmd = new SqliteCommand(Female, conn);
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    LookupYears obj = new LookupYears();
                    obj.Years_In_System = reader.GetValue(0).ToString();
                    obj.count = reader.GetInt32(1);
                    groupFemale.Add(obj);
                }
            }
            conn.Close();
            ViewBag.Male = groupMale;
            ViewBag.Female = groupFemale;
            ViewBag.GenYears = groupGen;
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
