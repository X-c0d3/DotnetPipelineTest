using DotnetPipelineTest.Web.Controllers;
using Microsoft.AspNetCore.Mvc;
using System;
using Xunit;

namespace DotnetPipelineTest.Tests {
    public class UnitTest1 {
        [Fact]
        public void Test1 () {
            var controller = new HomeController ();
            Assert.IsType<ViewResult> (controller.Index ());
        }
    }
}