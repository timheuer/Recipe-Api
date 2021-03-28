using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.CosmosRepository;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using RecipeApi.Controllers;
using RecipeApi.Data;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Threading.Tasks;

namespace APITests
{
    [TestClass]
    public class UnitTests
    {
        public UnitTests()
        {

        }

        [TestMethod]
        public void IsRunningOnLinux()
        {
            Assert.IsTrue(RuntimeInformation.IsOSPlatform(OSPlatform.Linux));
        }

        [TestMethod]
        public void IsRunningOnWindows()
        {
            Assert.IsTrue(RuntimeInformation.IsOSPlatform(OSPlatform.Windows));
        }

        private List<RecipeApi.Data.Recipe> GetRecipes()
        {
            var testRecipes = new List<RecipeApi.Data.Recipe>();

            testRecipes.Add(new RecipeApi.Data.Recipe() { Id = "1", Name = "Recipe One" });
            testRecipes.Add(new RecipeApi.Data.Recipe() { Id = "2", Name = "Recipe Two" });
            testRecipes.Add(new RecipeApi.Data.Recipe() { Id = "3", Name = "Recipe Three" });

            return testRecipes;
        }
    }
}
