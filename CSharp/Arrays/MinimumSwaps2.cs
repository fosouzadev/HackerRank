using System.Linq;

namespace CSharp.Arrays
{
    public static class MinimumSwaps2
    {
        public static int MinimumSwaps(int[] arr)
        {
            int swaps = 0;
            int index = -1;
            bool[] testList = new bool[arr.Length];

            var list = arr.Select(s => new { Value = s, Index = ++index })
                          .OrderBy(o => o.Value)
                          .ToArray();

            for (int  i = 0; i < list.Length; i++)
            {
                if (testList[i] || list[i].Index == i)
                    continue;

                int cycle = 0;
                int j = i;

                while (!testList[j])
                {
                    testList[j] = true;
                    j = list[j].Index;
                    ++cycle;
                }

                if (cycle > 0)
                    swaps += (cycle - 1);
            }

            return swaps;
        }
    }
}