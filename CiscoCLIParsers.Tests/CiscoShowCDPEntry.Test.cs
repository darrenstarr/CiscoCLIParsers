using CiscoCLIParsers.Tests.Common.JsonHelpers;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Xunit;

namespace CiscoCLIParsers.Tests
{
    public class CiscoShowCDPEntryTest
    {
        public CiscoShowCDPEntryTest()
        {
            JsonConvert.DefaultSettings = () => new JsonSerializerSettings
            {
                Converters = new List<JsonConverter>
                {
                    new IPAddressConverter(),
                    new IPEndPointConverter(),
                    new Newtonsoft.Json.Converters.StringEnumConverter()
                }
            };
        }

        private string GetSampleData(string name)
        {
            var stream = this.GetType().Assembly.GetManifestResourceStream(name);
            using (var reader = new StreamReader(stream, Encoding.UTF8))
            {
                return reader.ReadToEnd();
            }
        }

        private bool CompareJsonArray(string a, string b)
        {
            var objectA= JArray.Parse(a);
            var objectB = JArray.Parse(b);

            return JToken.DeepEquals(objectA, objectB);
        }

        public bool ShowCDPEntryParses(string resourceName)
        {
            var text = GetSampleData("CiscoCLIParsers.Tests.Data.CiscoShowCDPEntryTest." + resourceName + ".txt");
            var expectedJson = GetSampleData("CiscoCLIParsers.Tests.Data.CiscoShowCDPEntryTest." + resourceName + ".json");

            var result = CiscoParser.ParseShowCDPEntries(text);
            Assert.NotNull(result);
            Assert.NotEmpty(result);

            var json = JsonConvert.SerializeObject(result, Formatting.Indented);

            Assert.NotNull(json);
            Assert.NotEmpty(json);

            return CompareJsonArray(json, expectedJson);
        }

        [Fact]
        public void C3750E_15_0_2_SE2()
        {
            var resourceName = "C3750E-15_0(2)SE2";
            Assert.True(ShowCDPEntryParses(resourceName));

            return;
        }

        [Fact]
        public void C2960G_15_0_1_SE3()
        {
            var resourceName = "C2960G-15_0(1)SE3";
            Assert.True(ShowCDPEntryParses(resourceName));

            return;
        }

        [Fact]
        public void C2811_15_1_4_M12a()
        {
            var resourceName = "C2811-15.1(4)M12a";
            Assert.True(ShowCDPEntryParses(resourceName));

            return;
        }

        [Fact]
        public void C2960Plus()
        {
            var resourceName = "c2960plus";
            Assert.True(ShowCDPEntryParses(resourceName));

            return;
        }
    }
}
