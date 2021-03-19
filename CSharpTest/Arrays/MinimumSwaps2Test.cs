using CSharp.Arrays;
using Xunit;

namespace CSharpTest.Arrays
{
    public class MinimumSwaps2Test
    {
        [Fact]
        public void Test1()
        {
            int[] data = new int[4] { 4, 3, 1, 2 };

            int actual = MinimumSwaps2.MinimumSwaps(data);

            Assert.Equal(3, actual);
        }

        [Fact]
        public void Test2()
        {
            int[] data = new int[5] { 2, 3, 4, 1, 5 };

            int actual = MinimumSwaps2.MinimumSwaps(data);

            Assert.Equal(3, actual);
        }

        [Fact]
        public void Test3()
        {
            int[] data = new int[7] { 1, 3, 5, 2, 4, 6, 7 };

            int actual = MinimumSwaps2.MinimumSwaps(data);

            Assert.Equal(3, actual);
        }

        [Fact]
        public void Test4()
        {
            int[] data = new int[7] { 7, 1, 3, 2, 4, 5, 6 };

            int actual = MinimumSwaps2.MinimumSwaps(data);

            Assert.Equal(5, actual);
        }
    }
}