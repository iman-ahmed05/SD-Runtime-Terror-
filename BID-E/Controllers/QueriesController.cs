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
using Microsoft.AspNetCore.Http;


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
            if (HttpContext.Session.GetString("UserId") != null)
            {
                ViewBag.Username = HttpContext.Session.GetString("Username");
                return View();
            }
            return View();
        }

        //User selects 3 or 4 attributes and the relevant data is retrieved
        public IActionResult Query(string id)
        {
            //If all 4 filters are selected
            ViewBag.MyString = id;
            if ((id.Contains("EC")| id.Contains("FS") | id.Contains("GA") | id.Contains("LP") | id.Contains("MP") | id.Contains("NW") | id.Contains("NC") | id.Contains("WC") | id.Contains("KZ")) &
                (id.Contains("Black") | id.Contains("Coloured") | id.Contains("Chinese") | id.Contains("Indian") | id.Contains("White")) & id.Contains("AND") & (id.Contains(",M,") | id.Contains(",F,") ))
            {
                String prov = id.Substring(0, 2);
                String gender = id.Substring(3, 1);
                String age = id.Substring(5, 9);
                String race = id.Substring(15);
                ViewBag.Prov = prov;
                ViewBag.Gender = gender;
                ViewBag.Age = age;
                ViewBag.Race = race;

                //Connection to Database
                string cs = "Filename =./SD.db";
                SqliteConnection conn = new SqliteConnection(cs);
                SqliteCommand cmd;

                //Create lists to store data from each query
                List<LookupProv> groupExcluded = new List<LookupProv>();
                List<LookupProv> groupQualified = new List<LookupProv>();
                List<LookupProv> groupProceed = new List<LookupProv>();
                List<LookupProv> groupNotCategorised = new List<LookupProv>();

                //SQL Query Strings
                String Excluded = "SELECT REG_END, COUNT(*)  FROM GENERAL WHERE HOME_PROVINCE = '" + prov + "' AND GENDER = '" + gender + "' AND RACE = '" + race + "' AND END_AGE BETWEEN " + age + "  AND YOS3_OUT = 'Excluded' GROUP BY REG_END ORDER BY REG_END";
                String Qualified = "SELECT REG_END, COUNT(*)  FROM GENERAL WHERE HOME_PROVINCE = '" + prov + "' AND GENDER = '" + gender + "' AND RACE = '" + race + "' AND END_AGE BETWEEN " + age + "  AND YOS3_OUT = 'Qualified' GROUP BY REG_END ORDER BY REG_END";
                String Proceed = "SELECT REG_END, COUNT(*)  FROM GENERAL WHERE HOME_PROVINCE = '" + prov + "' AND GENDER = '" + gender + "' AND RACE = '" + race + "' AND END_AGE BETWEEN " + age + "  AND YOS3_OUT = 'Proceed' GROUP BY REG_END ORDER BY REG_END";
                String NotCategorised = "SELECT REG_END, COUNT(*)  FROM GENERAL WHERE HOME_PROVINCE = '" + prov + "' AND GENDER = '" + gender + "' AND RACE = '" + race + "' AND END_AGE BETWEEN " + age + " AND YOS3_OUT = 'Not Categorised' GROUP BY REG_END ORDER BY REG_END";
                conn.Open();
                if ((conn.State & System.Data.ConnectionState.Open) > 0)
                {
                    //Execution of query
                    cmd = new SqliteCommand(Excluded, conn);
                    SqliteDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        //Results from query added to List
                        LookupProv obj = new LookupProv();
                        obj.reg_End = reader.GetValue(0).ToString();
                        obj.count = reader.GetInt32(1);
                        groupExcluded.Add(obj);
                    }

                    cmd = new SqliteCommand(Qualified, conn);
                    reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        LookupProv obj = new LookupProv();
                        obj.reg_End = reader.GetValue(0).ToString();
                        obj.count = reader.GetInt32(1);
                        groupQualified.Add(obj);
                    }

                    cmd = new SqliteCommand(Proceed, conn);
                    reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        LookupProv obj = new LookupProv();
                        obj.reg_End = reader.GetValue(0).ToString();
                        obj.count = reader.GetInt32(1);
                        groupProceed.Add(obj);
                    }

                    cmd = new SqliteCommand(NotCategorised, conn);
                    reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        LookupProv obj = new LookupProv();
                        obj.reg_End = reader.GetValue(0).ToString();
                        obj.count = reader.GetInt32(1);
                        groupNotCategorised.Add(obj);
                    }
                }
                conn.Close();

                //Data from lists added to ViewBag to be passed to View
                ViewBag.Excluded = groupExcluded;
                ViewBag.Qualified = groupQualified;
                ViewBag.Proceed = groupProceed;
                ViewBag.NotCategorised = groupNotCategorised;

            }
            //If Province, Race and Gender filters are selected
            else if ((id.Contains("EC") | id.Contains("FS") | id.Contains("GA") | id.Contains("LP") | id.Contains("MP") | id.Contains("NW") | id.Contains("NC") | id.Contains("WC") | id.Contains("KZ")) &
                (id.Contains("Black") | id.Contains("Coloured") | id.Contains("Chinese") | id.Contains("Indian") | id.Contains("White")) & id.Contains("AND") == false & (id.Contains(",M") | id.Contains(",F")))
            {
                String prov = id.Substring(0, 2);
                String gender = id.Substring(3, 1);
                String race = id.Substring(15);
                ViewBag.Prov = prov;
                ViewBag.Gender = gender;
                ViewBag.Race = race;

                string cs = "Filename =./SD.db";
                SqliteConnection conn = new SqliteConnection(cs);
                SqliteCommand cmd;
                List<LookupProv> groupExcluded = new List<LookupProv>();
                List<LookupProv> groupQualified = new List<LookupProv>();
                List<LookupProv> groupProceed = new List<LookupProv>();
                List<LookupProv> groupNotCategorised = new List<LookupProv>();

                String Excluded = "SELECT REG_END, COUNT(*)  FROM GENERAL WHERE HOME_PROVINCE = '" + prov + "' AND GENDER = '" + gender + "' AND RACE = '" + race + "' AND YOS3_OUT = 'Excluded' GROUP BY REG_END ORDER BY REG_END";
                String Qualified = "SELECT REG_END, COUNT(*)  FROM GENERAL WHERE HOME_PROVINCE = '" + prov + "' AND GENDER = '" + gender + "' AND RACE = '" + race + "' AND YOS3_OUT = 'Qualified' GROUP BY REG_END ORDER BY REG_END";
                String Proceed = "SELECT REG_END, COUNT(*)  FROM GENERAL WHERE HOME_PROVINCE = '" + prov + "' AND GENDER = '" + gender + "' AND RACE = '" + race + "' AND YOS3_OUT = 'Proceed' GROUP BY REG_END ORDER BY REG_END";
                String NotCategorised = "SELECT REG_END, COUNT(*)  FROM GENERAL WHERE HOME_PROVINCE = '" + prov + "' AND GENDER = '" + gender + "' AND RACE = '" + race + "' AND YOS3_OUT = 'Not Categorised' GROUP BY REG_END ORDER BY REG_END";
                conn.Open();
                if ((conn.State & System.Data.ConnectionState.Open) > 0)
                {
                    cmd = new SqliteCommand(Excluded, conn);
                    SqliteDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        LookupProv obj = new LookupProv();
                        obj.reg_End = reader.GetValue(0).ToString();
                        obj.count = reader.GetInt32(1);
                        groupExcluded.Add(obj);
                    }

                    cmd = new SqliteCommand(Qualified, conn);
                    reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        LookupProv obj = new LookupProv();
                        obj.reg_End = reader.GetValue(0).ToString();
                        obj.count = reader.GetInt32(1);
                        groupQualified.Add(obj);
                    }

                    cmd = new SqliteCommand(Proceed, conn);
                    reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        LookupProv obj = new LookupProv();
                        obj.reg_End = reader.GetValue(0).ToString();
                        obj.count = reader.GetInt32(1);
                        groupProceed.Add(obj);
                    }

                    cmd = new SqliteCommand(NotCategorised, conn);
                    reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        LookupProv obj = new LookupProv();
                        obj.reg_End = reader.GetValue(0).ToString();
                        obj.count = reader.GetInt32(1);
                        groupNotCategorised.Add(obj);
                    }
                }
                conn.Close();
                ViewBag.Excluded = groupExcluded;
                ViewBag.Qualified = groupQualified;
                ViewBag.Proceed = groupProceed;
                ViewBag.NotCategorised = groupNotCategorised;
            }
            //If Race, Age and Gender filters are selected
            else if ((id.Contains("EC") == false | id.Contains("FS") == false | id.Contains("GA") == false | id.Contains("LP") == false | id.Contains("MP") == false | id.Contains("NW") == false | id.Contains("NC") == false | id.Contains("WC") == false | id.Contains("KZ") == false) &
               (id.Contains("Black") | id.Contains("Coloured") | id.Contains("Chinese") | id.Contains("Indian") | id.Contains("White")) & id.Contains("AND") & (id.Contains(",M") | id.Contains(",F")))
            {
                String gender = id.Substring(10, 1);
                String age = id.Substring(12, 9);
                String race = id.Substring(22);
                ViewBag.Gender = gender;
                ViewBag.Age = age;
                ViewBag.Race = race;

                string cs = "Filename =./SD.db";
                SqliteConnection conn = new SqliteConnection(cs);
                SqliteCommand cmd;
                List<LookupProv> groupExcluded = new List<LookupProv>();
                List<LookupProv> groupQualified = new List<LookupProv>();
                List<LookupProv> groupProceed = new List<LookupProv>();
                List<LookupProv> groupNotCategorised = new List<LookupProv>();

                String Excluded = "SELECT REG_END, COUNT(*)  FROM GENERAL WHERE GENDER = '" + gender + "' AND RACE = '" + race + "' AND END_AGE BETWEEN " + age + "  AND YOS3_OUT = 'Excluded' GROUP BY REG_END ORDER BY REG_END";
                String Qualified = "SELECT REG_END, COUNT(*)  FROM GENERAL WHERE GENDER = '" + gender + "' AND RACE = '" + race + "' AND END_AGE BETWEEN " + age + "  AND YOS3_OUT = 'Qualified' GROUP BY REG_END ORDER BY REG_END";
                String Proceed = "SELECT REG_END, COUNT(*)  FROM GENERAL WHERE GENDER = '" + gender + "' AND RACE = '" + race + "' AND END_AGE BETWEEN " + age + "  AND YOS3_OUT = 'Proceed' GROUP BY REG_END ORDER BY REG_END";
                String NotCategorised = "SELECT REG_END, COUNT(*)  FROM GENERAL WHERE GENDER = '" + gender + "' AND RACE = '" + race + "' AND END_AGE BETWEEN " + age + " AND YOS3_OUT = 'Not Categorised' GROUP BY REG_END ORDER BY REG_END";
                conn.Open();
                if ((conn.State & System.Data.ConnectionState.Open) > 0)
                {
                    cmd = new SqliteCommand(Excluded, conn);
                    SqliteDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        LookupProv obj = new LookupProv();
                        obj.reg_End = reader.GetValue(0).ToString();
                        obj.count = reader.GetInt32(1);
                        groupExcluded.Add(obj);
                    }

                    cmd = new SqliteCommand(Qualified, conn);
                    reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        LookupProv obj = new LookupProv();
                        obj.reg_End = reader.GetValue(0).ToString();
                        obj.count = reader.GetInt32(1);
                        groupQualified.Add(obj);
                    }

                    cmd = new SqliteCommand(Proceed, conn);
                    reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        LookupProv obj = new LookupProv();
                        obj.reg_End = reader.GetValue(0).ToString();
                        obj.count = reader.GetInt32(1);
                        groupProceed.Add(obj);
                    }

                    cmd = new SqliteCommand(NotCategorised, conn);
                    reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        LookupProv obj = new LookupProv();
                        obj.reg_End = reader.GetValue(0).ToString();
                        obj.count = reader.GetInt32(1);
                        groupNotCategorised.Add(obj);
                    }
                }
                conn.Close();
                ViewBag.Excluded = groupExcluded;
                ViewBag.Qualified = groupQualified;
                ViewBag.Proceed = groupProceed;
                ViewBag.NotCategorised = groupNotCategorised;
            }
            //If Province, Age and Gender filters are selected
            else if ((id.Contains("EC") | id.Contains("FS") | id.Contains("GA") | id.Contains("LP") | id.Contains("MP") | id.Contains("NW") | id.Contains("NC") | id.Contains("WC") | id.Contains("KZ")) &
                (id.Contains("Black") == false | id.Contains("Coloured") == false | id.Contains("Chinese") == false | id.Contains("Indian") == false | id.Contains("White") == false) & id.Contains("AND") & (id.Contains(",M") | id.Contains(",F")))
            {
                String prov = id.Substring(0, 2);
                String gender = id.Substring(3, 1);
                String age = id.Substring(5, 9);
                ViewBag.Prov = prov;
                ViewBag.Gender = gender;
                ViewBag.Age = age;

                string cs = "Filename =./SD.db";
                SqliteConnection conn = new SqliteConnection(cs);
                SqliteCommand cmd;
                List<LookupProv> groupExcluded = new List<LookupProv>();
                List<LookupProv> groupQualified = new List<LookupProv>();
                List<LookupProv> groupProceed = new List<LookupProv>();
                List<LookupProv> groupNotCategorised = new List<LookupProv>();

                String Excluded = "SELECT REG_END, COUNT(*)  FROM GENERAL WHERE HOME_PROVINCE = '" + prov + "' AND GENDER = '" + gender + "' AND END_AGE BETWEEN " + age + "  AND YOS3_OUT = 'Excluded' GROUP BY REG_END ORDER BY REG_END";
                String Qualified = "SELECT REG_END, COUNT(*)  FROM GENERAL WHERE HOME_PROVINCE = '" + prov + "' AND GENDER = '" + gender + "' AND END_AGE BETWEEN " + age + "  AND YOS3_OUT = 'Qualified' GROUP BY REG_END ORDER BY REG_END";
                String Proceed = "SELECT REG_END, COUNT(*)  FROM GENERAL WHERE HOME_PROVINCE = '" + prov + "' AND GENDER = '" + gender + "' AND END_AGE BETWEEN " + age + "  AND YOS3_OUT = 'Proceed' GROUP BY REG_END ORDER BY REG_END";
                String NotCategorised = "SELECT REG_END, COUNT(*)  FROM GENERAL WHERE HOME_PROVINCE = '" + prov + "' AND GENDER = '" + gender + "' AND END_AGE BETWEEN " + age + " AND YOS3_OUT = 'Not Categorised' GROUP BY REG_END ORDER BY REG_END";
                conn.Open();
                if ((conn.State & System.Data.ConnectionState.Open) > 0)
                {
                    cmd = new SqliteCommand(Excluded, conn);
                    SqliteDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        LookupProv obj = new LookupProv();
                        obj.reg_End = reader.GetValue(0).ToString();
                        obj.count = reader.GetInt32(1);
                        groupExcluded.Add(obj);
                    }

                    cmd = new SqliteCommand(Qualified, conn);
                    reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        LookupProv obj = new LookupProv();
                        obj.reg_End = reader.GetValue(0).ToString();
                        obj.count = reader.GetInt32(1);
                        groupQualified.Add(obj);
                    }

                    cmd = new SqliteCommand(Proceed, conn);
                    reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        LookupProv obj = new LookupProv();
                        obj.reg_End = reader.GetValue(0).ToString();
                        obj.count = reader.GetInt32(1);
                        groupProceed.Add(obj);
                    }

                    cmd = new SqliteCommand(NotCategorised, conn);
                    reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        LookupProv obj = new LookupProv();
                        obj.reg_End = reader.GetValue(0).ToString();
                        obj.count = reader.GetInt32(1);
                        groupNotCategorised.Add(obj);
                    }
                }
                conn.Close();
                ViewBag.Excluded = groupExcluded;
                ViewBag.Qualified = groupQualified;
                ViewBag.Proceed = groupProceed;
                ViewBag.NotCategorised = groupNotCategorised;
            }
            //If Province, Race and Age filters are selected
            else if ((id.Contains("EC") | id.Contains("FS") | id.Contains("GA") | id.Contains("LP") | id.Contains("MP") | id.Contains("NW") | id.Contains("NC") | id.Contains("WC") | id.Contains("KZ")) &
               (id.Contains("Black") | id.Contains("Coloured") | id.Contains("Chinese") | id.Contains("Indian") | id.Contains("White")) & id.Contains("AND") & (id.Contains(",M,") == false | id.Contains(",F,") == false))

            {
                String prov = id.Substring(0, 2);
                String age = id.Substring(13, 9);
                String race = id.Substring(23);
                ViewBag.Prov = prov;
                ViewBag.Age = age;
                ViewBag.Race = race;

                string cs = "Filename =./SD.db";
                SqliteConnection conn = new SqliteConnection(cs);
                SqliteCommand cmd;
                List<LookupProv> groupExcluded = new List<LookupProv>();
                List<LookupProv> groupQualified = new List<LookupProv>();
                List<LookupProv> groupProceed = new List<LookupProv>();
                List<LookupProv> groupNotCategorised = new List<LookupProv>();

                String Excluded = "SELECT REG_END, COUNT(*)  FROM GENERAL WHERE HOME_PROVINCE = '" + prov + "' AND RACE = '" + race + "' AND END_AGE BETWEEN " + age + "  AND YOS3_OUT = 'Excluded' GROUP BY REG_END ORDER BY REG_END";
                String Qualified = "SELECT REG_END, COUNT(*)  FROM GENERAL WHERE HOME_PROVINCE = '" + prov + "' AND RACE = '" + race + "' AND END_AGE BETWEEN " + age + "  AND YOS3_OUT = 'Qualified' GROUP BY REG_END ORDER BY REG_END";
                String Proceed = "SELECT REG_END, COUNT(*)  FROM GENERAL WHERE HOME_PROVINCE = '" + prov + "' AND RACE = '" + race + "' AND END_AGE BETWEEN " + age + "  AND YOS3_OUT = 'Proceed' GROUP BY REG_END ORDER BY REG_END";
                String NotCategorised = "SELECT REG_END, COUNT(*)  FROM GENERAL WHERE HOME_PROVINCE = '" + prov + "' AND RACE = '" + race + "' AND END_AGE BETWEEN " + age + " AND YOS3_OUT = 'Not Categorised' GROUP BY REG_END ORDER BY REG_END";
                conn.Open();
                if ((conn.State & System.Data.ConnectionState.Open) > 0)
                {
                    cmd = new SqliteCommand(Excluded, conn);
                    SqliteDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        LookupProv obj = new LookupProv();
                        obj.reg_End = reader.GetValue(0).ToString();
                        obj.count = reader.GetInt32(1);
                        groupExcluded.Add(obj);
                    }

                    cmd = new SqliteCommand(Qualified, conn);
                    reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        LookupProv obj = new LookupProv();
                        obj.reg_End = reader.GetValue(0).ToString();
                        obj.count = reader.GetInt32(1);
                        groupQualified.Add(obj);
                    }

                    cmd = new SqliteCommand(Proceed, conn);
                    reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        LookupProv obj = new LookupProv();
                        obj.reg_End = reader.GetValue(0).ToString();
                        obj.count = reader.GetInt32(1);
                        groupProceed.Add(obj);
                    }

                    cmd = new SqliteCommand(NotCategorised, conn);
                    reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        LookupProv obj = new LookupProv();
                        obj.reg_End = reader.GetValue(0).ToString();
                        obj.count = reader.GetInt32(1);
                        groupNotCategorised.Add(obj);
                    }
                }
                conn.Close();
                ViewBag.Excluded = groupExcluded;
                ViewBag.Qualified = groupQualified;
                ViewBag.Proceed = groupProceed;
                ViewBag.NotCategorised = groupNotCategorised;
            }
            return View();
        }

        //Query that returns selected Age group
        public IActionResult Age(string id)
        {
            string cs = "Filename =./SD.db";
            SqliteConnection conn = new SqliteConnection(cs);
            SqliteCommand cmd;
            List<LookupAge> groupAge = new List<LookupAge>();
            List<LookupAge> groupMale = new List<LookupAge>();
            List<LookupAge> groupFemale = new List<LookupAge>();

            string age = id;
            ViewBag.MyString = id;

            string ageFilter = "SELECT END_AGE, COUNT(*)  FROM GENERAL WHERE YOS3_OUT='Excluded' AND END_AGE BETWEEN " + age + " GROUP BY END_AGE ORDER BY END_AGE";
            string Male = "SELECT END_AGE, COUNT(*)  FROM GENERAL WHERE GENDER = 'M' AND YOS3_OUT='Excluded' AND END_AGE BETWEEN " + age + " GROUP BY END_AGE ORDER BY END_AGE";
            string Female = "SELECT END_AGE, COUNT(*)  FROM GENERAL WHERE GENDER = 'F' AND YOS3_OUT='Excluded' AND END_AGE BETWEEN " + age + " GROUP BY END_AGE ORDER BY END_AGE";

            conn.Open();
            if ((conn.State & System.Data.ConnectionState.Open) > 0)
            {
                cmd = new SqliteCommand(ageFilter, conn);
                SqliteDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    LookupAge obj = new LookupAge();
                    obj.End_Age = reader.GetValue(0).ToString();
                    obj.count = reader.GetInt32(1);
                    groupAge.Add(obj);
                }

                cmd = new SqliteCommand(Male, conn);
                reader = cmd.ExecuteReader();
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
            ViewBag.Age = groupAge;
            ViewBag.Male = groupMale;
            ViewBag.Female = groupFemale;
            return View();

        }

        //Query that returns selected Province
        public IActionResult Province(string id)
        {
            string cs = "Filename =./SD.db";
            SqliteConnection conn = new SqliteConnection(cs);
            SqliteCommand cmd;
            List<LookupOutcome> groupMale = new List<LookupOutcome>();
            List<LookupOutcome> groupFemale = new List<LookupOutcome>();
            List<LookupProv> groupExcluded = new List<LookupProv>();
            List<LookupProv> groupQualified = new List<LookupProv>();
            List<LookupProv> groupProceed = new List<LookupProv>();
            List<LookupProv> groupNotCategorised = new List<LookupProv>();

            string prov = id;

            if (id == "EC")
            {
                ViewBag.MyString = "Eastern Cape";
            }
            else if (id == "FS")
            {
                ViewBag.MyString = "Free State";
            }
            else if (id == "GA")
            {
                ViewBag.MyString = "Gauteng";
            }
            else if (id == "KZ")
            {
                ViewBag.MyString = "KwaZulu-Natal";
            }
            else if (id == "LP")
            {
                ViewBag.MyString = "Limpopo";
            }
            else if (id == "MP")
            {
                ViewBag.MyString = "Mpumalanga";
            }
            else if (id == "NC")
            {
                ViewBag.MyString = "Northern Cape";
            }
            else if (id == "NW")
            {
                ViewBag.MyString = "North West";
            }
            else
            {
                ViewBag.MyString = "Western Cape";
            }
            String Excluded = "SELECT REG_END, COUNT(*)  FROM GENERAL WHERE HOME_PROVINCE = '" + prov + "' AND YOS3_OUT = 'Excluded' GROUP BY REG_END ORDER BY REG_END";
            String Qualified = "SELECT REG_END, COUNT(*)  FROM GENERAL WHERE HOME_PROVINCE = '" + prov + "' AND YOS3_OUT = 'Qualified' GROUP BY REG_END ORDER BY REG_END";
            String Proceed = "SELECT REG_END, COUNT(*)  FROM GENERAL WHERE HOME_PROVINCE = '" + prov + "' AND YOS3_OUT = 'Proceed' GROUP BY REG_END ORDER BY REG_END";
            String NotCategorised = "SELECT REG_END, COUNT(*)  FROM GENERAL WHERE HOME_PROVINCE = '" + prov + "' AND YOS3_OUT = 'Not Categorised' GROUP BY REG_END ORDER BY REG_END";

            string Male = "SELECT YOS3_OUT, COUNT(*)  FROM GENERAL WHERE GENDER='M' AND HOME_PROVINCE ='" + prov + "' GROUP BY YOS3_OUT ORDER BY YOS3_OUT";
            string Female = "SELECT YOS3_OUT, COUNT(*)  FROM GENERAL WHERE GENDER='F' AND HOME_PROVINCE ='" + prov + "' GROUP BY YOS3_OUT ORDER BY YOS3_OUT";
            conn.Open();
            if ((conn.State & System.Data.ConnectionState.Open) > 0)
            {
                cmd = new SqliteCommand(Excluded, conn);
                SqliteDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    LookupProv obj = new LookupProv();
                    obj.reg_End = reader.GetValue(0).ToString();
                    obj.count = reader.GetInt32(1);
                    groupExcluded.Add(obj);
                }

                cmd = new SqliteCommand(Qualified, conn);
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    LookupProv obj = new LookupProv();
                    obj.reg_End = reader.GetValue(0).ToString();
                    obj.count = reader.GetInt32(1);
                    groupQualified.Add(obj);
                }

                cmd = new SqliteCommand(Proceed, conn);
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    LookupProv obj = new LookupProv();
                    obj.reg_End = reader.GetValue(0).ToString();
                    obj.count = reader.GetInt32(1);
                    groupProceed.Add(obj);
                }

                cmd = new SqliteCommand(NotCategorised, conn);
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    LookupProv obj = new LookupProv();
                    obj.reg_End = reader.GetValue(0).ToString();
                    obj.count = reader.GetInt32(1);
                    groupNotCategorised.Add(obj);
                }

                cmd = new SqliteCommand(Male, conn);
                reader = cmd.ExecuteReader();
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
            ViewBag.Excluded = groupExcluded;
            ViewBag.Qualified = groupQualified;
            ViewBag.Proceed = groupProceed;
            ViewBag.NotCategorised = groupNotCategorised;
            ViewBag.Male = groupMale;
            ViewBag.Female = groupFemale;
            return View();
        }

        //Query that returns selected Race
        public IActionResult Race(string id)
        {
            string cs = "Filename =./SD.db";
            SqliteConnection conn = new SqliteConnection(cs);
            SqliteCommand cmd;
            List<LookupRace> groupExcluded = new List<LookupRace>();
            List<LookupRace> groupProceed = new List<LookupRace>();
            List<LookupRace> groupQualified = new List<LookupRace>();
            List<LookupRace> groupNA = new List<LookupRace>();
            List<LookupOutcome> groupRace = new List<LookupOutcome>();

            string race = id;
            ViewBag.MyString = id;

            string Race = "SELECT YOS3_OUT, COUNT(*) FROM GENERAL WHERE RACE='" + race + "' GROUP BY YOS3_OUT";
            string Excluded = "SELECT RACE, COUNT(*)  FROM GENERAL WHERE YOS3_OUT = 'Excluded' GROUP BY RACE";
            string Proceed = "SELECT RACE, COUNT(*)  FROM GENERAL WHERE YOS3_OUT = 'Proceed' GROUP BY RACE";
            string Qualified = "SELECT RACE, COUNT(*)  FROM GENERAL WHERE YOS3_OUT = 'Qualified' GROUP BY RACE";
            string NA = "SELECT RACE, COUNT(*)  FROM GENERAL WHERE YOS3_OUT = 'Not Categorised' GROUP BY RACE";

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

                cmd = new SqliteCommand(Excluded, conn);
                reader = cmd.ExecuteReader();
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
            ViewBag.Race = groupRace;
            ViewBag.Excluded = groupExcluded;
            ViewBag.Proceed = groupProceed;
            ViewBag.Qualified = groupQualified;
            ViewBag.NA = groupNA;
            return View();
        }

        //Query that returns selected Gender
        public IActionResult Gender()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
