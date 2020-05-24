using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using BID_E.Models;
using Microsoft.Data.Sqlite;

namespace BID_E.Controllers
{
    public class GraphsController : Controller
    {
        private readonly ILogger<GraphsController> _logger;

        public GraphsController(ILogger<GraphsController> logger)
        {
            _logger = logger;
        }

        // GET: /<controller>/
        public IActionResult Landing()
        {
            string cs = "Filename =./SD.db";
            SqliteConnection conn = new SqliteConnection(cs);
            SqliteCommand cmd;
            List<LookupOutcome> group2008 = new List<LookupOutcome>();
            List<LookupOutcome> group2009 = new List<LookupOutcome>();
            List<LookupOutcome> group2010 = new List<LookupOutcome>();
            List<LookupOutcome> group2011 = new List<LookupOutcome>();
            List<LookupOutcome> group2012 = new List<LookupOutcome>();
            List<LookupOutcome> group2013 = new List<LookupOutcome>();
            List<LookupOutcome> group2014 = new List<LookupOutcome>();
            List<LookupOutcome> group2015 = new List<LookupOutcome>();
            List<LookupOutcome> group2016 = new List<LookupOutcome>();
            List<LookupOutcome> group2017 = new List<LookupOutcome>();
            List<LookupOutcome> group2018 = new List<LookupOutcome>();


            string Outcome2008 = "SELECT YOS3_OUT, COUNT(*)  FROM GENERAL WHERE REG_END = '2008' GROUP BY YOS3_OUT";
            string Outcome2009 = "SELECT YOS3_OUT, COUNT(*)  FROM GENERAL WHERE REG_END = '2009' GROUP BY YOS3_OUT";
            string Outcome2010 = "SELECT YOS3_OUT, COUNT(*)  FROM GENERAL WHERE REG_END = '2010' GROUP BY YOS3_OUT";
            string Outcome2011 = "SELECT YOS3_OUT, COUNT(*)  FROM GENERAL WHERE REG_END = '2011' GROUP BY YOS3_OUT";
            string Outcome2012 = "SELECT YOS3_OUT, COUNT(*)  FROM GENERAL WHERE REG_END = '2012' GROUP BY YOS3_OUT";
            string Outcome2013 = "SELECT YOS3_OUT, COUNT(*)  FROM GENERAL WHERE REG_END = '2013' GROUP BY YOS3_OUT";
            string Outcome2014 = "SELECT YOS3_OUT, COUNT(*)  FROM GENERAL WHERE REG_END = '2014' GROUP BY YOS3_OUT";
            string Outcome2015 = "SELECT YOS3_OUT, COUNT(*)  FROM GENERAL WHERE REG_END = '2015' GROUP BY YOS3_OUT";
            string Outcome2016 = "SELECT YOS3_OUT, COUNT(*)  FROM GENERAL WHERE REG_END = '2016' GROUP BY YOS3_OUT";
            string Outcome2017 = "SELECT YOS3_OUT, COUNT(*)  FROM GENERAL WHERE REG_END = '2017' GROUP BY YOS3_OUT";
            string Outcome2018 = "SELECT YOS3_OUT, COUNT(*)  FROM GENERAL WHERE REG_END = '2018' GROUP BY YOS3_OUT";


            conn.Open();
            if ((conn.State & System.Data.ConnectionState.Open) > 0)
            {
                cmd = new SqliteCommand(Outcome2008, conn);
                SqliteDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    LookupOutcome obj = new LookupOutcome();
                    obj.outcome = reader.GetValue(0).ToString();
                    obj.count = reader.GetInt32(1);
                    group2008.Add(obj);
                }

                cmd = new SqliteCommand(Outcome2009, conn);
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    LookupOutcome obj = new LookupOutcome();
                    obj.outcome = reader.GetValue(0).ToString();
                    obj.count = reader.GetInt32(1);
                    group2009.Add(obj);
                }

                cmd = new SqliteCommand(Outcome2010, conn);
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    LookupOutcome obj = new LookupOutcome();
                    obj.outcome = reader.GetValue(0).ToString();
                    obj.count = reader.GetInt32(1);
                    group2010.Add(obj);
                }

                cmd = new SqliteCommand(Outcome2011, conn);
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    LookupOutcome obj = new LookupOutcome();
                    obj.outcome = reader.GetValue(0).ToString();
                    obj.count = reader.GetInt32(1);
                    group2011.Add(obj);
                }

                cmd = new SqliteCommand(Outcome2012, conn);
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    LookupOutcome obj = new LookupOutcome();
                    obj.outcome = reader.GetValue(0).ToString();
                    obj.count = reader.GetInt32(1);
                    group2012.Add(obj);
                }

                cmd = new SqliteCommand(Outcome2013, conn);
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    LookupOutcome obj = new LookupOutcome();
                    obj.outcome = reader.GetValue(0).ToString();
                    obj.count = reader.GetInt32(1);
                    group2013.Add(obj);
                }

                cmd = new SqliteCommand(Outcome2014, conn);
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    LookupOutcome obj = new LookupOutcome();
                    obj.outcome = reader.GetValue(0).ToString();
                    obj.count = reader.GetInt32(1);
                    group2014.Add(obj);
                }

                cmd = new SqliteCommand(Outcome2015, conn);
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    LookupOutcome obj = new LookupOutcome();
                    obj.outcome = reader.GetValue(0).ToString();
                    obj.count = reader.GetInt32(1);
                    group2015.Add(obj);
                }

                cmd = new SqliteCommand(Outcome2016, conn);
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    LookupOutcome obj = new LookupOutcome();
                    obj.outcome = reader.GetValue(0).ToString();
                    obj.count = reader.GetInt32(1);
                    group2016.Add(obj);
                }

                cmd = new SqliteCommand(Outcome2017, conn);
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    LookupOutcome obj = new LookupOutcome();
                    obj.outcome = reader.GetValue(0).ToString();
                    obj.count = reader.GetInt32(1);
                    group2017.Add(obj);
                }

                cmd = new SqliteCommand(Outcome2018, conn);
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    LookupOutcome obj = new LookupOutcome();
                   obj.outcome = reader.GetValue(0).ToString();
                    obj.count = reader.GetInt32(1);
                   group2018.Add(obj);
                }

            }

            conn.Close();
            ViewBag.year08 = group2008;
            ViewBag.year09 = group2009;
            ViewBag.year10 = group2010;
            ViewBag.year11 = group2011;
            ViewBag.year12 = group2012;
            ViewBag.year13 = group2013;
            ViewBag.year14 = group2014;
            ViewBag.year15 = group2015;
            ViewBag.year16 = group2016;
            ViewBag.year17 = group2017;
            ViewBag.year18 = group2018;

            return View();

        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
