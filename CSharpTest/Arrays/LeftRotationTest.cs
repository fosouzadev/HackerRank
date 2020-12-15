using CSharp.Arrays;
using Xunit;

namespace CSharpTest.Arrays
{
    public class LeftRotationTest
    {
        [Fact]
        public void Test1()
        {
            int[] data = new int[5] { 1, 2, 3, 4, 5 };

            int[] actual = LeftRotation.RotLeft(data, 4);

            Assert.Equal(new int[5] { 5, 1, 2, 3, 4 }, actual);
        }

        [Fact]
        public void Test2()
        {
            int[] data = new int[5] { 1, 2, 3, 4, 5 };

            int[] actual = LeftRotation.RotLeft(data, 2);

            Assert.Equal(new int[5] { 3, 4, 5, 1, 2 }, actual);
        }

        [Fact]
        public void Test3()
        {
            int[] data = new int[6] { 1, 2, 3, 4, 5, 6 };

            int[] actual = LeftRotation.RotLeft(data, 3);

            Assert.Equal(new int[6] { 4, 5, 6, 1, 2, 3 }, actual);
        }
    }
}