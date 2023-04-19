using Microsoft.VisualStudio.TestTools.UnitTesting;
using DrinkWater.SettingServices;

using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using System.Windows.Media.Imaging;

namespace DrinkWater.SettingServices.Tests
{
    [TestClass()]
    public class ImageHandlerTests
    {
        [Fact]
        public void ChooseAvatarTest()
        {
            ImageHandler imageHandler = new ImageHandler();

            var image = imageHandler.ConvertBitmap(new System.Drawing.Bitmap(100, 100));

            Xunit.Assert.IsType<BitmapImage>(image);
        }

        [Fact]
        public void ChooseAvatarNotBitmapMetadataTest()
        {
            ImageHandler imageHandler = new ImageHandler();

            var image = imageHandler.ConvertBitmap(new System.Drawing.Bitmap(100, 100));

            Xunit.Assert.IsNotType<BitmapMetadata>(image);
        }
    }
}