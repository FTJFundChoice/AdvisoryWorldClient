﻿using FTJFundChoice.AdvisoryWorldClient.Compositions;
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
            privateLabel.UserId = 7954;

            privateLabel.Colors.Theme.Color1 = "#650000";
            privateLabel.Colors.Theme.Color2 = "#00E500";
            privateLabel.Colors.Theme.Color3 = "#0000E5";
            privateLabel.Colors.Theme.Color4 = "#000000";
            privateLabel.Colors.Theme.Color5 = "#FFFFFF";


            privateLabel.Info.AboutCompany = "Ninjas are awesome!";
            privateLabel.Info.Thumbnail = File.ReadAllBytes(@"C:\temp\goggles2.jpg");
            privateLabel.Info.UserImage = File.ReadAllBytes(@"C:\temp\Hot-Toys-Death-Trooper.jpg");


            var client = new Client(BaseUrl, Username, Password);
            Assert.True(await client.AuthenticateAsync());
            var pl = new PrivateLabelModule(client);
            var result = await pl.SubmitPrivateLabelData(privateLabel);
            Assert.NotNull(result);
            Assert.Equal(result.Success, "true");
        }

    }
}
