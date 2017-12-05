using FTJFundChoice.AdvisoryWorldClient.Compositions;
using FTJFundChoice.AdvisoryWorldClient.Model.Theme;
using FTJFundChoice.AdvisoryWorldClient.RestApiCalls;
using FTJFundChoice.AdvisoryWorldClient.Test._base;
using System.IO;
using Xunit;

namespace AdvisoryWorldClient.Test.BrandingTests
{
    [Collection("Branding")]
    public class BrandingTestContext : TestBase
    {
        [Fact]
        public async void ShouldUpdatePrivateLabelDetails()
        {
            var privateLabel = new PrivateLabel() {};
            privateLabel.UserId = 27414;

            privateLabel.Colors.Theme.Color1 = "#00E500";
            //privateLabel.Colors.Theme.Color2 = "#00E500";
            //privateLabel.Colors.Theme.Color3 = "#0000E5";
            //privateLabel.Colors.Theme.Color4 = "#000000";
            //privateLabel.Colors.Theme.Color5 = "#FFFFFF";


            privateLabel.Info.AboutCompany = $"FTJ Testing for AW private label end point, called {System.DateTime.Now}!";
            privateLabel.Info.Thumbnail = File.ReadAllBytes(@"Images\What_business_to_start_2013_crop.jpg");
            //privateLabel.Info.UserImage = File.ReadAllBytes(@"Images\startup.jpg");


            var client = new Client(BaseUrl, Username, Password);
            Assert.True(await client.AuthenticateAsync());
            var pl = new PrivateLabelModule(client);
            var result = await pl.SubmitPrivateLabelData(privateLabel);
            Assert.NotNull(result);
            Assert.Equal(result.Success, "true");
        }

        [Fact]
        public async void ShouldRemoveCompanyImage()
        {
            var client = new Client(BaseUrl, Username, Password);
            Assert.True(await client.AuthenticateAsync());
            var pl = new PrivateLabelModule(client);
            var result = await pl.DeleteLogo(25772);
            Assert.NotNull(result);
            Assert.Equal(result.Success, "true");
        }

        [Fact]
        public async void ShouldRemoveCompanyColors()
        {
            var client = new Client(BaseUrl, Username, Password);
            Assert.True(await client.AuthenticateAsync());
            var pl = new PrivateLabelModule(client);
            var result = await pl.DeleteColors(25772);
            Assert.NotNull(result);
            Assert.Equal(result.Success, "true");
        }

        [Fact]
        public async void ShouldRemoveThumbnails()
        {
            var client = new Client(BaseUrl, Username, Password);
            Assert.True(await client.AuthenticateAsync());
            var pl = new PrivateLabelModule(client);
            var result = await pl.DeleteThumbnail(25772);
            Assert.NotNull(result);
            Assert.Equal(result.Success, "true");
        }

    }
}
