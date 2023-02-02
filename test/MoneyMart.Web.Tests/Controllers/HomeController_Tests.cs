using System.Threading.Tasks;
using MoneyMart.Models.TokenAuth;
using MoneyMart.Web.Controllers;
using Shouldly;
using Xunit;

namespace MoneyMart.Web.Tests.Controllers
{
    public class HomeController_Tests: MoneyMartWebTestBase
    {
        [Fact]
        public async Task Index_Test()
        {
            await AuthenticateAsync(null, new AuthenticateModel
            {
                UserNameOrEmailAddress = "admin",
                Password = "123qwe"
            });

            //Act
            var response = await GetResponseAsStringAsync(
                GetUrl<HomeController>(nameof(HomeController.Index))
            );

            //Assert
            response.ShouldNotBeNullOrEmpty();
        }
    }
}