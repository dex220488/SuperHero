using Microsoft.VisualStudio.TestTools.UnitTesting;
using static SuperHero.DataAccess.Entities.Api.Enums;

namespace UnitTestProject
{
    [TestClass]
    public class ApiGetDataTests
    {
        [TestMethod]
        public void GetDataById_IdExists_ReturnsErrorFalse()
        {
            SuperHero.DataAccess.Services.Api.IService service = new SuperHero.DataAccess.Services.Api.Service(ApiGetOptions.Id, "69");
            var result = service.Get();

            Assert.IsFalse(result.HasError, result.ErrorMessage);
        }

        [TestMethod]
        public void GetDataById_IdDoesNotExists_ReturnsErrorTrue()
        {
            SuperHero.DataAccess.Services.Api.IService service = new SuperHero.DataAccess.Services.Api.Service(ApiGetOptions.Id, "999999");
            var result = service.Get();

            Assert.IsTrue(result.HasError, "Id exists");
        }

        [TestMethod]
        public void GetDataByName_NameFilteredExists_ReturnsErrorFalse()
        {
            SuperHero.DataAccess.Services.Api.IService service = new SuperHero.DataAccess.Services.Api.Service(ApiGetOptions.Search, "Batman");
            var result = service.Get();

            Assert.IsFalse(result.HasError, result.ErrorMessage);
        }

        [TestMethod]
        public void GetDataByName_NameFilteredDoesNotExists_ReturnsErrorTrue()
        {
            SuperHero.DataAccess.Services.Api.IService service = new SuperHero.DataAccess.Services.Api.Service(ApiGetOptions.Search, "I don't exist");
            var result = service.Get();

            Assert.IsTrue(result.HasError, "Id exists");
        }

        [TestMethod]
        public void GetPowerStatsById_IdExists_ReturnsErrorFalse()
        {
            SuperHero.DataAccess.Services.Api.IService service = new SuperHero.DataAccess.Services.Api.Service(ApiGetOptions.Powerstats, "69");
            var result = service.Get();

            Assert.IsFalse(result.HasError, result.ErrorMessage);
        }

        [TestMethod]
        public void GetPowerStatsById_IdDoesNotExists_ReturnsErrorTrue()
        {
            SuperHero.DataAccess.Services.Api.IService service = new SuperHero.DataAccess.Services.Api.Service(ApiGetOptions.Powerstats, "99999");
            var result = service.Get();

            Assert.IsTrue(result.HasError, "Id exists");
        }

        [TestMethod]
        public void GetImageById_IdExists_ReturnsErrorFalse()
        {
            SuperHero.DataAccess.Services.Api.IService service = new SuperHero.DataAccess.Services.Api.Service(ApiGetOptions.Image, "69");
            var result = service.Get();

            Assert.IsFalse(result.HasError, result.ErrorMessage);
        }

        [TestMethod]
        public void GetImageById_IdDoesNotExists_ReturnsErrorTrue()
        {
            SuperHero.DataAccess.Services.Api.IService service = new SuperHero.DataAccess.Services.Api.Service(ApiGetOptions.Image, "99999");
            var result = service.Get();

            Assert.IsTrue(result.HasError, "Id exists");
        }

        [TestMethod]
        public void GetConnectionsById_IdExists_ReturnsErrorFalse()
        {
            SuperHero.DataAccess.Services.Api.IService service = new SuperHero.DataAccess.Services.Api.Service(ApiGetOptions.Connections, "69");
            var result = service.Get();

            Assert.IsFalse(result.HasError, result.ErrorMessage);
        }

        [TestMethod]
        public void GetConnectionsById_IdDoesNotExists_ReturnsErrorTrue()
        {
            SuperHero.DataAccess.Services.Api.IService service = new SuperHero.DataAccess.Services.Api.Service(ApiGetOptions.Connections, "99999");
            var result = service.Get();

            Assert.IsTrue(result.HasError, "Id exists");
        }

        [TestMethod]
        public void GetWorkById_IdExists_ReturnsErrorFalse()
        {
            SuperHero.DataAccess.Services.Api.IService service = new SuperHero.DataAccess.Services.Api.Service(ApiGetOptions.Work, "69");
            var result = service.Get();

            Assert.IsFalse(result.HasError, result.ErrorMessage);
        }

        [TestMethod]
        public void GetWorkById_IdDoesNotExists_ReturnsErrorTrue()
        {
            SuperHero.DataAccess.Services.Api.IService service = new SuperHero.DataAccess.Services.Api.Service(ApiGetOptions.Work, "9999");
            var result = service.Get();

            Assert.IsTrue(result.HasError, "Id exists");
        }

        [TestMethod]
        public void GetAppearanceById_IdExists_ReturnsErrorFalse()
        {
            SuperHero.DataAccess.Services.Api.IService service = new SuperHero.DataAccess.Services.Api.Service(ApiGetOptions.Appearance, "69");
            var result = service.Get();

            Assert.IsFalse(result.HasError, result.ErrorMessage);
        }

        [TestMethod]
        public void GetAppearanceById_IdDoesNotExists_ReturnsErrorTrue()
        {
            SuperHero.DataAccess.Services.Api.IService service = new SuperHero.DataAccess.Services.Api.Service(ApiGetOptions.Appearance, "99999");
            var result = service.Get();

            Assert.IsTrue(result.HasError, "Id exists");
        }

        [TestMethod]
        public void GetBiographyById_IdExists_ReturnsErrorFalse()
        {
            SuperHero.DataAccess.Services.Api.IService service = new SuperHero.DataAccess.Services.Api.Service(ApiGetOptions.Biography, "69");
            var result = service.Get();

            Assert.IsFalse(result.HasError, result.ErrorMessage);
        }

        [TestMethod]
        public void GetBiographyById_IdDoesNotExists_ReturnsErrorTrue()
        {
            SuperHero.DataAccess.Services.Api.IService service = new SuperHero.DataAccess.Services.Api.Service(ApiGetOptions.Biography, "99999");
            var result = service.Get();

            Assert.IsTrue(result.HasError, "Id exists");
        }
    }
}