using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using XOGame_Model;

namespace XOGame_ModuleTest
{
    public class Tests
    {
        [Fact]
        public void SettingsTest_ValidateSize1()
        {
            string size = "10x10";
            Settings settings = new Settings();

            bool result = settings.ValidateSize(size);

            Assert.True(result);
        }

        [Fact]
        public void SettingsTest_ValidateSize2()
        {
            string size = "9x9";
            Settings settings = new Settings();

            bool result = settings.ValidateSize(size);

            Assert.False(result);
        }

        [Fact]
        public void SettingsTest_ValidateSize3()
        {
            string size = "sngdsgnlkesgnxefwef";
            Settings settings = new Settings();

            bool result = settings.ValidateSize(size);

            Assert.False(result);
        }
    }
}
