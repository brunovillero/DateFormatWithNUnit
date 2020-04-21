using NUnit.Framework;
using Library;
namespace Library.Test
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {

        }

        [Test, Sequential]
        public void TestFormat
        (
            [Values("02/12/1988", "02/12/1944")] string x,
            [Values("aaaa-mm-dd", "DD-MM-YYYY")] string y,
            [Values("1988-12-02", "02-12-1944")] string z
        )
        {
            Assert.AreEqual(z, DateFormat.ChangeFormat(x, y));
        }

        [Test, Combinatorial]
        public void TestNotValidFormat
        (
            [Values("02/01/1988", "02/05/1944", "03/10/1967")] string x,
            [Values("ffff-yy", "", null)] string y,
            [Values(null, null, null)] string z
        )
        {
            Assert.AreEqual(z, DateFormat.ChangeFormat(x, y));
        }

        [Test, Sequential]

        public void TestNotValidDate
        (
            [Values("hasdgjashd", "", null, "2/2/76")] string x,
            [Values("aaaa-mm-dd", "DD-MM-YYYY")] string y,
            [Values(null, null, null)] string z
        )
        {
            Assert.AreEqual(z, DateFormat.ChangeFormat(x, y));
        }
    }
}