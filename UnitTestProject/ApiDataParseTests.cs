using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using static SuperHero.DataAccess.Entities.Api.Enums;

namespace UnitTestProject
{
    [TestClass]
    public class ApiDataParseTests
    {
        [TestMethod]
        public void ParseSearchOutput_ParseSuccessfully_ReturnsNoFail()
        {
            SuperHero.DataAccess.Services.Api.IService service = new SuperHero.DataAccess.Services.Api.Service(ApiGetOptions.Search, "Batman");
            var result = service.Get();

            try
            {
                var parseSearch = new SuperHero.DataAccess.Services.Parse.Search();
                parseSearch.Cast(result.Content);
            }
            catch (Exception ex)
            {
                Assert.Fail("Expected no exception, but got: " + ex.Message);
            }
        }
    }
}