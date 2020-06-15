using BID_E.Controllers;
using BID_E.Models;
using SQLite.Models;
using System;
using System.Linq;
using Xunit;
using Xunit.Sdk;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Microsoft.EntityFrameworkCore;
using System.Data.Common;
using Microsoft.Data.Sqlite;
using System.Configuration;

using Microsoft.VisualStudio.Web.CodeGeneration.EntityFrameworkCore;
using Microsoft.AspNetCore.Http.Features;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore.Storage;

namespace BID_Etests
{
    public class QueriesControllerTests
    {
        private readonly ILogger<QueriesController> _logger;
        private DatabaseContext db;
        QueriesController query;
        public QueriesControllerTests()
        {
            query = new QueriesController(_logger,db);
        }

        [Fact]
        public void QueriesControllerTests_genderall()
        {
            var viewResult = query.Gender();

            Assert.NotNull(viewResult);
        }
    //    [Fact]
    //    public void QueriesControllerTests_Landing()
    //    {
    //        var viewResult = query.Landing();

    //        Assert.NotNull(viewResult);
    //   }
    //    [Fact]
    //    public void QueriesControllerTests_Gen()
    //    {
    //        var viewResult = query.Gen();

    //        Assert.NotNull(viewResult);
    //    }
    //    [Fact]
    //    public void QueriesControllerTests_Race()
    //    {
    //        var viewResult = query.Race("b");

    //Assert.NotNull(viewResult);
    //    }
    }
}
