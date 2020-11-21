using System.Threading.Tasks;
using Shouldly;
using Xunit;

namespace SpiderWeb.io.Pages
{
    public class Index_Tests : ioWebTestBase
    {
        [Fact]
        public async Task Welcome_Page()
        {
            var response = await GetResponseAsStringAsync("/");
            response.ShouldNotBeNull();
        }
    }
}
