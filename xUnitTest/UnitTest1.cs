using Xunit;

namespace xUnitTest
{
    public class UnitTest1
    {
        [Fact]
        public void Equal()
        {
            Assert.Equal(1, 1);
        }

        [Fact]
        public void Contains()
        {
            Assert.Contains("123","abc123456def");
        }

        [Fact]
        public void NotEqual()
        {
            Assert.NotEqual<string>("123","abc123456def");
        }

        [Fact]
        public void DoesNotContain()
        {
            Assert.DoesNotContain<string>("123",new string[] { "abc13456def" });
        }

        [Fact]
        public void Matches()
        {
            Assert.Matches(@"[A-Z]{3}\w+", "ABCD");
        }

        [Fact]
        public void DoesNotMatch()
        {
            Assert.DoesNotMatch(@"[A-Z]{3}", "AB");
        }

        [Fact]
        public void Empty()
        {
            Assert.Empty(@"");
        }

        [Fact]
        public void StrictEqual()
        {
            Assert.StrictEqual((int)123, (double)123.00);
        }

        [Fact]
        public void EndsWith()
        {
            Assert.EndsWith("123", "54123");
        }

        [Fact]
        public void InRange()
        {
            Assert.InRange(12, 0, 100);
        }

        [Fact]
        public void IsType()
        {

            Assert.IsType(typeof(int), 123);
        }

        [Fact]
        public void IsNotType()
        {

            Assert.IsNotType(typeof(int), "");
        }

        [Fact]
        public void Same()
        {
            string s1 = "1";
            string s2 = s1;
            Assert.Same(s1, s2);
        }

        [Fact]
        public void NotSame()
        {
            string s1 = "1";
            string s2 = "12";
            Assert.NotSame(s1, s2);
        }

        [Fact]
        public void StartsWith()
        {
            Assert.StartsWith("12", "1234");
        }


        [Fact( Skip = "This is to skip")]
        public void Skip()
        {
            Assert.Equal(1, 1);
        }
    }
}