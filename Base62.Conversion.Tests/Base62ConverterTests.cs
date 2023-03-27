namespace Base62.Conversion.Tests
{
    [TestClass]
    public class Base62ConverterTests
    {
        [DataTestMethod]
        [DataRow(0, "0")]
        [DataRow(7, "7")]
        [DataRow(16, "g")]
        [DataRow(61, "Z")]
        [DataRow(65, "13")]
        [DataRow(999, "g7")]
        [DataRow(9999, "2Bh")]
        [DataRow(238327, "ZZZ")]
        [DataRow(2009215674938, "zn9edcu")]
        [DataRow(23423234234234, "6EnvxMIa")]
        [DataRow(377794100552163282, "rUiF01cmr0")]
        public void Encode_Is_Correct(long id, string expected)
        {
            var encoded = Base62Converter.Encode(id);

            Assert.AreEqual(expected, encoded);
        }

        [DataTestMethod]
        [DataRow(0, "0")]
        [DataRow(7, "7")]
        [DataRow(16, "g")]
        [DataRow(61, "Z")]
        [DataRow(65, "13")]
        [DataRow(999, "g7")]
        [DataRow(9999, "2Bh")]
        [DataRow(238327, "ZZZ")]
        [DataRow(2009215674938, "zn9edcu")]
        [DataRow(377794100552163282, "rUiF01cmr0")]
        public void Decode_Is_Correct(long expected, string encoded)
        {
            var decoded = Base62Converter.Decode(encoded);

            Assert.AreEqual(expected, decoded);
        }

        [DataTestMethod]
        [DataRow(0)]
        [DataRow(7)]
        [DataRow(16)]
        [DataRow(61)]
        [DataRow(65)]
        [DataRow(999)]
        [DataRow(9999)]
        [DataRow(238327)]
        [DataRow(2009215674938)]
        [DataRow(23423234234234)]
        [DataRow(377794100552163282)]
        public void Encoded_Is_Decoded(long number)
        {
            var encoded = Base62Converter.Encode(number);
            var decoded = Base62Converter.Decode(encoded);

            Assert.AreEqual(number, decoded);
        }
    }
}