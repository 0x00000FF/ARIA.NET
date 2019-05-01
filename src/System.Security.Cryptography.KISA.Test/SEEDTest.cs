using NUnit.Framework;

using System.Collections.Generic;
using System.Security.Cryptography.KISA;

namespace Tests
{
    public class SEEDTest
    {
        private SEEDManaged _seed;

        private static Dictionary<string, byte[]> testIOSet =
        new Dictionary<string, byte[]>() {
            {"", new byte[0]{}}
        };
        
        [SetUp]
        public void Setup()
        {
            _seed = new SEEDManaged();
        }

        [Test(
            Author = "P.Knowledge (0x00000FF)",
            Description = "Basic Unit Test for SEEDManaged Object Instantiation",
            ExpectedResult = true
        )]
        public bool TestSEEDInstantiation()
        {
            return _seed != null;
        }

        [Test(
            Author = "P.Knowledge (0x00000FF)",
            Description = "Unit Test for 128bit SEED Encryption"
        )]
        public void TestSEED128Encryption()
        {
            if (!TestSEEDInstantiation())
                Assert.Fail();
            
        }
        
        [Test(
            Author = "P.Knowledge (0x00000FF)",
            Description = "Unit Test for 128bit SEED Decryption"
        )]
        public void TestSEED128Decryption()
        {
            if (!TestSEEDInstantiation())
                Assert.Fail();

            
        }
        
        [Test(
            Author = "P.Knowledge (0x00000FF)",
            Description = "Unit Test for 256bit SEED Encryption"
        )]
        public void TestSEED256Encryption()
        {
            if (!TestSEEDInstantiation())
                Assert.Fail();
            
            
        }
        
        [Test(
            Author = "P.Knowledge (0x00000FF)",
            Description = "Unit Test for 256bit SEED Decryption"
        )]
        public void TestSEED256Decryption()
        {
            if (!TestSEEDInstantiation())
                Assert.Fail();

            
        }
    }
}