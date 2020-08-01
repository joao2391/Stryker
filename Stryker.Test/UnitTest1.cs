using Microsoft.AspNetCore.Mvc;
using NUnit.Framework;
using Stryker;
using Stryker.Controllers;
using System.Threading.Tasks;

namespace Tests
{
    public class Tests
    {

        ValuesController _controller;

        [SetUp]
        public void Setup()
        {
            _controller = new ValuesController();
        }

        [Test]
        public async Task BadRequest_Test_Method_Async()
        {

            var result = await _controller.Get("");
            var type = result.GetType();

            Assert.AreSame(typeof(BadRequestResult), type);
            //var badReq = new BadRequestObjectResult(result);

            //var statusCode = badReq.StatusCode;

            //Assert.AreEqual(400, statusCode);
        }

        [Test]
        public async Task OK_Get_Method_Async()
        {

            var result = await _controller.Get("testing");

            var type = result.GetType();

            Assert.AreSame(typeof(OkResult), type);
        }

        [Test]
        public async Task BadRequest_Get_Method_Async()
        {

            var result = await _controller.GetAnother("");

            var type = result.GetType();

            Assert.AreSame(typeof(BadRequestResult), type);
        }

        [Test]
        public async Task OK_GetAnother_Method_Async()
        {

            var result = await _controller.GetAnother("testing");

            var type = result.GetType();

            Assert.AreSame(typeof(OkResult), type);
        }

        [Test]
        public async Task BadRequest_User_Method_Async()
        {

            var result = await _controller.GetUser(new User());

            var type = result.GetType();

            Assert.AreSame(typeof(BadRequestResult), type);
        }

        [Test]
        public async Task OK_User_Method_Async()
        {

            var result = await _controller.GetUser(new User{Name = "joao", Password = "sasas" });

            var type = result.GetType();

            Assert.AreSame(typeof(OkResult), type);
        }

        [Test]
        public async Task BadRequest_AnotherUser_Method_Async()
        {

            var result = await _controller.GetAnotherUser(new User());

            var type = result.GetType();

            Assert.AreSame(typeof(BadRequestResult), type);
        }

        [Test]
        public async Task OK_AnotherUser_Method_Async()
        {

            var result = await _controller.GetAnotherUser(new User { Name = "joao", Password = "sasas" });

            var type = result.GetType();

            Assert.AreSame(typeof(OkResult), type);
        }
    }
}