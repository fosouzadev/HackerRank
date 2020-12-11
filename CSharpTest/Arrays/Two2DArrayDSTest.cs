using Xunit;
using CSharp.Arrays;

namespace CSharpTest
{
    public class Two2DArrayDSTest
    {
        [Fact]
        public void Test1()
        {
            int[][] data = 
            {
                new int[] { -9, -9, -9,  1, 1, 1 },
                new int[] {  0, -9,  0,  4, 3, 2 },
                new int[] { -9, -9, -9,  1, 2, 3 },
                new int[] {  0,  0,  8,  6, 6, 0 },
                new int[] {  0,  0,  0, -2, 0, 0 },
                new int[] {  0,  0,  1,  2, 4, 0 }
            };

            int actual = Two2DArrayDS.HourglassSum(data);

            Assert.Equal(28, actual);
        }

        [Fact]
        public void Test2()
        {
            int[][] data = 
            {
                new int[] { 1, 1, 1, 0, 0, 0 },
                new int[] { 0, 1, 0, 0, 0, 0 },
                new int[] { 1, 1, 1, 0, 0, 0 },
                new int[] { 0, 0, 2, 4, 4, 0 },
                new int[] { 0, 0, 0, 2, 0, 0 },
                new int[] { 0, 0, 1, 2, 4, 0 }
            };

            int actual = Two2DArrayDS.HourglassSum(data);

            Assert.Equal(19, actual);
        }
    }
}